using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace _141142_MihailNacev
{
    public partial class Form1 : Form
    {
        public BallsDoc doc;
        int brojac;
        string FileName;
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            doc = new BallsDoc(Width, Height);
            brojac = 0;
            timerGeneriranje.Start();
            timerDvizenje.Start();
        }

        private void timerGeneriranje_Tick(object sender, EventArgs e)
        {
            doc.AddBall(brojac);
            brojac++;
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g=e.Graphics;
            g.Clear(Color.White);
            toolStripStatusLabel1.Text = string.Format("Total: {0}, Colisions: {1}", doc.lista.Count,doc.brKolizii);
            doc.Draw(g);
        }

        private void timerDvizenje_Tick(object sender, EventArgs e)
        {
            doc.Move();
            doc.CheckExplosions();
            doc.Delete();
            Invalidate();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (FileName == null) {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Balls doc (*.balls)|*.balls";
                saveFileDialog1.Title = "Save a Balls FIle";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    FileName = saveFileDialog1.FileName;
                }
            }

            if (FileName != null) {
                IFormatter fmt = new BinaryFormatter();
                FileStream strm = new FileStream(FileName, FileMode.Create, FileAccess.Write, FileShare.None);
                fmt.Serialize(strm, doc);
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

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            doc = new BallsDoc(Width, Height);
            Invalidate();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newToolStripButton_Click(sender, e);
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Balls doc (*.balls)|*.balls";
            openFileDialog1.Title = "Open a Balls FIle";
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                FileName = openFileDialog1.FileName;
            }
            IFormatter fmt = new BinaryFormatter();
            FileStream strm= null;
            try
            {
                strm = new FileStream(FileName, FileMode.Open, FileAccess.Read, FileShare.None);
                doc = (BallsDoc)fmt.Deserialize(strm);
            }
            catch (Exception) { }
            finally { strm.Close(); Invalidate(); }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openToolStripButton_Click(sender, e);
        }
    }
}
