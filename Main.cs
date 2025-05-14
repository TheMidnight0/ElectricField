namespace ElectricField
{
    public partial class Main : Form
    {
        readonly List<EPoint> points = [];
        int linesCount = 12;
        double stepLength = 5;
        int drawEField = 1;
        Bitmap drawning;

        public Main()
        {
            InitializeComponent();
            drawning = new(field.Width, field.Height);
            SetStyle(ControlStyles.AllPaintingInWmPaint |
              ControlStyles.UserPaint |
              ControlStyles.DoubleBuffer, true);
            field.Paint += Field_Paint;
        }

        private void Field_Paint(object? sender, PaintEventArgs e)
        {
            if (drawEField == 1)
            {
                DrawElectricField();
                e.Graphics.DrawImage(drawning, Point.Empty);
                drawEField = 0;
            }
            else if (drawEField == 0)
            {
                if (drawingStyle.Checked)
                {
                    drawEField = 1;
                }
                else
                {
                    drawEField = -1;
                }
                field.Invalidate();
            }
        }

        private void DrawElectricField()
        {
            drawning = new Bitmap(field.Width, field.Height);
            Graphics g = Graphics.FromImage(drawning);
            int lineLength = 1100;
            int steps = (int)(lineLength / stepLength);
            const double k = 9e9;

            foreach (var charge in points)
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

        private void AddPositive_Click(object sender, EventArgs e)
        {
            EPoint p = new(pointSizeBar.Value, 1);
            points.Add(p);
            field.Controls.Add(p);
            p.BringToFront();
            field.Invalidate();
        }

        private void AddNegative_Click(object sender, EventArgs e)
        {
            EPoint p = new(pointSizeBar.Value, -1);
            points.Add(p);
            field.Controls.Add(p);
            p.BringToFront();
            field.Invalidate();
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

        private void DrawButton_Click(object sender, EventArgs e)
        {
            drawEField = 1;
            field.Invalidate();
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
            if (drawingStyle.Checked)
            {
                drawButton.Enabled = false;
                drawEField = 1;
                field.Invalidate();
            }
            else
            {
                drawButton.Enabled = true;
            }
        }
    }
}
