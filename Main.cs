

namespace QuadrupoleElectricField
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (startDistance > 0 && step > 0)
            {
                DrawFieldLines(e.Graphics);
            }
        }

        private void DrawFieldLines(Graphics g)
        {
            Pen pen = new Pen(Color.Blue);

            for (double x = startDistance; x <= ClientSize.Width; x += step)
            {
                for (double y = startDistance; y <= ClientSize.Height; y += step)
                {
                    double fieldStrength = CalculateFieldStrength(x, y);

                    DrawLine(g, x, y, fieldStrength);
                }
            }
        }

        private double CalculateFieldStrength(double x, double y)
        {
            double q1 = 1; // Значение первого заряда
            double q2 = -1; // Значение второго заряда

            return (q1 / Math.Pow(x + 10, 2)) - (q2 / Math.Pow(x - 10, 2)); // Упрощенная модель
        }

        private static void DrawLine(Graphics g, double x, double y, double fieldStrength)
        {
            float lengthFactor = 10f; // Фактор длины линии

            float endX = (float)(x + fieldStrength * lengthFactor);
            float endY = (float)(y + fieldStrength * lengthFactor);

            g.DrawLine(Pens.Blue, (float)x, (float)y, endX, endY);
        }
    }
}
