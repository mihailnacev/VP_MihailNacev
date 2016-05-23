using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_TryRectangles
{
    public partial class Form1 : Form
    {
        RectanglesDoc doc;
        public Form1()
        {
            InitializeComponent();
            doc = new RectanglesDoc();
            this.DoubleBuffered = true;
            timer1.Start();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                doc.AddRectangle(e.Location);
            }

            if (e.Button == MouseButtons.Right)
            {
                doc.Select(e.Location);
            }

            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            doc.DrawRectangles(g);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            doc.Blow();
            doc.checkExplosions();
            Invalidate();
        }
    }
}
