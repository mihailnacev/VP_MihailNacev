using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace VP_DrawLines
{
    public class LinesDoc
    {
        public List<Line> Lines { get; set; }

        public LinesDoc()
        {
            Lines = new List<Line>();
        }

        public void AddLine(Point start,Point end,int width,Color color)
        {
            Line line = new Line(start, end, width,color);
            Lines.Add(line);
        }

        public void DrawLines(Graphics g)
        {
            foreach(Line line in Lines)
            {
                line.Draw(g);
            }
        }
    }
}
