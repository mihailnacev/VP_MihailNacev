using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_BlowingBalloons
{
    [Serializable]
    public class Balloon
    {
        public Point Position { get; set; }
        public int Radius { get; set; }
        public Color Color { get; set; }
        public PULSEDIRECTION Pulsestate { get; set; }
        public MOVEDIRECTION Movestate { get; set; }
        public bool IsHit { get; set; }
        public enum PULSEDIRECTION
        {
           INSIDE,
           OUTSIDE
        }

        public enum MOVEDIRECTION
        {
            UP,
            DOWN
        }

        public Balloon(Point position,int radius)
        {
            Position = position;
            Radius = radius;
            Random r = new Random();
            Color = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
            Pulsestate = PULSEDIRECTION.OUTSIDE;
            Movestate = MOVEDIRECTION.DOWN;
        }

        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color);
            Pen p = new Pen(Color.Black,3);
            g.FillEllipse(b, Position.X - Radius, Position.Y - Radius, 2 * Radius, 2 * Radius);
            if(IsHit) g.DrawEllipse(p, Position.X - Radius, Position.Y - Radius, 2 * Radius, 2 * Radius);
            b.Dispose();
            p.Dispose();
            
        }

        public void Pulse()
        {
            if (Pulsestate == PULSEDIRECTION.OUTSIDE)
            {
                if (Radius < 80) Radius += 5;
                else
                {
                    Pulsestate = PULSEDIRECTION.INSIDE;
                }
            }
            
            if (Pulsestate == PULSEDIRECTION.INSIDE)
            {
                if (Radius > 20) Radius -= 5;
                else
                {
                    Pulsestate = PULSEDIRECTION.OUTSIDE;
                }
            }
        }

        public void MOVEUP()
        {
            Point p = new Point(Position.X,Position.Y-10);
            Position = p;
        }

        public void MOVEDown()
        {
            Point p = new Point(Position.X, Position.Y +10);
            Position = p;
        }

        public void Pogodeno(Point p)
        {
            if(Math.Abs(p.X - Position.X) <= Radius && Math.Abs(p.Y - Position.Y) <= Radius)
            {
                IsHit = true;
            }
        }


    }
}
