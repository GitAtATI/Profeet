﻿using System;
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
            matCurrentImage = img.Clone();
            imageBox1.Image = matCurrentImage.ToImage<Bgr, Byte>();
            mode = new Emgu.CV.UI.ImageBox.FunctionalModeOption[2] {
                Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum,
                Emgu.CV.UI.ImageBox.FunctionalModeOption.PanAndZoom};
            imageBox1.FunctionalMode = mode[0];
            mouseDrag = false;
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
                activeColor = dialog.Color;
            }
        }

        private void imageBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (imageBox1.FunctionalMode.Equals(mode[1])) return;
            mouseDrag = true;
            prevPt = getAdjustedClick(e);
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
                CvInvoke.Line(matCurrentImage, prevPt, pt, new MCvScalar(activeColor.B, activeColor.G, activeColor.R));
                prevPt = pt;
                imageBox1.Image = matCurrentImage.ToImage<Bgr, Byte>();
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
            int x = (int) (xOffset + (e.X / zoom));
            int y = (int) (yOffset + (e.Y / zoom));
            return new Point(x, y);
        }
    }
}
