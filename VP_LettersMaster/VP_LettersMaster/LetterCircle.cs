using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_LettersMaster
{
    public class LetterCircle
    {
        public Point Center { get; set; }
        public char Letter { get; set; }
        public static readonly int RADIUS=30;
        public int Height { get; set; }
        public bool IsHit
        {
            get;
            set;
        }

        public bool Nadvor { get; set; }

        public LetterCircle(Point center,char letter,int height)
        {
            Center = center;
            Letter = letter;
            Height = height;
            IsHit = false;
            Nadvor = false;
        }

        public void Draw(Graphics g)
        {
            if (IsHit)
            {
                g.FillEllipse(Brushes.Red, Center.X - RADIUS, Center.Y - RADIUS, RADIUS * 2, RADIUS * 2);
            }
            else
            {
                g.FillEllipse(Brushes.LightGreen, Center.X - RADIUS, Center.Y - RADIUS, RADIUS * 2, RADIUS * 2);
            }

            Font f = new Font("Arial", 24);
            g.DrawString(string.Format("{0}", Letter), f, Brushes.Black, Center.X - 15, Center.Y - 15);
            f.Dispose();
        }

        public void Move()
        {
            Center = new Point(Center.X,Center.Y+10);
            if (Center.Y >= Height + RADIUS) Nadvor = true;
        }

    }
}
