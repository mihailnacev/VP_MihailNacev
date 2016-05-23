using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_SlidingBalls
{
    public class BallsDoc
    {
        private List<Ball> lista;
        public Random rand;

        public BallsDoc()
        {
            lista = new List<Ball>();
            rand = new Random();
        }

        public void AddBall(Point position)
        {
            int broj = rand.Next(2);
            Ball b;
            if (broj == 0)
            {
                b = new Ball(position, Color.Green,rand);
            }
            else
            {
                b = new Ball(position, Color.Blue,rand);
            }
            lista.Add(b);
        }

        public void AddRedBall(Point position)
        {
            Ball b = new Ball(position, Color.Red,rand);
            lista.Add(b);
        }

        public void Draw(Graphics g)
        {
            foreach(Ball ball in lista)
            {
                ball.Draw(g);
            }
        }

        public void Click(Point p)
        {
            foreach (Ball b in lista)
            {
                b.Click(p);
            }
        }
        public void Move()
        {
            foreach(Ball b in lista)
            {
                if (b.Color == Color.Red && b.IsClicked) { b.generiranjeNasoka(); }
            }
        }
    }
}
