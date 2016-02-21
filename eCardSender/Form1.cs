using eCardSender.Misc;
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

namespace eCardSender
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void nudWidth_ValueChanged(object sender, EventArgs e)
        {
            drawingPanel1.Width = Decimal.ToInt32(nudWidth.Value);
        }

        private void nudHeight_ValueChanged(object sender, EventArgs e)
        {
            drawingPanel1.Height = Decimal.ToInt32(nudHeight.Value);
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                drawingPanel1.setPenColor(colorDialog1.Color);
            }
            
        }

        
        private void buttonSave_Click(object sender, EventArgs e)
        {     
            
            drawingPanel1.SaveBitmap("fisier");
        }

        private void buttonEmail_Click(object sender, EventArgs e)
        {

            string filename = "filename.bmp";
            drawingPanel1.SaveBitmap(filename);

            Mailer.Instance.sendHtmlMail(waterMarkTextBoxTo.Text, waterMarkTextBoxSubject.Text, waterMarkTextBoxMessage.Text, filename);

            waterMarkTextBoxTo.Text = "";
            waterMarkTextBoxSubject.Text = "";
            waterMarkTextBoxMessage.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


    }
}
