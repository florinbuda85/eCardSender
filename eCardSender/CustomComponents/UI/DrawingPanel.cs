using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eCardSender.CustomComponents
{
    public partial class DrawingPanel : Panel
    {
        private List<Point> drawnPoints;
        private Color mColor = Color.Red;
        //private GraphicsPath graphicsPaths = new GraphicsPath();
        private Point oldCoords;
        //private Pen pen = new Pen(Color.Navy, 7);

        private List<GraphicsPath> lines = new List<GraphicsPath>();
        private List<Pen> pens = new List<Pen>();

        public DrawingPanel()
        {
            //InitializeComponent();
            drawnPoints = new List<Point>();

            // Double buffering is needed for drawing this smoothly,
            // else we'll experience flickering
            // since we call invalidate for the whole control.
            this.DoubleBuffered = true;
        }

        public void setPenColor(Color c)
        {
            mColor = c;

            lines.Add(new GraphicsPath());
            
            pens.Add(new Pen(c, 1));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            for (int i = 0; i < lines.Count(); i++)
            {
                e.Graphics.DrawPath(pens[i], lines[i]);
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (lines.Count == 0)
            {
                setPenColor(Color.Red);
            }
                        
            if (e.Button == MouseButtons.Left)
            {
                if (oldCoords.IsEmpty)
                    lines.ElementAt(lines.Count-1).StartFigure();
                else
                {
                    lines.ElementAt(lines.Count - 1).AddLine(oldCoords, new Point(e.X, e.Y));
                    this.CreateGraphics().DrawPath(pens.ElementAt(lines.Count - 1), lines.ElementAt(lines.Count - 1));
                }
                oldCoords = new Point(e.X, e.Y);
            }
            else
            {
                oldCoords = Point.Empty;
            }                
        }

        public void SaveBitmap(string filename)
        {
            Bitmap bmp = new Bitmap((int)Width, (int)Height);
            DrawToBitmap(bmp, new Rectangle(0, 0, Width, Height));

            using (FileStream saveStream = new FileStream(filename, FileMode.OpenOrCreate))
            {
                bmp.Save(saveStream, ImageFormat.Bmp);
            }
        }
    }

}
