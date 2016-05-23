using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_SlidingBalls
{
    public partial class Form1 : Form
    {
        public BallsDoc doc;
        public Form1()
        {
            InitializeComponent();
            doc = new BallsDoc();
            this.DoubleBuffered = true;
            timer1.Start();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            doc.Draw(g);
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                doc.AddBall(e.Location);
            }
            Invalidate();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                doc.Click(e.Location);
            }
            if (e.Button == MouseButtons.Right)
            {
                doc.AddRedBall(e.Location);
            }
            Invalidate();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            doc.Move();
            Invalidate();
        }
    }
}
