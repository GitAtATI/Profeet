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
            lastClicked = new Point(-1, -1);
            colorKey = new Dictionary<Bgr, Bgr>();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog Openfile = new OpenFileDialog();
            if (Openfile.ShowDialog() == DialogResult.OK)
            {
                //Load the image from file and resize it for display
                originalImg =
                    new Image<Bgr, byte>(Openfile.FileName);
                currentImg = originalImg.Clone();
                    //.Resize(400, 400, Emgu.CV.CvEnum.Inter.Linear, true);
                imageBox1.Image = currentImg;
            }
        }

        private void edgeDetectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double cannyThreshold = 180.0;
            double cannyThresholdLinking = 120.0;
            UMat cannyEdges = new UMat();
            CvInvoke.Canny(currentImg, cannyEdges, cannyThreshold, cannyThresholdLinking);
            currentImg = new Image<Bgr, byte>(cannyEdges.Bitmap);
            imageBox1.Image = cannyEdges;
        }

        private void originalImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentImg = originalImg;
            imageBox1.Image = originalImg;
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Undo function
        }

        private void colorReductionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int colorNumber = 3;

            Matrix<float> points = new Matrix<float>(currentImg.Cols * currentImg.Rows, 1, 3);
            Bgr temp;
            int i = 0;
            for (int y = 0; y < currentImg.Rows; y++)
            {
                for (int x = 0; x < currentImg.Cols; x++)
                {
                    temp = currentImg[y, x];
                    points.Data[i, 0] = (float)temp.Blue;
                    points.Data[i, 1] = (float)temp.Green;
                    points.Data[i, 2] = (float)temp.Red;
                    i++;
                }
            }

            Matrix<Int32> labels = new Matrix<Int32>(currentImg.Rows * currentImg.Cols, 1);
            MCvTermCriteria criteria = new MCvTermCriteria(10, 1.0);
            criteria.Type = TermCritType.Iter | TermCritType.Eps;
            Matrix<Int32> centers = new Matrix<Int32>(points.Cols, 3);

            //test

            CvInvoke.Kmeans(points, colorNumber, labels, criteria, 10, KMeansInitType.PPCenters, centers);

            Image<Bgr, byte> outImg = new Image<Bgr, byte>(currentImg.Size);
            int cluster;
            Bgr color;
            i = 0;
            for (int y = 0; y < currentImg.Rows; y++)
            {
                for (int x = 0; x < currentImg.Cols; x++)
                {
                    try
                    {
                        cluster = labels[i, 0];
                        MCvScalar scalar = CvInvoke.cvGet2D(centers, cluster, 0);

                        color = new Bgr(scalar.V0, scalar.V1, scalar.V2);
                        //Console.WriteLine(scalar.V0 + ", " + scalar.V1 + ", " + scalar.V2);
                        outImg[y, x] = color;
                        i++;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
            }

            imageBox1.Image = outImg;
        }

        private void editPixelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Edit at pixel level
        }

        private void overlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double lvl = ((Double) trackBar1.Value) / 100;
            Image<Bgr, byte> newImg = (1.0 - lvl) * originalImg + lvl * currentImg;
            imageBox1.Image = newImg;
        }

        private void resizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //resize
        }

        private void saturationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rectangle ccomp;
            CvInvoke.FloodFill(currentImg, null, lastClicked, 
                new MCvScalar(trackBar1.Value, trackBar1.Value, trackBar1.Value), out ccomp, new MCvScalar(20), 
                new MCvScalar(20), Connectivity.FourConnected, FloodFillType.Default);
            imageBox1.Image = currentImg;
        }

        private void colorShiftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!trackingColors)
            {
                trackingColors = true;
                Console.WriteLine("Tracking colors");
            }
            else if (colorKey.Count == 3)
            {
                for (int y = 0; y < currentImg.Rows; y++)
                {
                    for (int x = 0; x < currentImg.Cols; x++)
                    {
                        foreach (KeyValuePair<Bgr, Bgr> pair in colorKey)
                        {
                            if (currentImg[y, x].Equals(pair.Key))
                            {
                                currentImg[y, x] = pair.Value;
                            }
                        }
                    }
                }
                trackingColors = false;
                imageBox1.Image = currentImg;
            }
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

        private void imageBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (inBounds(e.Location, currentImg))
            {
                lastClicked = e.Location;
                if (trackingColors && colorKey.Count < 3)
                {
                    if (!colorKey.ContainsKey(currentImg[e.Y, e.X]))
                    {
                        Random rand = new Random();
                        colorKey.Add(currentImg[e.Y, e.X], new Bgr(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255)));
                        Console.WriteLine("Added color " + colorKey.Count);
                    }
                }
            }
        }

        private static Boolean inBounds(Point p, Image<Bgr, byte> i)
        {
            if ((p.X > 0 && p.Y > 0) && (p.X < i.Width && p.Y < i.Height))
                return true;
            return false;
        }

    }
}
