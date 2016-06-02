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
            originalImg = img;
            outputImg = originalImg;
            imageBox1.Image = outputImg;
            imageBox1.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, j, compCount = 0;

            //I am unsure if these types are correct. contours seems to work
            //but hierarchy throws an exception (replacing hierarchy with a
            //null in the FindContours call avoids the exception
            //However, VecOfVecOfInt makes the most sense, so I am stuck
            VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
            VectorOfVectorOfInt hierarchy = new VectorOfVectorOfInt();

            try
            {
                CvInvoke.FindContours(markerMask, contours, hierarchy, RetrType.Ccomp, ChainApproxMethod.ChainApproxSimple);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            Matrix<int> markers = new Matrix<int>(markerMask.Width, markerMask.Height, 0);

            for (int idx = 0; idx >= 0; idx = hierarchy[idx][0], compCount++)
            {
                CvInvoke.DrawContours(markers, contours, idx, new MCvScalar(compCount + 1));
            }

            Bgr[] colorTab = new Bgr[compCount];
            for (i = 0; i < compCount; i++)
            {
                Random rand = new Random();
                colorTab[i] = new Bgr(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
            }

            CvInvoke.Watershed(outputImg, markers);

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
    }
}
