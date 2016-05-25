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
using System.Diagnostics;
using Emgu.CV.Util;

namespace Profeet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog Openfile = new OpenFileDialog();
            if (Openfile.ShowDialog() == DialogResult.OK)
            {
                //Load the image from file and resize it for display
                img =
                    new Image<Bgr, byte>(Openfile.FileName);
                    //.Resize(400, 400, Emgu.CV.CvEnum.Inter.Linear, true);
                imageBox1.Image = img;
            }
        }

        private void edgeDetectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double cannyThreshold = 180.0;
            double cannyThresholdLinking = 120.0;
            UMat cannyEdges = new UMat();
            CvInvoke.Canny(img, cannyEdges, cannyThreshold, cannyThresholdLinking);
            imageBox1.Image = cannyEdges;
        }

        private void originalImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imageBox1.Image = img;
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Undo function
        }

        private void colorReductionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Color Reduction
        }

        private void editPixelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Edit at pixel level
        }

        private void overlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Overlay new and original image
        }

        private void resizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //resize
        }

        private void saturationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Saturation using  floodfill
        }

        private void watershedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Watershed
        }

        private void colorLimitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Color/Course Limit Analysis
            int widthIndex, heightIndex, colorArrayIndex, lastIndex=1;
            int combineColor;
            Bgr color = new Bgr();
            int[] colorArray = new int[1000];
            Emgu.CV.Image<Emgu.CV.Structure.Bgr, System.Byte> tempImage;
            tempImage = img;
            Size imageSize = tempImage.Size;
            for (heightIndex = 0; heightIndex < imageSize.Width; heightIndex++)
            {
                lastIndex = 1;
                for (widthIndex = 0; widthIndex < imageSize.Height; widthIndex++)
                {
                    color = tempImage[widthIndex, heightIndex];
                    combineColor = (int)color.Red << 16;
                    combineColor |= (int)color.Green << 8;
                    combineColor |= (int)color.Blue;
                    for (colorArrayIndex = 0; colorArrayIndex < lastIndex; colorArrayIndex++)
                    {
                        if (colorArray[colorArrayIndex] == combineColor)
                            break;
                    }
                    if (colorArrayIndex == lastIndex)
                    {
                        colorArray[lastIndex - 1] = combineColor;
                        lastIndex++;
                    }

                }
                if (lastIndex >= 4) {
                    //string message = System.String.Format("There are four colors in row {0} ", heightIndex);
                    // MessageBox.Show(message);

                    Point p1 = new Point(0,heightIndex);
                    Point p2 = new Point(imageSize.Width,heightIndex);
                    LineSegment2D line = new LineSegment2D(p1,p2);
                    color.Blue = 0;
                    color.Red = 255;
                    color.Green = 0;

                    tempImage.Draw(line,color, 1);
                }
                for (colorArrayIndex = 0; colorArrayIndex < lastIndex; colorArrayIndex++)
                {
                    colorArray[colorArrayIndex] = 0;
                }

                lastIndex = 1;


            }
            imageBox1.Image = img;

        }

        private void floatStitchLimitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Float Stitch Limit Analysis
        }

        private void stitchSimulationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Stitch simulation
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
