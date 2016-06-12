using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace _141142_MihailNacev
{
    [Serializable]
    public class Ball
    {
        public Point Center;
        public int Radius;
        public Color Color { get; set; }
        public int color;
        public Random Random;
        public int Width;
        public int Height;
        public bool IsTouching;
        public bool Nadvor;
        int Nasoka;

        public Ball(Point center, Random rand, int width, int height,int radius,int brojac) {
            IsTouching = false;
            Nadvor = false;
            Center = center;
            Random = rand;
            color = Random.Next(3);
            if (color == 0) {
                Color = Color.Blue;
            }
            else if (color == 1)
            {
                Color = Color.Red;

            }
            else {

                Color = Color.Green;            
            }
            Width = width;
            Height = height;
            Radius = radius;
            Nasoka = brojac;
        }

        public void Draw(Graphics g) {
            Brush b = new SolidBrush(Color);
            g.FillEllipse(b,Center.X-Radius,Center.Y-Radius,2*Radius,2*Radius);
            b.Dispose();
        }

        public void Move() {
            if (Nasoka % 2 == 0)
            {
                moveRight();
            }
            else {
                moveLeft();
            }
        }

        public void moveLeft() {
            Center = new Point(Center.X - 5, Center.Y);
            if (Center.X >= Width + Radius || Center.X <= 0) Nadvor = true;
        }

        public void moveRight()
        {
            Center = new Point(Center.X + 5, Center.Y);
            if (Center.X >= Width + Radius || Center.X <= 0) Nadvor = true;
        }

        public bool isTouching(Ball ball) {
            float distance = (Center.X - ball.Center.X) * (Center.X - ball.Center.X) + (Center.Y - ball.Center.Y) * (Center.Y - ball.Center.Y);
            return distance <= ((Radius + ball.Radius) * (Radius + ball.Radius));
        }


    }
}
