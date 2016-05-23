using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_SlidingBalls
{
    public class Ball
    {
        public Point Center;
        public Color Color;
        public static readonly int RADIUS = 30;
        public DIRECTION direction;
        public Random random;
        public bool IsClicked { get; set; }
        public enum DIRECTION
        {
            LEFT,
            RIGHT,
            UP,
            DOWN
        }

        public Ball(Point center,Color color,Random r)
        {
            Center = center;
            Color = color;
            random = r;
            IsClicked = false;
            int broj = random.Next(4);
            if (broj == 0) direction = DIRECTION.LEFT;
            else if (broj == 1) direction = DIRECTION.RIGHT;
            else if (broj == 2) direction = DIRECTION.UP;
            else direction = DIRECTION.DOWN;
        }

        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color);
            g.FillEllipse(b, Center.X-RADIUS, Center.Y-RADIUS, 2 * RADIUS, 2 * RADIUS);
            b.Dispose();
        }

        public void generiranjeNasoka()
        {
            if (direction==DIRECTION.LEFT) moveLeft();
            else if (direction==DIRECTION.RIGHT) moveRight();
            else if (direction==DIRECTION.UP) moveUp();
            else moveDown();
        } 
        public void moveLeft()
        {
            Center = new Point(Center.X - 10, Center.Y);
        }

        public void moveRight()
        {
            Center = new Point(Center.X + 10, Center.Y);
        }

        public void moveUp()
        {
            Center = new Point(Center.X, Center.Y - 10);
        }

        public void moveDown()
        {
            Center = new Point(Center.X, Center.Y + 10);
        }

        public void Click(Point p)
        {
            if (Math.Abs(p.X - Center.X)<=RADIUS&&Math.Abs(p.Y-Center.Y)<=RADIUS) IsClicked = true;
        }
    }
}
