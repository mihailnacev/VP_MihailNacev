using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_ColorRectangles
{
    public class Rectangle
    {
        public Point Point { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public Color Color { get; set; }
        public bool IsSelected { get; set; }

        public Rectangle(Point point,int width,int height,Color color)
        {
            Point = point;
            Height = height;
            Width = width;
            Color = color;
            IsSelected = false;
        }

        public void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color);
            if (IsSelected)
            {
                Pen pen = new Pen(Brushes.Red, 2);
                g.DrawRectangle(pen, Point.X, Point.Y, Width, Height);
                pen.Dispose();
            }
            g.FillRectangle(brush, Point.X, Point.Y, Width, Height);
            brush.Dispose();
            
        }

        public void Select(Point point)
        {
            if (point.X >= Point.X && point.X <= Point.X + Width && point.Y >= Point.Y && point.Y <= Point.Y + Height)
            {
                IsSelected = !IsSelected;
            }
        }
    }
}
