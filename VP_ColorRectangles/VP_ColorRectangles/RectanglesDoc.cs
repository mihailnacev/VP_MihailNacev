using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_ColorRectangles
{
    public class RectanglesDoc
    {
        public List<Rectangle> Rectangles;

        public RectanglesDoc()
        {
            Rectangles = new List<Rectangle>();
        }

        public void AddRectangle(Point point,int width,int height,Color color)
        {
            Rectangles.Add(new Rectangle(point, width, height, color));
        }

        public void Draw(Graphics g)
        {
            foreach(Rectangle r in Rectangles)
            {
                r.Draw(g);
            }
        }

        public void Select(Point p)
        {
            foreach(Rectangle r in Rectangles)
            {
                r.Select(p);
            }
        }
    }
}
