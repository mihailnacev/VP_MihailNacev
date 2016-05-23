using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _141142_MihailNacev_VPLab7
{
    public partial class Form1 : Form
    {
        private Timer timer;
        private Pacman pacman;
        private static readonly int TIMER_INTERVAL = 250;
        private static readonly int WORLD_WIDTH = 15;
        private static readonly int WORLD_HEIGHT = 10;
        private int eaten = 0;
        private Image foodImage;
        private bool[][] foodWorld;
         
        public Form1()
        {
            InitializeComponent();
            foodImage = Properties.Resources.FoodOrange;
            DoubleBuffered = true;
            newGame();
        }

        private void newGame()
        {
            pacman = new Pacman();
            this.Width = Pacman.RADIUS * 2 * (WORLD_WIDTH + 1);
            this.Height = Pacman.RADIUS * 2 * (WORLD_HEIGHT + 1);
            foodWorld = new bool[WORLD_HEIGHT][];
            for (int i = 0; i < WORLD_HEIGHT; i++)
            {
                foodWorld[i] = new bool[WORLD_WIDTH];
                for (int j = 0; j < WORLD_WIDTH; j++)
                {
                    foodWorld[i][j] = true;
                }
            }
            timer = new Timer();
            timer.Interval = TIMER_INTERVAL;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (eaten == 150)
            {
                endGame();
                return;
            }
            pacman.Move(WORLD_WIDTH, WORLD_HEIGHT);
            if (foodWorld[pacman.position.Y][pacman.position.X]) eaten++;
            foodWorld[pacman.position.Y][pacman.position.X] = false;
            Invalidate();
        }

        private void endGame()
        {
            timer.Stop();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                pacman.ChangeDirection(Pacman.DIRECTION.LEFT);
            }
            else if (e.KeyCode == Keys.Right)
            {
                pacman.ChangeDirection(Pacman.DIRECTION.RIGHT);
            }
            else if (e.KeyCode == Keys.Up)
            {
                pacman.ChangeDirection(Pacman.DIRECTION.UP);
            }
            else if (e.KeyCode == Keys.Down)
            {
                pacman.ChangeDirection(Pacman.DIRECTION.DOWN);
            }
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            for (int i = 0; i < foodWorld.Length; i++)
            {
                for (int j = 0; j < foodWorld[i].Length; j++)
                {
                    if (foodWorld[i][j])
                    {
                        g.DrawImageUnscaled(foodImage, j * Pacman.RADIUS * 2 + (Pacman.RADIUS * 2 - foodImage.Height) / 2, i * Pacman.RADIUS * 2 + (Pacman.RADIUS * 2 - foodImage.Width) / 2);
                    }
                }
            }
            pacman.Draw(g);
        }
    }
}
