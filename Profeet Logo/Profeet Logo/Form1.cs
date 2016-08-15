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
            swapCorner1 = new Point(-1, -1);
            mode = new Emgu.CV.UI.ImageBox.FunctionalModeOption[2] {
                Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum,
                Emgu.CV.UI.ImageBox.FunctionalModeOption.PanAndZoom};
            startColorChosen = false;
            endColorChosen = false;
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
                //matCurrentImage = new Mat(Openfile.FileName, Emgu.CV.CvEnum.LoadImageType.Color);
                imageBox1.Image = currentImg.Mat;
            }
            overlayCheckBox.Enabled = true;
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Save Image
            currentImg.Save(origImageFile);
        }
        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Save as...
            SaveFileDialog saveAsFile = new SaveFileDialog();
            saveAsFile.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            if (saveAsFile.ShowDialog() == DialogResult.OK)
            {
                currentImg.Save(saveAsFile.FileName);
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
        
        private void steppingResizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tempImg = currentImg.Copy();

            Size sizeGoal = new Size(50, 30);
            int colorGoal = 3;
            int steps = 5;

            int widthStep = (currentImg.Width - sizeGoal.Width) / steps;
            int heightStep = (currentImg.Height - sizeGoal.Height) / steps;
            int colorStep = 1;

            for (int i = steps - 1; i >= 0; i--)
            {
                Console.WriteLine(i);
                int tempWidth = sizeGoal.Width + (i * widthStep);
                int tempHeight = sizeGoal.Height + (i * heightStep);
                int tempColor = colorGoal + (i * colorStep);
                tempImg = tempImg.Resize(tempWidth, tempHeight, Emgu.CV.CvEnum.Inter.Area, false);
                tempImg = reduceColors(tempImg, tempColor);

                imageBox1.Image = tempImg;
                System.Threading.Thread.Sleep(1000);
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

        private static Boolean inBounds(Point p, Mat matImage)
        {
            if (matImage == null) return false;
            int width = matImage.Width;
            int height = matImage.Height;
            if ((p.X > 0 && p.Y > 0) && (p.X < width && p.Y < height))
                return true;
            return false;
        }

        private void resizeImage()
        {
            TextBox txtbx = (TextBox)generalForm.Controls["textWidth"];
            int width = Convert.ToInt32(txtbx.Text);
            txtbx = (TextBox)generalForm.Controls["textHeight"];
            int height = Convert.ToInt32(txtbx.Text);

            tempImg = tempImg.Resize(width, height, Emgu.CV.CvEnum.Inter.Area, false);
            imageBox1.Image = tempImg;
        }

        private void edgeDetect()
        {
            TrackBar trackbarThreshold = (TrackBar)generalForm.Controls["Threshold"];
            int threshold = Convert.ToInt32(trackbarThreshold.Value);
            TrackBar trackbarThresholdLinking = new TrackBar();
            int thresholdLinking = Convert.ToInt32(trackbarThresholdLinking.Value);

            Emgu.CV.Image<Emgu.CV.Structure.Bgr, System.Byte> localImg;
            localImg = currentImg.Mat.ToImage<Emgu.CV.Structure.Bgr, System.Byte>(false);
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
            tempImg = currentImg.Copy();
            Size imageSize = tempImg.Size;
            for (heightIndex = 0; heightIndex < imageSize.Width; heightIndex++)
            {
                lastIndex = 1;
                for (widthIndex = 0; widthIndex < imageSize.Height; widthIndex++)
                {
                    color = tempImg[widthIndex, heightIndex];
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

                    tempImg.Draw(line, color, 1);
                }
                for (colorArrayIndex = 0; colorArrayIndex < lastIndex; colorArrayIndex++)
                {
                    colorArray[colorArrayIndex] = 0;
                }

                lastIndex = 1;


            }
            currentImg = tempImg.Copy();
            imageBox1.Image = currentImg;

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
            tempImg = currentImg.Copy();
            Size imageSize = tempImg.Size;
            for (heightIndex = 0; heightIndex < imageSize.Width; heightIndex++)
            {
                lastCombineColor = 0;
                combineColorCounter = 0;
                for (widthIndex = 0; widthIndex < imageSize.Height; widthIndex++)
                {
                    color = tempImg[widthIndex, heightIndex];
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
                            tempImg.Draw(line, color, 1);
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
            currentImg = tempImg.Copy();
            imageBox1.Image = currentImg;

        }

        private void colorReduction()
        {

            TextBox txtbx = (TextBox)generalForm.Controls["textColors"];
            int noOfColors = Convert.ToInt32(txtbx.Text);

            tempImg = reduceColors(tempImg, noOfColors);

            currentImg = tempImg.Copy();
            imageBox1.Image = currentImg;
        }

        private Image<Bgr, byte> reduceColors(Image<Bgr, byte> image, int noOfColors)
        {
            Mat matLocalImg = new Mat();
            matLocalImg = image.Mat;

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

            Image<Bgr, byte> reducingTempImg = new Image<Bgr, byte>(image.Size);

            int cluster;
            Bgr color;
            i = 0;
            for (int y = 0; y < matLocalImg.Rows; y++)
            {
                for (int x = 0; x < matLocalImg.Cols; x++)
                {
                    cluster = labels[i, 0];
                    color = new Bgr(centers[cluster, 0], centers[cluster, 1], centers[cluster, 2]);
                    reducingTempImg[y, x] = color;
                    i++;
                }
            }

            return reducingTempImg;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            imageBox1.Size = new System.Drawing.Size(this.Size.Width - 15, this.Size.Height - 120);
        }

        private void overlayTrackBar_Scroll(object sender, EventArgs e)
        {
            Console.WriteLine(overlayTrackBar.Value);
            
            if (overlayTrackBar.Value != 0 && overlayTrackBar.Value != 100)
            {
                radioCustom.Checked = true;
            }

            double threshold = Convert.ToDouble(overlayTrackBar.Value) / 100;
            
            if (originalImg.Size.Equals(currentImg.Size))
            {
                scaledImg = (1.0 - threshold) * originalImg + threshold * currentImg;
            }
            else
            {
                factorX = originalImg.Width / currentImg.Width;
                factorY = originalImg.Height / currentImg.Height;

                int scaledX = currentImg.Width * factorX;
                int scaledY = currentImg.Height * factorY;

                Image<Bgr, byte> scaledOriginalImg = originalImg.Resize(scaledX, scaledY, Emgu.CV.CvEnum.Inter.Area, false);
                Image<Bgr, byte> scaledCurrentImg = currentImg.Resize(scaledX, scaledY, Emgu.CV.CvEnum.Inter.Area, false);

                scaledImg = (1.0 - threshold) * scaledOriginalImg + threshold * scaledCurrentImg;
            }
            
            imageBox1.Image = scaledImg;
        }

        private void overlayCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (overlayCheckBox.Checked)
            {
                overlayTrackBar.Enabled = true;
                radioZero.Enabled = true;
                radioHundred.Enabled = true;
                radioCustom.Enabled = true;
                radioZero.Checked = true;
                radioZero_CheckedChanged(null, null);
            }
            else
            {
                overlayTrackBar.Enabled = false;
                radioZero.Enabled = false;
                radioHundred.Enabled = false;
                radioCustom.Enabled = false;
                imageBox1.Image = currentImg;
            }
        }

        private void radioZero_CheckedChanged(object sender, EventArgs e)
        {
            if (radioZero.Checked == true)
            {
                overlayTrackBar.Value = 0;
                overlayTrackBar_Scroll(null, null);
            }
        }

        private void radioHundred_CheckedChanged(object sender, EventArgs e)
        {
            if (radioHundred.Checked == true)
            {
                overlayTrackBar.Value = 100;
                overlayTrackBar_Scroll(null, null);
            }
        }

        private void radioCustom_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCustom.Checked == true)
            {
                overlayTrackBar_Scroll(null, null);
            }
        }

        private void imageBox1_MouseDown(object sender, MouseEventArgs e)
        {
            //Don't do anything if there is no edit form
            //Don't do anything if the image box is set to pan and zoom
            if (!checkEditing.Checked || imageBox1.FunctionalMode.Equals(mode[1]))
            {
                return;
            }
            
            Point pt = getAdjustedClick(e);

            if (pickingColor)
            {
                Image<Bgr, Byte> i;
                if (!overlayCheckBox.Checked)
                {
                    i = currentImg;
                }
                else
                {
                    i = scaledImg;
                }
                int b = i.Data[pt.Y, pt.X, 0];
                int g = i.Data[pt.Y, pt.X, 1];
                int r = i.Data[pt.Y, pt.X, 2];
                activeColor = new MCvScalar(b, g, r);
                updateColorBox();
                startColor = new MCvScalar(b, g, r);
                startColorChosen = true;
                colorBoxStartColor.Image = makeColorBox(58, 56, startColor);
                buttonEyedropper_Click(null, null);
                return;
            }
            else if (radioPaint.Checked) //Paint
            {
                //Image<Bgr, byte> testImg = currentImg.Mat.ToImage<Bgr, byte>();
                //Console.WriteLine("B: " + testImg.Data[pt.Y, pt.X, 0] + ", G: " + testImg.Data[pt.Y, pt.X, 1] + ", R: " + testImg.Data[pt.Y, pt.X, 2]);
                if (!overlayCheckBox.Checked)
                {
                    CvInvoke.Line(currentImg.Mat, pt, pt, activeColor, trackBar3.Value);
                }
                else
                {
                    CvInvoke.Line(scaledImg.Mat, pt, pt, activeColor, trackBar3.Value);
                }

            }
            else if (radioFill.Checked) //Fill
            {
                Rectangle ccomp;
                if (!overlayCheckBox.Checked)
                {
                    CvInvoke.FloodFill(currentImg.Mat, null, pt, activeColor, out ccomp, new MCvScalar(20),
                        new MCvScalar(20), Connectivity.FourConnected, FloodFillType.Default);
                }
                else
                {
                    CvInvoke.FloodFill(scaledImg.Mat, null, pt, activeColor, out ccomp, new MCvScalar(20),
                        new MCvScalar(20), Connectivity.FourConnected, FloodFillType.Default);
                }
            }
            if (radioSwap.Checked) //Swap brush
            {
                swapCorner1 = pt;
            }


            if (!overlayCheckBox.Checked)
            {
                currentImg = currentImg.Mat.ToImage<Bgr, Byte>();
                imageBox1.Image = currentImg;
            }
            else
            {
                currentImg = scaledImg.Mat.ToImage<Bgr, Byte>();
                imageBox1.Image = currentImg;
                overlayTrackBar_Scroll(null, null);
            }

            mouseDrag = true;
            lastClicked = pt;
        }

        private void imageBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (imageBox1.FunctionalMode.Equals(mode[1])) return;
            mouseDrag = false;
            lastClicked = new Point(-1, -1);
            Point topLeft = swapCorner1;
            Point botRight = getAdjustedClick(e);
            Bgr testColor = new Bgr(activeColor.V0, activeColor.V1, activeColor.V2);
            Bgr bgrEndColor = new Bgr(endColor.V0, endColor.V1, endColor.V2);
            if (swapCorner1.X != -1 && radioSwap.Checked)
            {
                for (int y = topLeft.Y; y < botRight.Y; y++)
                {
                    for (int x = topLeft.X; x < botRight.X; x++)
                    {
                        if (currentImg[y, x].Equals(testColor))
                        {
                            currentImg[y, x] = bgrEndColor;
                        }
                    }
                }
                imageBox1.Image = currentImg;
            }
            swapCorner1 = new Point(-1, -1);
        }

        private void imageBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (imageBox1.FunctionalMode.Equals(mode[1])) return;
            if (mouseDrag)
            {
                Point pt = getAdjustedClick(e);
                if (lastClicked.X < 0) lastClicked = pt;

                if (radioPaint.Checked)
                {
                    if (!overlayCheckBox.Checked)
                    { 
                        CvInvoke.Line(currentImg.Mat, lastClicked, pt, activeColor, trackBar3.Value);
                    }
                    else
                    {
                        CvInvoke.Line(scaledImg.Mat, lastClicked, pt, activeColor, trackBar3.Value);
                    }
                }
                else if (radioFill.Checked)
                {
                    Rectangle ccomp;
                    CvInvoke.FloodFill(currentImg.Mat, null, pt, activeColor, out ccomp, new MCvScalar(20),
                        new MCvScalar(20), Connectivity.FourConnected, FloodFillType.Default);
                }

                if (!overlayCheckBox.Checked)
                {
                    imageBox1.Image = currentImg.Mat.ToImage<Bgr, Byte>();
                }
                else
                {
                    tempImg = scaledImg.Mat.ToImage<Bgr, Byte>();
                    overlayTrackBar_Scroll(null, null);
                }
                lastClicked = pt;
            }
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

            if (overlayCheckBox.Checked)
            {
                x = x / factorX;
                y = y / factorY;
            }

            return new Point(x, y);
        }
        
        private void debugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image<Bgr, byte> testImage = new Image<Bgr, byte>(currentImg.Size);
            for (int y = 0; y < testImage.Height; y++)
            {
                for (int x = 0; x < testImage.Width; x++)
                {
                    testImage[y, x] = new Bgr(255, 0, 255);
                    if (y == 15)
                    {
                        testImage[y, x] = new Bgr(0, 0, 0);
                    }
                }
            }
            imageBox1.Image = testImage;
        }

        private void checkFunctionalMode_CheckedChanged(object sender, EventArgs e)
        {
            if (checkFunctionalMode.Checked)
            {
                enablePan();
            }
            else
            {
                disablePan();
            }
        }

        private void enablePan()
        {
            imageBox1.FunctionalMode = mode[1];
            checkFunctionalMode.Checked = true;
        }

        private void disablePan()
        {
            imageBox1.FunctionalMode = mode[0];
            checkFunctionalMode.Checked = false;
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            Object result = pickFromColorPicker();

            if (result != null)
            {
                activeColor = (MCvScalar)result;
                updateColorBox();
            }
        }

        private void radioPaint_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = false;
            trackBar1.Visible = false;
            label2.Visible = false;
            trackBar2.Visible = false;

            label3.Visible = true;
            label3.Text = "Size: 1";

            trackBar3.Visible = true;
            trackBar3.Minimum = 1;
            trackBar3.Maximum = 10;
            trackBar3.Value = 1;
        }

        private void radioFill_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = false;
            trackBar1.Visible = false;

            label2.Visible = true;
            label2.Text = "loDiff";

            trackBar2.Visible = true;
            trackBar2.Minimum = 0;
            trackBar2.Maximum = 255;
            trackBar2.Value = 20;

            label3.Visible = true;
            label3.Text = "upDiff";

            trackBar3.Visible = true;
            trackBar3.Minimum = 0;
            trackBar3.Maximum = 255;
            trackBar3.Value = 20;
        }

        private void radioSwap_CheckedChanged(object sender, EventArgs e)
        {
            if (!startColorChosen || !endColorChosen)
            {
                radioPaint.Checked = true;
                return;
            }

            label1.Visible = false;
            trackBar1.Visible = false;
            label2.Visible = false;
            trackBar2.Visible = false;
            label3.Visible = false;
            trackBar3.Visible = false;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            if (radioPaint.Checked == true)
            {
                label3.Text = "Size: " + trackBar3.Value;
            }
            else
            {

            }
        }

        private Image<Bgr, Byte> makeColorBox(int width, int height, MCvScalar color)
        {
            Image<Bgr, Byte> i = new Image<Bgr, Byte>(width, height);
            Rectangle ccomp;
            CvInvoke.FloodFill(i, null, new Point(0, 0), color, out ccomp, new MCvScalar(0), new MCvScalar(0));
            return i;
        }

        public void updateColorBox()
        {
            colorBox.Image = makeColorBox(128, 62, activeColor);
        }

        private void buttonEyedropper_Click(object sender, EventArgs e)
        {
            if (!pickingColor)
            {
                pickingColor = true;
                buttonEyedropper.Enabled = false;
            }
            else
            {
                pickingColor = false;
                buttonEyedropper.Enabled = true;
            }
        }

        private Object pickFromColorPicker()
        {
            ColorDialog dialog = new ColorDialog();
            dialog.AllowFullOpen = true;
            dialog.AnyColor = true;
            dialog.SolidColorOnly = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Color c = dialog.Color;
                return new MCvScalar(c.B, c.G, c.R);
            }

            return null;
        }

        private void colorBoxPreset1_Click(object sender, EventArgs e)
        {
            if (colorBoxPreset1.Image == null)
            {
                Object result = pickFromColorPicker();

                if (result != null)
                {
                    preset1 = (MCvScalar)result;
                    colorBoxPreset1.Image = makeColorBox(58, 56, preset1);
                }
            }
            else
            {
                activeColor = preset1;
                updateColorBox();
            }
        }

        private void colorBoxPreset2_Click(object sender, EventArgs e)
        {
            if (colorBoxPreset2.Image == null)
            {
                Object result = pickFromColorPicker();

                if (result != null)
                {
                    preset2 = (MCvScalar)result;
                    colorBoxPreset2.Image = makeColorBox(58, 56, preset2);
                }
            }
            else
            {
                activeColor = preset2;
                updateColorBox();
            }
        }

        private void colorBoxPreset3_Click(object sender, EventArgs e)
        {
            if (colorBoxPreset3.Image == null)
            {
                Object result = pickFromColorPicker();

                if (result != null)
                {
                    preset3 = (MCvScalar)result;
                    colorBoxPreset3.Image = makeColorBox(58, 56, preset3);
                }
            }
            else
            {
                activeColor = preset3;
                updateColorBox();
            }
        }

        private void colorBoxPreset4_Click(object sender, EventArgs e)
        {
            if (colorBoxPreset4.Image == null)
            {
                Object result = pickFromColorPicker();

                if (result != null)
                {
                    preset4 = (MCvScalar)result;
                    colorBoxPreset4.Image = makeColorBox(58, 56, preset4);
                }
            }
            else
            {
                activeColor = preset4;
                updateColorBox();
            }
        }

        private void colorBoxPreset5_Click(object sender, EventArgs e)
        {
            if (colorBoxPreset5.Image == null)
            {
                Object result = pickFromColorPicker();

                if (result != null)
                {
                    preset5 = (MCvScalar)result;
                    colorBoxPreset5.Image = makeColorBox(58, 56, preset5);
                }
            }
            else
            {
                activeColor = preset5;
                updateColorBox();
            }
        }

        private void colorBoxPreset6_Click(object sender, EventArgs e)
        {
            if (colorBoxPreset6.Image == null)
            {
                Object result = pickFromColorPicker();

                if (result != null)
                {
                    preset6 = (MCvScalar)result;
                    colorBoxPreset6.Image = makeColorBox(58, 56, preset6);
                }
            }
            else
            {
                activeColor = preset6;
                updateColorBox();
            }
        }

        private void imageBoxStartColor_Click(object sender, EventArgs e)
        {
            Object result = pickFromColorPicker();

            if (result != null)
            {
                startColor = (MCvScalar)result;
                colorBoxStartColor.Image = makeColorBox(58, 56, startColor);
                startColorChosen = true;
            }
        }

        private void imageBoxEndColor_Click(object sender, EventArgs e)
        {
            Object result = pickFromColorPicker();

            if (result != null)
            {
                endColor = (MCvScalar)result;
                colorBoxEndColor.Image = makeColorBox(58, 56, endColor);
                endColorChosen = true;
            }
        }

        private void checkEditing_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEditing.Checked)
            {
                colorBox.Enabled = true;
                buttonColor.Enabled = true;
                buttonEyedropper.Enabled = true;
                colorBoxPreset1.Enabled = true;
                colorBoxPreset2.Enabled = true;
                colorBoxPreset3.Enabled = true;
                colorBoxPreset4.Enabled = true;
                colorBoxPreset5.Enabled = true;
                colorBoxPreset6.Enabled = true;
                radioPaint.Enabled = true;
                radioFill.Enabled = true;
                radioSwap.Enabled = true;
                radioButton4.Enabled = true;
                colorBoxStartColor.Enabled = true;
                colorBoxEndColor.Enabled = true;
            }
            else
            {
                colorBox.Enabled = false;
                buttonColor.Enabled = false;
                buttonEyedropper.Enabled = false;
                colorBoxPreset1.Enabled = false;
                colorBoxPreset2.Enabled = false;
                colorBoxPreset3.Enabled = false;
                colorBoxPreset4.Enabled = false;
                colorBoxPreset5.Enabled = false;
                colorBoxPreset6.Enabled = false;
                radioPaint.Enabled = false;
                radioFill.Enabled = false;
                radioSwap.Enabled = false;
                radioButton4.Enabled = false;
                colorBoxStartColor.Enabled = false;
                colorBoxEndColor.Enabled = false;
            }
        }
    }
}
