using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Imaging;
using AForge.Imaging.Filters;

namespace ImageProcessing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofile = new OpenFileDialog();
            ofile.Filter = "Image File(*.bmp,*.jpg)|*.bmp,;*.jpg";
            if (DialogResult.OK == ofile.ShowDialog())
            {
                this.picOriginal.Image = new Bitmap(ofile.FileName);
            }
        }

        private void btngray_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap(this.picOriginal.Image);
            Processing.ConvertToGray(copy);
            this.picResult.Image = copy;
        }

        private void btnNegative_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap(this.picOriginal.Image);
            Processing.ConvertToNegative(copy);
            this.picResult.Image = copy;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "Save to JPEG Files(*.JPEG)|*.JPEG";
                if (DialogResult.OK == sv.ShowDialog())
            {
                this.picResult.Image.Save(sv.FileName, ImageFormat.Jpeg);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Bitmap b = (Bitmap)picOriginal.Image;
            RotateBilinear ro = new RotateBilinear(trackBar1.Value, true);
            Bitmap c = ro.Apply(b);
            this.picResult.Image = c;
        }

        private void btnOriginal_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap(this.picOriginal.Image);
            this.picResult.Image = copy;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            Bitmap image = (Bitmap)picOriginal.Image;
            IFilter threshold = new Threshold(hScrollBar1.Value);
            image = Grayscale.CommonAlgorithms.RMY.Apply(image);
            image = threshold.Apply(image);
            picResult.Image = image;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int bright;
            bright = Convert.ToInt32(textBox1.Text);
            bright = int.Parse(textBox1.Text);
            Bitmap copy = (Bitmap)picOriginal.Image;
            Processing.Brightening(copy, bright);
            picResult.Image = copy;
        }
    }
}
