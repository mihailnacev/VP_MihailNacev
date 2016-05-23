using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_DrawingObjects
{
    [Serializable]
    public class Circle
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Radius { get; set; }
        public Color Color;

        public Circle(float x,float y,float radius,Color color)
        {
            X = x;
            Y = y;
            Radius = radius;
            Color = color;
        }

        public void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color);
            g.FillEllipse(brush, X-Radius, Y-Radius, 2*Radius, 2*Radius);
            brush.Dispose();
        }
    }
}
