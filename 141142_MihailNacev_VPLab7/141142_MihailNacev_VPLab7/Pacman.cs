using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _141142_MihailNacev_VPLab7
{
    public class Pacman
    {
        public enum DIRECTION
        {
            UP,
            DOWN,
            LEFT,
            RIGHT
        }
        public Point position;
        public DIRECTION direction;
        public static readonly int RADIUS = 20;
        public decimal speed { get; set; }
        public bool Open { get; set; }
        public Brush brush;

        public Pacman()
        {
            brush = new SolidBrush(Color.Yellow);
            speed = RADIUS;
            direction = DIRECTION.RIGHT;
            position.X = 7;
            position.Y = 5;
            Open = true;
        }

        public void ChangeDirection(DIRECTION direction)
        {
            // vasiot kod ovde
            this.direction = direction;
        }

        public void Move(int width,int height)
        {
            if (direction == DIRECTION.LEFT)
            {
                if (position.X == 0) position.X = (width - 1);
                else position.X -= 1;
            }

            if (direction == DIRECTION.RIGHT)
            {
                if (position.X == (width - 1)) position.X = 0;
                else position.X += 1;
            }

            if (direction == DIRECTION.UP)
            {
                if (position.Y == 0) position.X = (height - 1);
                else position.Y -= 1;
            }

            if (direction == DIRECTION.DOWN)
            {
                if (position.Y == (height-1)) position.Y = (height - 1);
                else position.Y += 1;
            }

            Open = !Open;
        }

        public void Draw(Graphics g)
        {
            if (direction == DIRECTION.RIGHT)
            {
                g.FillPie(brush, position.X * RADIUS * 2, position.Y * RADIUS * 2, RADIUS * 2, RADIUS * 2, 45, 270);
            }

            if (direction == DIRECTION.LEFT)
            {
                g.FillPie(brush, position.X * RADIUS * 2, position.Y * RADIUS * 2, RADIUS * 2, RADIUS * 2, 225, 270);
            }

            if (direction == DIRECTION.UP)
            {
                g.FillPie(brush, position.X * RADIUS * 2, position.Y * RADIUS * 2, RADIUS * 2, RADIUS * 2, 315, 270);
            }

            if (direction == DIRECTION.DOWN)
            {
                g.FillPie(brush, position.X * RADIUS * 2, position.Y * RADIUS * 2, RADIUS * 2, RADIUS * 2, 135, 270);
            }

            if (Open == false)
            {
                g.FillEllipse(brush, position.X * RADIUS * 2, position.Y * RADIUS * 2, RADIUS * 2, RADIUS * 2);
            }
        }
    }
}
