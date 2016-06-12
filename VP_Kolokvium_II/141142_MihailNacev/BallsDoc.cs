using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace _141142_MihailNacev
{
    [Serializable]
    public class BallsDoc
    {
        public int Width;
        public int Height;
        public List<Ball> lista;
        public Random r;
        public int brKolizii;

        public BallsDoc(int width, int height) {
            Width = width;
            Height = height;
            brKolizii = 0;
            lista = new List<Ball>();
            r = new Random();
        }

        public void AddBall(int brojac) {
            int Radius=r.Next(20,50);
            int korX = 0;
            int korY = 0;
            if (brojac % 2 == 0)
            {
                korX = Radius;
                korY = r.Next(25 + Radius, Height-Radius);
            }
            else { 
               
                korX=Width-Radius;
                korY = r.Next(25 + Radius,Height-Radius);
            }
            Ball ball = new Ball(new Point(korX,korY),r,Width,Height,Radius,brojac);
            lista.Add(ball);
        }

        public void Draw(Graphics g) {
            foreach (Ball b in lista) {
                b.Draw(g);
            }
        }

        public void Move() {
            foreach (Ball b in lista)
            {
                b.Move();
            }
        }

        public void CheckExplosions() {
            List<Ball> temp = new List<Ball>();
            for (int i = 0; i < lista.Count; i++) {
                for (int j = 0; j < lista.Count; j++) {
                    if (lista[i].isTouching(lista[j])&&lista[i].Color!=lista[j].Color)
                    {
                        lista[i].IsTouching = true;
                        lista[j].IsTouching = true;
                        brKolizii ++;

                    }

                  /*  if (lista[i].isTouching(lista[j]) && lista[i].Color == lista[j].Color)
                    {
                        lista[i].IsTouching = true;
                        lista[j].IsTouching = true;
                        brKolizii ++;
                        int novRadius = lista[i].Radius + lista[j].Radius;
                        int novaX = (lista[i].Center.X + lista[j].Center.X)/2;
                        int novaY = (lista[i].Center.Y + lista[j].Center.Y) / 2;
                        Ball b=new Ball(new Point(novaX,novaY),r,Width,Height,novRadius,0);
                        temp.Add(b);

                    }*/
                }
            }

            for (int i = lista.Count - 1; i >= 0;i--) {
                if (lista[i].IsTouching) {
                    lista.RemoveAt(i);
                }
            
            }
           /* foreach (Ball b in temp) {
                       lista.Add(b);
                   }*/

        }

        public void Delete() {
            for (int i = lista.Count - 1; i >= 0; i--)
            {
                if (lista[i].Nadvor)
                {
                    lista.RemoveAt(i);
                }

            }
        }


    }
}
