using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_TryRectangles
{
    public class Rectangle
    {
        public Point Center;
        public static int Width = 60;
        public static int Height = 50;
        public bool IsSelected;
        public bool IsTouching;

        public Rectangle(Point center)
        {
            Center = center;
            IsSelected = false;
        }

        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color.Green);
            g.FillRectangle(b,Center.X-Width/2,Center.Y-Height/2,Width,Height);
            Pen pen = new Pen(Color.OrangeRed, 3);
            if (IsSelected) g.DrawRectangle(pen,Center.X-Width/2,Center.Y-Height/2,Width,Height);
            pen.Dispose();
            b.Dispose();
        }

        public void Select(Point p)
        {
            if (Math.Abs(Center.X - p.X) <= Width/2 && Math.Abs(Center.Y - p.Y) <= Height/2)
                IsSelected = true;
        }

        public void Blow()
        {
            Rectangle.Width += 5;
            Rectangle.Height += 5;
        }

        public bool isTouching(Rectangle r)
        {
            float distance = (Center.X - r.Center.X) * (Center.X - r.Center.X) + (Center.Y - r.Center.Y) * (Center.Y - r.Center.Y);
            return distance <= Width * Height;
        }
    }
}
