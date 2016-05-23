using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_BlowingBalloons
{
    public partial class Form1 : Form
    {
        private BalloonsDoc doc;
        private string FileName;
        public Form1()
        {
            InitializeComponent();
            doc = new BalloonsDoc(Width,Height);
            this.DoubleBuffered = true;
            timer1.Start();
            FileName = null;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                doc.AddBalloonClick(new Point(e.X, e.Y));
            }

            if (e.Button == MouseButtons.Right)
            {
                doc.Pogodeno(e.Location);
            }

            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabel1.Text = string.Format("Вкупно балони: {0}", doc.lista.Count);
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            doc.DrawBalloons(g);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //doc.AddBalloonRandom();
            doc.BalloonsPulse();
            doc.Delete();
            Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                doc.BallonsMove();
            }

            if (e.KeyCode == Keys.Delete)
            {
                doc.Delete();
            }
        }

        private void toolStripStatusLabel1_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabel1.Text = string.Format("Вкупно балони: {0}",doc.lista.Count);
            Invalidate();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (FileName == null)
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Ballons file (*.balloons)|*.balloons";
                saveFileDialog1.Title = "Save a Balloons file";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    FileName = saveFileDialog1.FileName;
                }
            }
            if (FileName != null)
            {
                IFormatter fmt = new BinaryFormatter();
                FileStream strm = new FileStream(FileName, FileMode.Create, FileAccess.Write, FileShare.None);
                fmt.Serialize(strm, doc);
                strm.Close();
            }
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Ballons file (*.balloons)|*.balloons";
            openFileDialog1.Title = "Open a Balloons file";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog1.FileName;
                IFormatter fmt = new BinaryFormatter();
                FileStream strm = new FileStream(FileName, FileMode.Open, FileAccess.Read, FileShare.None);
                doc = (BalloonsDoc)fmt.Deserialize(strm);
                strm.Close();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileName = null;
            saveToolStripButton_Click(sender, e);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveToolStripButton_Click(sender, e);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openToolStripButton_Click(sender, e);
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            doc = new BalloonsDoc(Width,Height);
            Invalidate();
        }
    }
}
