using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_LettersMaster
{
    public partial class Form1 : Form
    {
        LettersDoc doc;
        public Form1()
        {
            InitializeComponent();
            doc = new LettersDoc(Width, Height);
            this.DoubleBuffered = true;
            timerGeneriranje.Start();
            timerDvizenje.Start();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            toolStripStatusLabel1.Text = string.Format("Hits: {0}, Misses: {1}", doc.Pogodoci, doc.Promasuvanja);
            doc.Draw(g);
        }

        private void timerGeneriranje_Tick(object sender, EventArgs e)
        {
            doc.AddLetter();
            Invalidate();
        }

        private void timerDvizenje_Tick(object sender, EventArgs e)
        {
            doc.Move();
            doc.Delete();
            Invalidate();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            doc.Hit(e.KeyChar);
            Invalidate();
        }
    }
}
