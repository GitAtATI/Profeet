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
    public partial class Form2 : Form
    {
        public Form2(Image<Bgr, byte> img)
        {
            InitializeComponent();
            mouseDrag = false;
            prevPt = new Point(-1, -1);
            markerMask = new Image<Gray, byte>(img.Width, img.Height, new Gray(0));
            testMask = new Image<Gray, int>(img.Width, img.Height, new Gray(0));
            originalImg = img;
            outputImg = originalImg;
            imageBox1.Image = outputImg;
            imageBox1.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int i, j, compCount = 0;
            
            VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
            Mat hierarchy = new Mat();

            CvInvoke.FindContours(markerMask, contours, hierarchy, RetrType.Ccomp, ChainApproxMethod.ChainApproxSimple);
            
            Image<Gray, int> markers = new Image<Gray, int>(markerMask.Width, markerMask.Height, new Gray(0));

            //create a Bitmap to access the hierarchy data
            Bitmap bmp = hierarchy.Bitmap;
            Image<Gray, int> test = new Image<Gray, int>(bmp);
            
            //this is the magic loop I don't understand. I think it goes through all the contours and sets their values to
            //1, 2, 3 etc. (from compCount, based on the number of marks made). These values are then used by the
            //Watershed call to actually run Watershed
            for (int idx = 0; idx >= 0; idx = (int)test[idx, 0].Intensity, compCount++)
            {
                CvInvoke.DrawContours(markers, contours, idx, new MCvScalar(compCount + 1));
            }


            try
            {
                CvInvoke.Watershed(originalImg, markers);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            //All the code below here is untested because I haven't managed to get the above code working
            //However, this stuff is pretty simple and I think it will work without much hassle
            
            //Creates an array of random colors for the output image
            Bgr[] colorTab = new Bgr[compCount];
            for (i = 0; i < compCount; i++)
            {
                Random rand = new Random();
                colorTab[i] = new Bgr(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
            }

            //Goes through checking the index of each pixel in markers
            //if the index is -1, it's a border
            //if the index is a number between 0 and compCount, it's a watershed basin
            //else, the pixel is set to black-- I never see this happen in my working C++ code
            Image<Bgr, byte> wshed = new Image<Bgr, byte>(markers.Size);
            for (i = 0; i < markers.Rows; i++)
            {
                for (j = 0; j < markers.Cols; j++)
                {
                    int index = (int)markers[i, j].Intensity;
                    if (index == -1)
                    {
                        wshed[i, j] = new Bgr(255, 255, 255);
                    }
                    else if (index <= 0 || index > compCount)
                    {
                        wshed[i, j] = new Bgr(0, 0, 0);
                    }
                    else
                    {
                        wshed[i, j] = colorTab[index - 1];
                    }
                }
            }

            imageBox1.Image = wshed;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            outputImg = originalImg;
            imageBox1.Image = outputImg;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void imageBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDrag = true;
            prevPt = new Point(e.X, e.Y);
        }

        private void imageBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDrag = false;
            prevPt = new Point(-1, -1);
        }

        private void imageBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDrag)
            {
                Point pt = new Point(e.X, e.Y);
                if (prevPt.X < 0)
                    prevPt = pt;
                CvInvoke.Line(markerMask, prevPt, pt, new MCvScalar(255, 255, 255), 5);
                CvInvoke.Line(outputImg, prevPt, pt, new MCvScalar(255, 0, 255), 5);
                prevPt = pt;
                imageBox1.Image = outputImg;
            }
        }

        private void markerIndex_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = "" + markerIndex.Value;
        }
    }
}
