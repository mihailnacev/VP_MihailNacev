using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_DrawingObjects
{
    [Serializable]
    public class ShapesList
    {
        public List<Object> Shapes;
        public const float Radius = 40;
        public enum SHAPE_TYPE
        {
            CIRCLE,
            SQUARE
        }

        public ShapesList()
        {
            Shapes = new List<Object>();
        }

        public void AddShape(float x,float y,Color color,SHAPE_TYPE type)
        {
            if (type == SHAPE_TYPE.CIRCLE)
            {
                Circle circle = new Circle(x, y, Radius, color);
                Shapes.Add(circle);
            }
            if (type == SHAPE_TYPE.SQUARE)
            {
                Square square = new Square(x, y, Radius, Radius, color);
                Shapes.Add(square);
            }
        }

        public void Draw(Graphics g)
        {
            
            foreach(object ob in Shapes)
            {
                Circle c = ob as Circle;
                if (c != null) c.Draw(g);
                else
                {
                    Square s = ob as Square;
                    s.Draw(g);
                }
            }
        }

    }
}
