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

namespace VP_DrawingObjects
{
    public partial class Form1 : Form
    {
        private ShapesList shapesList;
        private Color currentColor;
        private SHAPE_TYPE currentType;
        private string FileName;

        private enum SHAPE_TYPE
        {
            CIRCLE,
            SQUARE
        }

        public Form1()
        {
            InitializeComponent();
            shapesList = new ShapesList();
            currentColor = Color.Green;
            currentType = SHAPE_TYPE.CIRCLE;
            circleToolStripMenuItem.Checked = true;
            this.DoubleBuffered = true;
            FileName = null;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (currentType == SHAPE_TYPE.CIRCLE)
                {
                    shapesList.AddShape(e.X, e.Y, currentColor, ShapesList.SHAPE_TYPE.CIRCLE);
                }

                if (currentType == SHAPE_TYPE.SQUARE)
                {
                    shapesList.AddShape(e.X, e.Y, currentColor, ShapesList.SHAPE_TYPE.SQUARE);
                }
                Invalidate();

            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            shapesList.Draw(e.Graphics);
        }

        private void pickColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                currentColor = colorDialog.Color;
            }
        }

        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            circleToolStripMenuItem.Checked = true;
            squareToolStripMenuItem.Checked = false;
            currentType = SHAPE_TYPE.CIRCLE;
            
        }

        private void squareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            circleToolStripMenuItem.Checked = false;
            squareToolStripMenuItem.Checked = true;
            currentType = SHAPE_TYPE.SQUARE;
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            shapesList = new ShapesList();
            FileName = null;
            Invalidate();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (FileName == null)
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Shapes file (*.shape)|*.shape";
                saveFileDialog1.Title = "Save a shape file";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    FileName = saveFileDialog1.FileName;
                }
            }

            if (FileName != null)
            {
                IFormatter fmt = new BinaryFormatter();
                FileStream strm = new FileStream(FileName, FileMode.Create, FileAccess.Write, FileShare.None);
                fmt.Serialize(strm,shapesList);
                strm.Close();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FileName == null)
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Shapes file (*.shape)|*.shape";
                saveFileDialog1.Title = "Save a shape file";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    FileName = saveFileDialog1.FileName;
                }
            }

            if (FileName != null)
            {
                IFormatter fmt = new BinaryFormatter();
                FileStream strm = new FileStream(FileName, FileMode.Create, FileAccess.Write, FileShare.None);
                fmt.Serialize(strm, shapesList);
                strm.Close();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveAsToolStripMenuItem_Click(sender, e);
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter= "Shapes file (*.shape)|*.shape";
            openFileDialog1.Title = "Open shape file";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog1.FileName;
                IFormatter fmt = new BinaryFormatter();
                FileStream strm = new FileStream(FileName, FileMode.Open, FileAccess.Read);
                shapesList = (ShapesList)fmt.Deserialize(strm);
                strm.Close();
            }
            Invalidate();
        }
    }
}
