using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_LettersMaster
{
    public class LettersDoc
    {
        private int Width;
        private int Height;
        private List<LetterCircle> lista;
        public Random random;
        public int Pogodoci;
        public int Promasuvanja;

        public LettersDoc(int width,int height)
        {
            Width = width;
            Height = height;
            Pogodoci = 0;
            Promasuvanja = 0;
            lista = new List<LetterCircle>();
            random = new Random();
        }

        public void AddLetter()
        {
            int rand_bukva = random.Next(26);
            char bukva = (char)('A' + rand_bukva);
            int PozicijaX = random.Next(30, Width - (2 * 30));
            int PozicijaY = 30;
            lista.Add(new LetterCircle(new Point(PozicijaX, PozicijaY), bukva, Height));
        }

        public void Move()
        {
            foreach(LetterCircle lc in lista)
            {
                lc.Move();
            }
        }

        public void Draw(Graphics g)
        {
            foreach(LetterCircle lc in lista)
            {
                lc.Draw(g);
            }
        }

        public void Hit(char c)
        {
            foreach(LetterCircle lc in lista)
            {
                if (lc.Letter == char.ToUpper(c))
                {
                    lc.IsHit = true;
                    Pogodoci++;
                    break;
                }
            }
        }

        public void Delete()
        {
            for(int i = lista.Count - 1; i >= 0; i--)
            { 
                if (lista[i].Nadvor) { Promasuvanja++; lista.RemoveAt(i); }
                else
                {
                    if (lista[i].IsHit) lista.RemoveAt(i);
                }
            }
        }
    }
}
