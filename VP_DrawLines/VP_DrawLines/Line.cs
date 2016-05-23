using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace VP_DrawLines
{
    public class Line
    {
        public Point Start { get; set; }
        public Point End { get; set; }
        public int Width { get; set; }
        public Color Color { get; set; }

        public Line(Point start,Point end,int width,Color color)
        {
            Start = start;
            End = end;
            Width = width;
            Color = color;
        }

        public void Draw(Graphics g)
        {
            Pen pen = new Pen(Color, Width);
            g.DrawLine(pen, Start, End);
            pen.Dispose();
        }
    }
}
