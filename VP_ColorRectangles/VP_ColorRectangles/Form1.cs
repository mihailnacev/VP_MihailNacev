using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_ColorRectangles
{
    public partial class Form1 : Form
    {
        public RectanglesDoc doc;
        public Point previosPoint;
        public Point currentPoint;
        public Color currentColor;


        public Form1()
        {
            InitializeComponent();
            doc = new RectanglesDoc();
            previosPoint = Point.Empty;
            currentPoint = Point.Empty;
            currentColor = Color.Green;
            this.DoubleBuffered = true;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (previosPoint.IsEmpty)
                {
                    previosPoint = e.Location;
                }
                else
                {
                    currentPoint = e.Location;
                    doc.AddRectangle(currentPoint, Math.Abs(previosPoint.X - currentPoint.X), Math.Abs(previosPoint.Y - currentPoint.Y), currentColor);
                    previosPoint = Point.Empty;
                    currentPoint = Point.Empty;
                }
                Invalidate();
            }

            if (e.Button == MouseButtons.Right)
            {
                doc.Select(e.Location);
                Invalidate();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            doc.Draw(e.Graphics);
            if (!previosPoint.IsEmpty)
            {
                Pen pen = new Pen(Color.Black, 1);
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                e.Graphics.DrawRectangle(pen, currentPoint.X, currentPoint.Y, Math.Abs(previosPoint.X - currentPoint.X), Math.Abs(previosPoint.Y - currentPoint.Y));
                pen.Dispose();
            }
            toolStripStatusLabel1.Text = string.Format("Rectangles: {0}", doc.Rectangles.Count);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            currentPoint = e.Location;
            Invalidate();
        }
    }
}
