using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_BlowingBalloons
{
    [Serializable]
    public class BalloonsDoc
    {
        public List<Balloon> lista;
        private int Width;
        private int Height;
        private Random r;

        public BalloonsDoc(int width,int height)
        {
            lista = new List<Balloon>();
            r = new Random();
            Width = width;
            Height = height;
        }

        public void AddBalloonRandom()
        {
            Balloon balloon = new Balloon(new Point(r.Next(Width), r.Next(Height)), r.Next(20, 30));
            lista.Add(balloon);
        }

        public void AddBalloonClick(Point p)
        {
            Balloon balloon = new Balloon(p, r.Next(20, 30));
            lista.Add(balloon);
        }

        public void DrawBalloons(Graphics g)
        {
            foreach(Balloon b in lista)
            {
                b.Draw(g);
            }
        }

        public void BalloonsPulse()
        {
            foreach(Balloon b in lista)
            {
                b.Pulse();
            }
        }

        public void BallonsMove()
        {
            foreach (Balloon b in lista)
            {
                b.MOVEDown();
            }
        }

        public void Pogodeno(Point p)
        {
            foreach(Balloon b in lista)
            {
                b.Pogodeno(p);
            }
        }

        public void Delete()
        {
            for(int i = lista.Count - 1; i >= 0; i--)
            {
                if (lista[i].IsHit) lista.RemoveAt(i);
            }
        }

        public void CheckForExplosions()
        {
            for (int i = 0; i < lista.Count; i++)
            {
                for (int j = i + 1; j < lista.Count; j++)
                {
                    lista[i].Pogodeno(lista[j].Position);
                    lista[j].Pogodeno(lista[i].Position);
                }
            }

        }
    }
}
