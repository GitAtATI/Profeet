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



public delegate void AddImageDelegate();


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
                originalImg = new Image<Bgr, byte>(Openfile.FileName);
                currentImg = new Image<Bgr, byte>(originalImg.Size);
                tempImg = new Image<Bgr, byte>(originalImg.Size);
                currentImg = originalImg.Copy();
                matCurrentImage = new Mat(Openfile.FileName, Emgu.CV.CvEnum.LoadImageType.Color);
                imageBox1.Image = matCurrentImage;
            }
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Save Image
            matCurrentImage.Save(origImageFile);
        }
        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Save as...
            SaveFileDialog saveAsFile = new SaveFileDialog();
            saveAsFile.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            if (saveAsFile.ShowDialog() == DialogResult.OK)
            {
                matCurrentImage.Save(saveAsFile.FileName);
            }

        }


        private void edgeDetectionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Profeet_Logo.functionControls form = new Profeet_Logo.functionControls(currentImg);

            //Generate labels and trackbars
            //Create a new label and text box
            Label labelThreshold = new Label();
            Label labelThresholdLinking = new Label();
            TrackBar trackbarThreshold = new TrackBar();
            TrackBar trackbarThresholdLinking = new TrackBar();

            //Initialize label's property
            labelThreshold.Text = "Threshold";
            labelThreshold.Location = new Point(30, 10);
            labelThreshold.AutoSize = true;
            labelThresholdLinking.Text = "Threshold Linking";
            labelThresholdLinking.Location = new Point(30, 70);
            labelThresholdLinking.AutoSize = true;

            //Initialize textBoxes Property
            trackbarThreshold.Name = "Threshold";
            trackbarThreshold.Location = new Point(50, 30);
            trackbarThreshold.Minimum = 0;
            trackbarThreshold.Maximum = 255;
            trackbarThresholdLinking.Name = "ThresholdLinking";
            trackbarThresholdLinking.Location = new Point(50, 90);
            trackbarThresholdLinking.Minimum = 0;
            trackbarThresholdLinking.Maximum = 255;

            trackbarThreshold.Scroll += (object confirmsender, EventArgs confirmE) => { form.imageFunction(); };
            trackbarThresholdLinking.Scroll += (object confirmsender, EventArgs confirmE) => { form.imageFunction(); };

            //Add the labels and text box to the form
            form.Controls.Add(labelThreshold);
            form.Controls.Add(labelThresholdLinking);
            form.Controls.Add(trackbarThreshold);
            form.Controls.Add(trackbarThresholdLinking);
            form.imageFunction = new AddImageDelegate(this.edgeDetect);
            //Hide the Apply button
            Button btnApply = (Button)form.Controls["Apply"];
            btnApply.Visible = false;

            generalForm = form;
            tempImg = currentImg.Copy();

            DialogResult result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                currentImg = tempImg.Copy();
            }
            imageBox1.Image = currentImg;


        }

        private void originalImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentImg = originalImg.Copy();
            imageBox1.Image = originalImg;
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Undo function
        }

        private void colorReductionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //resize
            Profeet_Logo.functionControls form = new Profeet_Logo.functionControls(currentImg);

            //Generate labels and text boxes
            //Create a new label and text box
            Label labelColors = new Label();
            TextBox textColors = new TextBox();

            //Initialize label's property
            labelColors.Text = "Number of Colors";
            labelColors.Location = new Point(30, 30);
            labelColors.AutoSize = true;

            //Initialize textBoxes Property
            textColors.Name = "textColors";
            textColors.Location = new Point(labelColors.Width+20, labelColors.Top - 3);


            //Add the labels and text box to the form
            form.Controls.Add(labelColors);
            form.Controls.Add(textColors);
            form.imageFunction = new AddImageDelegate(this.colorReduction);
            generalForm = form;
            tempImg = currentImg.Copy();
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                currentImg = tempImg;
            }
            imageBox1.Image = currentImg;

        }

        private void editPixelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profeet_Logo.PixelEditForm form = new Profeet_Logo.PixelEditForm(matCurrentImage);
            DialogResult result = form.ShowDialog();
        }

        private void overlayToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Profeet_Logo.functionControls form = new Profeet_Logo.functionControls(currentImg);

            //Generate labels and trackbars
            //Create a new label and text box
            Label labelThreshold = new Label();
            TrackBar trackbarThreshold = new TrackBar();

            //Initialize label's property
            labelThreshold.Text = "Threshold";
            labelThreshold.Location = new Point(30, 10);
            labelThreshold.AutoSize = true;

            //Initialize textBoxes Property
            trackbarThreshold.Name = "Threshold";
            trackbarThreshold.Location = new Point(50, 30);
            trackbarThreshold.Minimum = 0;
            trackbarThreshold.Maximum = 100;

            trackbarThreshold.Scroll += (object confirmsender, EventArgs confirmE) => { form.imageFunction(); };

            //Add the labels and text box to the form
            form.Controls.Add(labelThreshold);
            form.Controls.Add(trackbarThreshold);
            form.imageFunction = new AddImageDelegate(this.overlay);
            //Hide the Apply button
            Button btnApply = (Button)form.Controls["Apply"];
            btnApply.Visible = false;

            generalForm = form;
            tempImg = currentImg.Copy();

            DialogResult result = form.ShowDialog();

            imageBox1.Image = currentImg;

        }

        private void resizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //resize
            Profeet_Logo.functionControls form = new Profeet_Logo.functionControls(currentImg);

            //Generate labels and text boxes
            //Create a new label and text box
            Label labelWidth = new Label();
            Label labelHeight = new Label();
            TextBox textWidth = new TextBox();
            TextBox textHeight = new TextBox();

            //Initialize label's property
            labelWidth.Text = "Width Pixels";
            labelWidth.Location = new Point(30, 30);
            labelWidth.AutoSize = true;
            labelHeight.Text = "Height Pixels";
            labelHeight.Location = new Point(30, 60);
            labelHeight.AutoSize = true;

            //Initialize textBoxes Property
            textWidth.Name = "textWidth";
            textWidth.Location = new Point(labelWidth.Width, labelWidth.Top - 3);
            textHeight.Location = new Point(labelHeight.Width, labelHeight.Top - 3);
            textHeight.Name = "textHeight";

            //Button confirmation = new Button() { Text = "Ok", Left = 10, Width = 100, Top = 10 };
            //confirmation.Click += (object confirmsender, EventArgs confirmE) => { form.imageFunction(); };

            //Add the labels and text box to the form
            form.Controls.Add(labelWidth);
            form.Controls.Add(textWidth);
            form.Controls.Add(labelHeight);
            form.Controls.Add(textHeight);
            //form.Controls.Add(confirmation);
            form.imageFunction = new AddImageDelegate(this.resizeImage);
            generalForm = form;
            tempImg = currentImg.Copy();

            DialogResult result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                currentImg = tempImg.Copy();
            }
            imageBox1.Image = currentImg;

        }

        private void saturationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modelessForm = new Profeet_Logo.functionControls(currentImg);

            //Generate labels and trackbars
            //Create a new label and text box
            Label labelThreshold = new Label();
            TrackBar trackbarThreshold = new TrackBar();

            //Initialize label's property
            labelThreshold.Text = "Threshold";
            labelThreshold.Location = new Point(30, 10);
            labelThreshold.AutoSize = true;

            //Initialize textBoxes Property
            trackbarThreshold.Name = "Threshold";
            trackbarThreshold.Location = new Point(50, 30);
            trackbarThreshold.Minimum = 0;
            trackbarThreshold.Maximum = 100;

            trackbarThreshold.Scroll += (object confirmsender, EventArgs confirmE) => { modelessForm.imageFunction(); };

            //Add the labels and text box to the form
            modelessForm.Controls.Add(labelThreshold);
            modelessForm.Controls.Add(trackbarThreshold);
            modelessForm.imageFunction = new AddImageDelegate(this.saturation);
            //Hide the Apply button
            Button btnApply = (Button)modelessForm.Controls["Apply"];
            btnApply.Visible = false;

            generalForm = modelessForm;
            tempImg = currentImg.Copy();

            modelessForm.Show();
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
            Profeet_Logo.functionControls form = new Profeet_Logo.functionControls(currentImg);
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                imageBox1.Image = form.outputImg;
                Console.WriteLine("OK");
            }
            else if (result == DialogResult.Cancel)
            {
                Console.WriteLine("Cancel");
            }
        }

        private void colorLimitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //resize
            Profeet_Logo.functionControls form = new Profeet_Logo.functionControls(currentImg);

            //Generate labels and text boxes
            //Create a new label and text box
            Label labelColors = new Label();
            TextBox textColors = new TextBox();

            //Initialize label's property
            labelColors.Text = "Number of colors";
            labelColors.Location = new Point(30, 30);
            labelColors.AutoSize = true;

            //Initialize textBoxes Property
            textColors.Name = "textColors";
            textColors.Location = new Point(labelColors.Width + 18, labelColors.Top - 3);

            //Button confirmation = new Button() { Text = "Ok", Left = 10, Width = 100, Top = 10 };
            //confirmation.Click += (object confirmsender, EventArgs confirmE) => { form.imageFunction(); };

            //Add the labels and text box to the form
            form.Controls.Add(labelColors);
            form.Controls.Add(textColors);
            //form.Controls.Add(confirmation);
            form.imageFunction = new AddImageDelegate(this.colorLimit);
            generalForm = form;
            DialogResult result = form.ShowDialog();

        }

        private void floatStitchLimitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Float Stitch Limit Analysis

            Profeet_Logo.functionControls form = new Profeet_Logo.functionControls(currentImg);

            //Generate labels and text boxes
            //Create a new label and text box
            Label labelfloatStitch = new Label();
            TextBox textStitch = new TextBox();

            //Initialize label's property
            labelfloatStitch.Text = "Number of stitches";
            labelfloatStitch.Location = new Point(30, 30);
            labelfloatStitch.AutoSize = true;

            //Initialize textBoxes Property
            textStitch.Name = "textStitch";
            textStitch.Location = new Point(labelfloatStitch.Width + 25, labelfloatStitch.Top - 3);

            //Button confirmation = new Button() { Text = "Ok", Left = 10, Width = 100, Top = 10 };
            // confirmation.Click += (object confirmsender, EventArgs confirmE) => { form.imageFunction(); };

            //Add the labels and text box to the form
            form.Controls.Add(labelfloatStitch);
            form.Controls.Add(textStitch);
            //form.Controls.Add(confirmation);
            form.imageFunction = new AddImageDelegate(this.floatStitch);
            generalForm = form;
            DialogResult result = form.ShowDialog();

        }

        private void stitchSimulationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Stitch simulation
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /************************************************************************************************************************************/
        private void imageBox1_MouseUp(object sender, MouseEventArgs e)
        {
            
            if (inBounds(e.Location, matCurrentImage))
            {
                lastClicked = e.Location;
                Console.WriteLine(lastClicked);
                if (trackingColors && colorKey.Count < 3)
                {
                    Image<Bgr, Byte> localImg = matCurrentImage.ToImage<Emgu.CV.Structure.Bgr, System.Byte>(false);

                    if (!colorKey.ContainsKey(localImg[e.Y, e.X]))
                    {
                        Random rand = new Random();
                        colorKey.Add(localImg[e.Y, e.X], new Bgr(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255)));
                    }
                }
            }
            
        }
        private static Boolean inBounds(Point p, Mat matImage)
        {
            int width = matImage.Width;
            int height = matImage.Height;
            if ((p.X > 0 && p.Y > 0) && (p.X < width && p.Y < height))
                return true;
            return false;
        }
    /*    private static Boolean inBounds(Point p, Image<Bgr, byte> i)
        {
            if ((p.X > 0 && p.Y > 0) && (p.X < i.Width && p.Y < i.Height))
                return true;
            return false;
        }*/
        private void resizeImage()
        {
            TextBox txtbx = (TextBox)generalForm.Controls["textWidth"];
            int width = Convert.ToInt32(txtbx.Text);
            txtbx = (TextBox)generalForm.Controls["textHeight"];
            int height = Convert.ToInt32(txtbx.Text);

            tempImg = tempImg.Resize(width, height, Emgu.CV.CvEnum.Inter.Linear, true);
            imageBox1.Image = tempImg;
        }

        private void edgeDetect()
        {
            TrackBar trackbarThreshold = (TrackBar)generalForm.Controls["Threshold"];
            int threshold = Convert.ToInt32(trackbarThreshold.Value);
            TrackBar trackbarThresholdLinking = new TrackBar();
            int thresholdLinking = Convert.ToInt32(trackbarThresholdLinking.Value);

            Emgu.CV.Image<Emgu.CV.Structure.Bgr, System.Byte> localImg;
            localImg = matCurrentImage.ToImage<Emgu.CV.Structure.Bgr, System.Byte>(false);
            Mat cannyImage = new Mat();
            CvInvoke.Canny(currentImg, cannyImage, threshold, thresholdLinking);
            tempImg = cannyImage.ToImage<Emgu.CV.Structure.Bgr, System.Byte>(false);
            imageBox1.Image = tempImg;
        }

        private void colorLimit()
        {
            //Color/Course Limit Analysis
            TextBox txtbx = (TextBox)generalForm.Controls["textColors"];
            int noOfColors = Convert.ToInt32(txtbx.Text);

            int widthIndex, heightIndex, colorArrayIndex, lastIndex = 1;
            int combineColor;
            Bgr color = new Bgr();
            int[] colorArray = new int[1000];
            Emgu.CV.Image<Emgu.CV.Structure.Bgr, System.Byte> tempImage;
            tempImage = currentImg;
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
                if (lastIndex >= noOfColors)
                {
                    //string message = System.String.Format("There are four colors in row {0} ", heightIndex);
                    // MessageBox.Show(message);

                    Point p1 = new Point(0, heightIndex);
                    Point p2 = new Point(imageSize.Width, heightIndex);
                    LineSegment2D line = new LineSegment2D(p1, p2);
                    color.Blue = 0;
                    color.Red = 255;
                    color.Green = 0;

                    tempImage.Draw(line, color, 1);
                }
                for (colorArrayIndex = 0; colorArrayIndex < lastIndex; colorArrayIndex++)
                {
                    colorArray[colorArrayIndex] = 0;
                }

                lastIndex = 1;


            }
            imageBox1.Image = tempImage;

        }
        private void floatStitch()
        {
            //Float stitch Analysis
            TextBox txtbx = (TextBox)generalForm.Controls["textStitch"];
            int noOfStitches = Convert.ToInt32(txtbx.Text);

            int widthIndex, heightIndex, colorArrayIndex, lastIndex = 1;
            int combineColor, lastCombineColor = 0, combineColorCounter = 0;
            Bgr color = new Bgr();
            int[] colorArray = new int[1000];
            Emgu.CV.Image<Emgu.CV.Structure.Bgr, System.Byte> tempImage;
            tempImage = currentImg;
            Size imageSize = tempImage.Size;
            for (heightIndex = 0; heightIndex < imageSize.Width; heightIndex++)
            {
                lastCombineColor = 0;
                combineColorCounter = 0;
                for (widthIndex = 0; widthIndex < imageSize.Height; widthIndex++)
                {
                    color = tempImage[widthIndex, heightIndex];
                    combineColor = (int)color.Red << 16;
                    combineColor |= (int)color.Green << 8;
                    combineColor |= (int)color.Blue;
                    if (combineColor == lastCombineColor)
                        combineColorCounter++;
                    else
                    {
                        lastCombineColor = combineColor;
                        if (combineColorCounter >= noOfStitches)
                        {
                            Point p1 = new Point(widthIndex - combineColorCounter, heightIndex);
                            Point p2 = new Point(widthIndex, heightIndex);
                            LineSegment2D line = new LineSegment2D(p1, p2);
                            color.Blue = 0;
                            color.Red = 255;
                            color.Green = 0;

                            combineColorCounter = 0;
                            tempImage.Draw(line, color, 1);
                        }

                    }




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
                if (lastIndex >= 4)
                {
                    //string message = System.String.Format("There are four colors in row {0} ", heightIndex);
                    // MessageBox.Show(message);


                }
                for (colorArrayIndex = 0; colorArrayIndex < lastIndex; colorArrayIndex++)
                {
                    colorArray[colorArrayIndex] = 0;
                }

                lastIndex = 1;


            }
            imageBox1.Image = tempImage;

        }
        private void waterShed()
        {
            //  Mat markerMask, img, imgGray;
            //   img = currentImg.Mat;
            //   markerMask = img;
            //   imgGray = markerMask;

            //    CvInvoke.CvtColor(img, markerMask, ColorConversion.Bgr2Gray);
            //    CvInvoke.CvtColor(markerMask, imgGray, ColorConversion.Gray2Bgr);

            //markerMask =MCvScalar(0, 0, 0);

        }
        private void colorReduction()
        {

            TextBox txtbx = (TextBox)generalForm.Controls["textColors"];
            int noOfColors = Convert.ToInt32(txtbx.Text);

            Emgu.CV.Image<Emgu.CV.Structure.Bgr, System.Byte> localImg;
            Mat matLocalImg = new Mat();
            matLocalImg = tempImg.Mat;

            Matrix<float> points = new Matrix<float>(matLocalImg.Cols * matLocalImg.Rows, 3);
            Bgr temp;
            int i = 0;
            for (int y = 0; y < matLocalImg.Rows; y++)
            {
                for (int x = 0; x < matLocalImg.Cols; x++)
                {
                    temp = tempImg[y, x];
                    points.Data[i, 0] = (float)temp.Blue;
                    points.Data[i, 1] = (float)temp.Green;
                    points.Data[i, 2] = (float)temp.Red;
                    i++;
                }
            }

            Matrix<int> labels = new Matrix<int>(matLocalImg.Rows * matLocalImg.Cols, 1);
            MCvTermCriteria criteria = new MCvTermCriteria(10, 1.0);
            criteria.Type = TermCritType.Iter | TermCritType.Eps;
            Matrix<Single> centers = new Matrix<Single>(noOfColors, 3);

            CvInvoke.Kmeans(points, noOfColors, labels, criteria, 10, KMeansInitType.PPCenters, centers);

            int cluster;
            Bgr color;
            i = 0;
            for (int y = 0; y < matLocalImg.Rows; y++)
            {
                for (int x = 0; x < matLocalImg.Cols; x++)
                {
                    cluster = labels[i, 0];
                    color = new Bgr(centers[cluster, 0], centers[cluster, 1], centers[cluster, 2]);
                    tempImg[y, x] = color;
                    i++;
                }
            }

            imageBox1.Image = tempImg;
        }

        private void overlay()
        {
            TrackBar trackbarThreshold = (TrackBar)generalForm.Controls["Threshold"];
            double threshold = Convert.ToDouble(trackbarThreshold.Value);

            Image<Bgr, byte> newImg = (1.0 - threshold) * originalImg + threshold * tempImg;

            imageBox1.Image = newImg;

        }
        private void saturation()
        {
            TrackBar trackbarThreshold = (TrackBar)generalForm.Controls["Threshold"];
            double threshold = Convert.ToDouble(trackbarThreshold.Value);

            Rectangle ccomp;
            CvInvoke.FloodFill(tempImg, null, lastClicked,
                new MCvScalar(threshold, threshold, threshold), out ccomp, new MCvScalar(20),
                new MCvScalar(20), Connectivity.FourConnected, FloodFillType.Default);
            imageBox1.Image = tempImg;
        }
    }
}
