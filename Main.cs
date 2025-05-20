using static System.Net.Mime.MediaTypeNames;

namespace ElectricField
{
    public partial class Main : Form
    {
        readonly List<EPoint> points = [];
        // Электрическое поле
        Bitmap EField;
        int linesCount = 12;
        double stepLength = 5;

        // Эквипотенциальное поле
        Bitmap EqPField;
        int fieldCols = 50;
        int fieldRows = 50;
        float density = 0.001f;


        public Main()
        {
            InitializeComponent();
            EField = new(field.Width, field.Height);
            EqPField = new(field.Width, field.Height);
            SetStyle(ControlStyles.DoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            UpdateStyles();
            field.Paint += Field_Paint;
        }

        private void Field_Paint(object? sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(EqPField, Point.Empty);
            e.Graphics.DrawImage(EField, Point.Empty);
        }

        private void UpdateField_Tick(object sender, EventArgs e)
        {
            EField = new(field.Width, field.Height);
            EqPField = new(field.Width, field.Height);
            if (EqPFieldCheck.Checked)
            {
                DrawEquipotentialField();
            }
            if (EFieldCheck.Checked)
            {
                DrawElectricField();
            }
            field.Invalidate();
            field.Update();
        }

        public void DrawEquipotentialField()
        {
            int pointSize = 30;
            pointSize = pointSizeBar.Value;
            if (points.Count == 0) return;

            Graphics g = Graphics.FromImage(EqPField);
            g.Clear(Color.Transparent);

            float rectWidth = EqPField.Width / fieldCols;
            float rectHeight = EqPField.Height / fieldRows;
            int potentialCount = (int)(4 / density / pointSize);

            for (int e = 0; e < potentialCount; e++)
            {
                float targetPotential = e * density;
                for (int x = 0; x < fieldCols + 1; x++)
                {
                    for (int y = 0; y < fieldRows + 2; y++)
                    {
                        PointF[] vertics =
                        [
                            new PointF(rectWidth * x, rectHeight * y),
                            new PointF(rectWidth * (x+1), rectHeight * y),
                            new PointF(rectWidth * (x+1), rectHeight * (y+1)),
                            new PointF(rectWidth * x, rectHeight * (y+1)),
                        ];
                        double[] potentials =
                        [
                            GetPotential(vertics[0]),
                            GetPotential(vertics[1]),
                            GetPotential(vertics[2]),
                            GetPotential(vertics[3])
                        ];
                        PointF? first = null;
                        PointF? second = null;
                        for (int i = 0; i < 4; i++)
                        {
                            if ((potentials[i] > targetPotential && potentials[(i + 1) % 4] < targetPotential) || (potentials[i] < targetPotential && potentials[(i + 1) % 4] > targetPotential))
                            {
                                if (first == null) first = Interpolate(vertics[i], vertics[(i + 1) % 4], targetPotential);
                                else
                                {
                                    second = Interpolate(vertics[i], vertics[(i + 1) % 4], targetPotential);
                                    break;
                                }
                            }
                        }
                        if (first != null && second != null)
                        {
                            g.DrawLine(Pens.Red, (PointF)first, (PointF)second);
                        }
                    }
                }
            }
        }

        private void DrawElectricField()
        {
            List<EPoint> saved_points = points;
            Graphics g = Graphics.FromImage(EField);
            g.Clear(Color.Transparent);
            int lineLength = 1100;
            int steps = (int)(lineLength / stepLength);
            const double k = 9e9;

            foreach (var charge in saved_points)
            {
                for (int i = 0; i < linesCount; i++)
                {
                    // Начинаем линию вокруг заряда, равномерно распределяя по окружности
                    double angle = 2 * Math.PI * i / linesCount;
                    double startX = charge.Center.X + Math.Cos(angle) * pointSizeBar.Value / 2; // Смещаем от центра на радиус точки
                    double startY = charge.Center.Y + Math.Sin(angle) * pointSizeBar.Value / 2;

                    PointF currentPoint = new((float)startX, (float)startY);

                    for (int stepIndex = 0; stepIndex < steps; stepIndex++)
                    {
                        // Вычисляем вектор поля в текущей точке
                        double Ex = 0;
                        double Ey = 0;

                        foreach (var c in points)
                        {
                            double dx = currentPoint.X - c.Center.X;
                            double dy = currentPoint.Y - c.Center.Y;
                            double rSquared = dx * dx + dy * dy;
                            double r = Math.Sqrt(rSquared);

                            // Если точка слишком близко к отрицательному заряду - заканчиваем прерываем цикл
                            if (r < pointSizeBar.Value / 2 && c.Sign == -1)
                            {
                                stepIndex = steps;
                                break;
                            }

                            double E_magnitude = k * c.Sign / rSquared;
                            Ex += E_magnitude * dx / r;
                            Ey += E_magnitude * dy / r;
                        }
                        if (stepIndex == steps) break;

                        // Нормализуем вектор поля
                        double E_norm = Math.Sqrt(Ex * Ex + Ey * Ey);
                        if (E_norm < 1e-4) break;

                        double dirX = Ex / E_norm;
                        double dirY = Ey / E_norm;

                        // Следующая точка линии
                        float nextX = (float)(currentPoint.X + dirX * stepLength);
                        float nextY = (float)(currentPoint.Y + dirY * stepLength);

                        // Рисуем сегмент линии
                        g.DrawLine(Pens.Blue, currentPoint.X, currentPoint.Y, nextX, nextY);
                        currentPoint.X = nextX;
                        currentPoint.Y = nextY;
                    }
                }
            }
        }

        PointF Interpolate(PointF p1, PointF p2, float target)
        {
            // Проверка, что целевое значение лежит между значениями на концах отрезка
            if ((GetPotential(p1) - target) * (GetPotential(p2) - target) > 0) return new(0, 0);

            // Если значения равны и равны target, то точка — любая на отрезке
            if (Math.Abs(GetPotential(p1) - GetPotential(p2)) < 1e-12)
                return new(p1.X, p1.Y); // или (p2.X, p2.Y), так как они одинаковы

            // Линейная интерполяция по значению функции
            float t = (float)((target - GetPotential(p1)) / (GetPotential(p2) - GetPotential(p1)));

            // Интерполируем координаты
            float x = p1.X + t * (p2.X - p1.X);
            float y = p1.Y + t * (p2.Y - p1.Y);

            return new(x, y);
        }

        double GetPotential(PointF p)
        {
            double potentialSum = 0.0;
            foreach (var obj in points)
            {
                double dx = p.X - obj.Center.X;
                double dy = p.Y - obj.Center.Y;
                double rSquared = dx * dx + dy * dy;

                if (rSquared == 0) continue;

                double r = Math.Sqrt(rSquared);
                potentialSum += obj.Sign / r;
            }
            return potentialSum;
        }

        private void AddPositive_Click(object sender, EventArgs e)
        {
            EPoint p = new(pointSizeBar.Value, 1);
            points.Add(p);
            field.Controls.Add(p);
            p.BringToFront();
        }

        private void AddNegative_Click(object sender, EventArgs e)
        {
            EPoint p = new(pointSizeBar.Value, -1);
            points.Add(p);
            field.Controls.Add(p);
            p.BringToFront();
        }

        private void RemovePoint_Click(object sender, EventArgs e)
        {
            if (EPoint.lastChosen != null)
            {
                field.Controls.Remove(EPoint.lastChosen);
                points.Remove(EPoint.lastChosen);
                EPoint.lastChosen = null;
            }
        }

        private void PointSizeBar_Scroll(object sender, EventArgs e)
        {
            pointSizeBox.Text = pointSizeBar.Value.ToString();
            foreach (var point in points)
            {
                point.PointSize = pointSizeBar.Value;
            }
        }

        private void PointSizeBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                pointSizeBar.Value = int.Parse(pointSizeBox.Text);
                foreach (var point in points)
                {
                    point.PointSize = pointSizeBar.Value;
                }
            }
            catch { }
        }

        private void LinesCountBar_Scroll(object sender, EventArgs e)
        {
            linesCountBox.Text = linesCountBar.Value.ToString();
            linesCount = linesCountBar.Value;
            field.Invalidate();
        }

        private void LinesCountBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                linesCountBar.Value = int.Parse(linesCountBox.Text);
                linesCount = linesCountBar.Value;
                field.Invalidate();
            }
            catch { }
        }

        private void StepLengthBar_Scroll(object sender, EventArgs e)
        {
            stepLengthBox.Text = (stepLengthBar.Value / 10.0).ToString();
            stepLength = stepLengthBar.Value / 10.0;
            field.Invalidate();
        }

        private void StepLengthBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                stepLengthBar.Value = (int)(double.Parse(stepLengthBox.Text) * 10);
                stepLength = stepLengthBar.Value / 10.0;
                field.Invalidate();
            }
            catch { }
        }

        private void DrawingStyle_CheckedChanged(object sender, EventArgs e)
        {
            if (drawingStyleCheck.Checked)
            {
                updateField.Start();
                drawEFieldButton.Enabled = false;
            }
            else
            {
                updateField.Stop();
                drawEFieldButton.Enabled = true;
            }
        }

        private void DrawEFieldButton_Click(object sender, EventArgs e)
        {
            DrawElectricField();
            field.Refresh();
        }

        private void DrawEqPFieldButton_Click(object sender, EventArgs e)
        {
            DrawEquipotentialField();
            field.Refresh();
        }

        private void FieldColsBar_Scroll(object sender, EventArgs e)
        {
            fieldColsBox.Text = fieldColsBar.Value.ToString();
            fieldCols = fieldColsBar.Value;
            field.Invalidate();
        }

        private void FieldColsBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                fieldColsBar.Value = int.Parse(fieldColsBox.Text);
                fieldCols = fieldColsBar.Value;
                field.Invalidate();
            }
            catch { }
        }

        private void FieldRowsBar_Scroll(object sender, EventArgs e)
        {
            fieldRowsBox.Text = fieldRowsBar.Value.ToString();
            fieldRows = fieldRowsBar.Value;
            field.Invalidate();
        }

        private void FieldRowsBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                fieldRowsBar.Value = int.Parse(fieldRowsBox.Text);
                fieldRows = fieldRowsBar.Value;
                field.Invalidate();
            }
            catch { }
        }

        private void DensityBar_Scroll(object sender, EventArgs e)
        {
            densityBox.Text = (densityBar.Value / 10000f).ToString();
            density = densityBar.Value / 10000f;
            field.Invalidate();
        }

        private void DensityBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                densityBar.Value = (int)(float.Parse(densityBox.Text) * 10000);
                density = densityBar.Value / 10000f;
                field.Invalidate();
            }
            catch { }
        }

        private void ClearFieldButton_Click(object sender, EventArgs e)
        {
            EField = new(field.Width, field.Height);
            EqPField = new(field.Width, field.Height);
            field.Refresh();
        }
    }
}
