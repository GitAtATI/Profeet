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
        public PixelEditForm(Form parent)
        {
            this.parent = parent;
            InitializeComponent();
            updateColorBox();
            mouseDrag = false;
            pickingColor = false;
            prevPt = new Point(-1, -1);
            mode = new Emgu.CV.UI.ImageBox.FunctionalModeOption[2] {
                Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum,
                Emgu.CV.UI.ImageBox.FunctionalModeOption.PanAndZoom};
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

        //Alternates between no zoom/pan (paint mode) and zoom/pan mode
        private void imgModeButton_Click(object sender, EventArgs e)
        {
            if (currentMode.Equals(mode[0]))
                currentMode = mode[1];
            else currentMode = mode[0];
        }

        public void updateColorBox()
        {
            Image<Bgr, Byte> i = new Image<Bgr, Byte>(75, 23);
            Rectangle ccomp;
            CvInvoke.FloodFill(i, null, new Point(0, 0), activeColor, out ccomp, new MCvScalar(0), new MCvScalar(0));
            colorBox.Image = i;
        }

        public MCvScalar getActiveColor()
        {
            return activeColor;
        }

        public void setActiveColor(MCvScalar newColor)
        {
            activeColor = newColor;
        }

        public bool getPaintChecked()
        {
            return radioPaint.Checked;
        }

        public int getTopVal()
        {
            return trackTop.Value;
        }

        public int getMidVal()
        {
            return trackMid.Value;
        }

        public int getBotVal()
        {
            return trackBot.Value;
        }

        public Emgu.CV.UI.ImageBox.FunctionalModeOption getMode()
        {
            return currentMode;
        }
    }
}
