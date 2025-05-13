

namespace QuadrupoleElectricField
{
    public partial class Main : Form
    {
        List<Point> points = [];
        int pointSize = 50;

        public Main()
        {
            InitializeComponent();

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        private void DrawFieldLines(Graphics g)
        {
            Pen pen = new Pen(Color.Blue);
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

        private void AddPoint_Click(object sender, EventArgs e)
        {
            Point p = new(pointSize);
            points.Add(p);
            field.Controls.Add(p);
        }

        private void RemovePoint_Click(object sender, EventArgs e)
        {
            if (Point.lastChosen != null)
            {
                field.Controls.Remove(Point.lastChosen);
                points.Remove(Point.lastChosen);
                Point.lastChosen = null;
            }
        }
    }
}
