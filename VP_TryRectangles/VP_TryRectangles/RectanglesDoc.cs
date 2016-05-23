using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_TryRectangles
{
    public class RectanglesDoc
    {
        List<Rectangle> lista;
        public RectanglesDoc()
        {
            lista = new List<Rectangle>();
        }

        public void AddRectangle(Point point)
        {
            Rectangle r = new Rectangle(point);
            lista.Add(r);
        }

        public void DrawRectangles(Graphics g)
        {
            foreach(Rectangle r in lista)
            {
                r.Draw(g);
            }
        }

        public void Select(Point p)
        {
            foreach(Rectangle r in lista)
            {
                r.Select(p);
            }
        }

        public void Blow()
        {
            foreach(Rectangle r in lista)
            {
                r.Blow();
            }
        }

        public void checkExplosions()
        {
            for(int i = 0; i < lista.Count; i++)
            {
                for(int j = i + 1; j < lista.Count; j++)
                {
                    if (lista[i].isTouching(lista[j]))
                    {
                        lista[i].IsTouching = true;
                        lista[j].IsTouching = true;
                    }
                }
            }

            for(int i = lista.Count - 1; i >= 0; i--)
            {
                if (lista[i].IsTouching)
                {
                    lista.RemoveAt(i);
                }
            }
        }
    }
}
