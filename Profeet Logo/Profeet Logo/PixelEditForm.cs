using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;

namespace Profeet_Logo
{
    public partial class PixelEditForm : Form
    {
        public PixelEditForm(Mat img)
        {
            InitializeComponent();
            updateColorBox();
            matCurrentImage = img.Clone();
            imageBox1.Image = matCurrentImage.ToImage<Bgr, Byte>();
            mode = new Emgu.CV.UI.ImageBox.FunctionalModeOption[2] {
                Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum,
                Emgu.CV.UI.ImageBox.FunctionalModeOption.PanAndZoom};
            imageBox1.FunctionalMode = mode[0];
            mouseDrag = false;
            pickingColor = false;
            prevPt = new Point(-1, -1);
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.AllowFullOpen = true;
            dialog.AnyColor = true;
            dialog.SolidColorOnly = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Color c = dialog.Color;
                activeColor = new MCvScalar(c.B, c.G, c.R);
                updateColorBox();
            }
        }

        private void imageBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (imageBox1.FunctionalMode.Equals(mode[1]))
            {
                disablePicking();
                return;
            }

            Point pt = getAdjustedClick(e);

            if (pickingColor)
            {
                Image<Bgr, Byte> i = matCurrentImage.ToImage<Bgr, Byte>();
                int b = i.Data[pt.Y, pt.X, 0];
                int g = i.Data[pt.Y, pt.X, 1];
                int r = i.Data[pt.Y, pt.X, 2];
                activeColor = new MCvScalar(b, g, r);
                updateColorBox();
                disablePicking();
                return;
            }

            if (radioPaint.Checked == true)
            {
                CvInvoke.Line(matCurrentImage, pt, pt, activeColor, trackBot.Value);
            }
            else
            {
                Rectangle ccomp;
                CvInvoke.FloodFill(matCurrentImage, null, pt, activeColor, out ccomp, new MCvScalar(20),
                    new MCvScalar(20), Connectivity.FourConnected, FloodFillType.Default);
            }
            imageBox1.Image = matCurrentImage.ToImage<Bgr, Byte>();
            mouseDrag = true;
            prevPt = pt;
        }

        private void imageBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (imageBox1.FunctionalMode.Equals(mode[1])) return;
            mouseDrag = false;
            prevPt = new Point(-1, -1);
        }

        private void imageBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (imageBox1.FunctionalMode.Equals(mode[1])) return;
            if (mouseDrag)
            {
                Point pt = getAdjustedClick(e);
                if (prevPt.X < 0) prevPt = pt;
                if (radioPaint.Checked == true)
                {
                    CvInvoke.Line(matCurrentImage, prevPt, pt, activeColor, trackBot.Value);
                }
                else
                {
                    Rectangle ccomp;
                    CvInvoke.FloodFill(matCurrentImage, null, pt, activeColor, out ccomp, new MCvScalar(20),
                        new MCvScalar(20), Connectivity.FourConnected, FloodFillType.Default);
                }
                imageBox1.Image = matCurrentImage.ToImage<Bgr, Byte>();
                prevPt = pt;
            }
        }

        //Alternates between no zoom/pan (paint mode) and zoom/pan mode
        private void imgModeButton_Click(object sender, EventArgs e)
        {
            if (imageBox1.FunctionalMode.Equals(mode[0]))
                imageBox1.FunctionalMode = mode[1];
            else imageBox1.FunctionalMode = mode[0];
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            matOutputImage = matCurrentImage.Clone();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        //Takes click on zoomed in and/or panned image
        //Returns location of that click on the actual image, rather than the ImageBox
        private Point getAdjustedClick(MouseEventArgs e)
        {
            double xOffset = imageBox1.HorizontalScrollBar.Value;
            double yOffset = imageBox1.VerticalScrollBar.Value;
            double zoom = imageBox1.ZoomScale;
            int x = (int)(xOffset + (e.X / zoom));
            int y = (int)(yOffset + (e.Y / zoom));
            return new Point(x, y);
        }


        private void radioPaint_CheckedChanged(object sender, EventArgs e)
        {
            labelTop.Visible = false;
            trackTop.Visible = false;
            labelMid.Visible = false;
            trackMid.Visible = false;

            labelBot.Visible = true;
            labelBot.Text = "Size: 1";

            trackBot.Visible = true;
            trackBot.Minimum = 1;
            trackBot.Maximum = 10;
            trackBot.Value = 1;
        }

        private void radioFill_CheckedChanged(object sender, EventArgs e)
        {
            labelTop.Visible = false;
            trackTop.Visible = false;

            labelMid.Visible = true;
            labelMid.Text = "loDiff";

            trackMid.Visible = true;
            trackMid.Minimum = 0;
            trackMid.Maximum = 255;
            trackMid.Value = 20;

            labelBot.Visible = true;
            labelBot.Text = "upDiff";

            trackBot.Visible = true;
            trackBot.Minimum = 0;
            trackBot.Maximum = 255;
            trackBot.Value = 20;
        }

        private void trackBot_Scroll(object sender, EventArgs e)
        {
            if (radioPaint.Checked == true)
            {
                labelBot.Text = "Size: " + trackBot.Value;
            }
            else
            {

            }
        }

        private void trackMid_Scroll(object sender, EventArgs e)
        {

        }

        private void trackTop_Scroll(object sender, EventArgs e)
        {

        }

        private void buttonEyedropper_Click(object sender, EventArgs e)
        {
            enablePicking();
        }

        private void enablePicking()
        {
            pickingColor = true;
            imageBox1.Cursor = Cursors.NoMove2D;
        }

        private void disablePicking()
        {
            pickingColor = false;
            imageBox1.Cursor = Cursors.Cross;
        }

        private void updateColorBox()
        {
            Image<Bgr, Byte> i = new Image<Bgr, Byte>(75, 23);
            Rectangle ccomp;
            CvInvoke.FloodFill(i, null, new Point(0, 0), activeColor, out ccomp, new MCvScalar(0), new MCvScalar(0));
            colorBox.Image = i;
        }
    }
}
