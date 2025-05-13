using QuadrupoleElectricField.Properties;
using System;

namespace QuadrupoleElectricField
{
    internal class Point : PictureBox
    {
        internal static Point? lastChosen;
        bool drag;

        public Point(int size) {
            Image = Resources.Point;
            SizeMode = PictureBoxSizeMode.Zoom;
            Width = size;
            MouseDown += OnMouseDown;
            MouseUp += OnMouseUp;
            MouseMove += OnMouseMove;
        }

        private static Size mouseOffset;

        void OnMouseDown(object? sender, MouseEventArgs e)
        {
            mouseOffset = new Size(e.Location);
            drag = true;
        }
        void OnMouseUp(object? sender, MouseEventArgs e)
        {
            drag = false;
            lastChosen = this;
        }
        void OnMouseMove(object? sender, MouseEventArgs e)
        {
            if (drag == true)
            {
                System.Drawing.Point newLocationOffset = e.Location - mouseOffset;
                Left += newLocationOffset.X;
                Top += newLocationOffset.Y;
            }
        }
    }
}
