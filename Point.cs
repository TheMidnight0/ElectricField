using ElectricField.Properties;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace ElectricField
{
    internal class EPoint : PictureBox
    {
        internal static EPoint? lastChosen;
        internal int pointSize;
        bool drag;

        internal Point Center
        {
            get => new(Left + Width / 2, Top + Height / 2);
        }

        internal int PointSize
        {
            get => pointSize;
            set
            {
                pointSize = value;
                Left = Center.X - value / 2; Top = Center.Y - value / 2;
                Width = value; Height = value;
                GraphicsPath path = new();
                path.AddEllipse(0, 0, Width, Height);
                Region = new(path);
            }
        }

        public EPoint(int size)
        {
            PointSize = size;
            Left = 0; Top = 0;
            Image = Resources.Point;
            SizeMode = PictureBoxSizeMode.Zoom;
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
            if (drag == true && Parent != null)
            {
                Point newLocationOffset = e.Location - mouseOffset;
                Left = (Left + newLocationOffset.X < 0 ? 0 : Left + newLocationOffset.X > Parent.Width - Width ? Parent.Width - Width : Left + newLocationOffset.X);
                Top = (Top + newLocationOffset.Y < 0 ? 0 : Top + newLocationOffset.Y > Parent.Height - Height ? Parent.Height - Height : Top + newLocationOffset.Y);
            }
        }
    }
}
