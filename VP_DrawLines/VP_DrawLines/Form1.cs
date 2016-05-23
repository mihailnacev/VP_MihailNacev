using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_DrawLines
{
    public partial class Form1 : Form
    {
        private Point previousPoint;
        private Point currentPoint;

        private Pen dashedPen;
        private Pen solidPen;

        private LinesDoc linesDoc;
        private int width;
        private bool hasPositioner;
        private Color CurrentColor;

        private static readonly int THIN_LINE = 1;
        private static readonly int MEDIUM_LINE = 2;
        private static readonly int THIC_LINE = 3;

        public Form1()
        {
            InitializeComponent();
            dashedPen = new Pen(Color.Black, 1);
            dashedPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            solidPen = new Pen(Color.Black, 3);
            DoubleBuffered = true;
            linesDoc = new LinesDoc();
            width = 3;
            hasPositioner = true;
            CurrentColor = Color.Black;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (previousPoint.IsEmpty)
                {
                    previousPoint = new Point(e.X, e.Y);
                }
                else
                {
                    currentPoint = new Point(e.X, e.Y);
                    linesDoc.AddLine(previousPoint, currentPoint, width,CurrentColor);
                    previousPoint = new Point(e.X, e.Y);
                    Invalidate(true);
                }
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            if (hasPositioner)
            {
                e.Graphics.DrawLine(dashedPen,currentPoint.X,0,currentPoint.X,Height);
                e.Graphics.DrawLine(dashedPen, 0, currentPoint.Y, Width, currentPoint.Y);
            }
            linesDoc.DrawLines(e.Graphics);
        }

        private void positionerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            positionerToolStripMenuItem.Checked = !positionerToolStripMenuItem.Checked;
            hasPositioner = !hasPositioner;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            currentPoint = new Point(e.X, e.Y);
            Invalidate(true);
        }

        private void thinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            width = THIN_LINE;
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            width = MEDIUM_LINE;
        }

        private void thickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            width = THIC_LINE;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                CurrentColor = colorDialog.Color;
            }
        }
    }
}
