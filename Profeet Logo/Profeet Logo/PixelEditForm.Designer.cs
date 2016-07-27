namespace Profeet_Logo
{
    partial class PixelEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.colorButton = new System.Windows.Forms.Button();
            this.imgModeButton = new System.Windows.Forms.Button();
            this.radioPaint = new System.Windows.Forms.RadioButton();
            this.radioFill = new System.Windows.Forms.RadioButton();
            this.trackBot = new System.Windows.Forms.TrackBar();
            this.labelBot = new System.Windows.Forms.Label();
            this.trackMid = new System.Windows.Forms.TrackBar();
            this.labelMid = new System.Windows.Forms.Label();
            this.trackTop = new System.Windows.Forms.TrackBar();
            this.labelTop = new System.Windows.Forms.Label();
            this.buttonEyedropper = new System.Windows.Forms.Button();
            this.colorBox = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackMid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).BeginInit();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(12, 174);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(12, 203);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // colorButton
            // 
            this.colorButton.Location = new System.Drawing.Point(12, 41);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(75, 23);
            this.colorButton.TabIndex = 6;
            this.colorButton.Text = "Color";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // imgModeButton
            // 
            this.imgModeButton.Location = new System.Drawing.Point(12, 145);
            this.imgModeButton.Name = "imgModeButton";
            this.imgModeButton.Size = new System.Drawing.Size(75, 23);
            this.imgModeButton.TabIndex = 7;
            this.imgModeButton.Text = "Mode";
            this.imgModeButton.UseVisualStyleBackColor = true;
            // 
            // radioPaint
            // 
            this.radioPaint.AutoSize = true;
            this.radioPaint.Checked = true;
            this.radioPaint.Cursor = System.Windows.Forms.Cursors.Default;
            this.radioPaint.Location = new System.Drawing.Point(12, 99);
            this.radioPaint.Name = "radioPaint";
            this.radioPaint.Size = new System.Drawing.Size(75, 17);
            this.radioPaint.TabIndex = 9;
            this.radioPaint.TabStop = true;
            this.radioPaint.Text = "Paintbrush";
            this.radioPaint.UseVisualStyleBackColor = true;
            this.radioPaint.CheckedChanged += new System.EventHandler(this.radioPaint_CheckedChanged);
            // 
            // radioFill
            // 
            this.radioFill.AutoSize = true;
            this.radioFill.Location = new System.Drawing.Point(12, 122);
            this.radioFill.Name = "radioFill";
            this.radioFill.Size = new System.Drawing.Size(61, 17);
            this.radioFill.TabIndex = 10;
            this.radioFill.Text = "Fill Tool";
            this.radioFill.UseVisualStyleBackColor = true;
            this.radioFill.CheckedChanged += new System.EventHandler(this.radioFill_CheckedChanged);
            // 
            // trackBot
            // 
            this.trackBot.Location = new System.Drawing.Point(98, 180);
            this.trackBot.Minimum = 1;
            this.trackBot.Name = "trackBot";
            this.trackBot.Size = new System.Drawing.Size(74, 45);
            this.trackBot.TabIndex = 11;
            this.trackBot.Value = 1;
            this.trackBot.Scroll += new System.EventHandler(this.trackBot_Scroll);
            // 
            // labelBot
            // 
            this.labelBot.Location = new System.Drawing.Point(95, 154);
            this.labelBot.Name = "labelBot";
            this.labelBot.Size = new System.Drawing.Size(75, 23);
            this.labelBot.TabIndex = 12;
            this.labelBot.Text = "Size: 1";
            this.labelBot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackMid
            // 
            this.trackMid.Location = new System.Drawing.Point(98, 106);
            this.trackMid.Name = "trackMid";
            this.trackMid.Size = new System.Drawing.Size(74, 45);
            this.trackMid.TabIndex = 13;
            this.trackMid.Visible = false;
            this.trackMid.Scroll += new System.EventHandler(this.trackMid_Scroll);
            // 
            // labelMid
            // 
            this.labelMid.Location = new System.Drawing.Point(95, 80);
            this.labelMid.Name = "labelMid";
            this.labelMid.Size = new System.Drawing.Size(75, 23);
            this.labelMid.TabIndex = 14;
            this.labelMid.Text = "label2";
            this.labelMid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMid.Visible = false;
            // 
            // trackTop
            // 
            this.trackTop.Location = new System.Drawing.Point(96, 41);
            this.trackTop.Name = "trackTop";
            this.trackTop.Size = new System.Drawing.Size(74, 45);
            this.trackTop.TabIndex = 15;
            this.trackTop.Visible = false;
            this.trackTop.Scroll += new System.EventHandler(this.trackTop_Scroll);
            // 
            // labelTop
            // 
            this.labelTop.Location = new System.Drawing.Point(93, 12);
            this.labelTop.Name = "labelTop";
            this.labelTop.Size = new System.Drawing.Size(75, 23);
            this.labelTop.TabIndex = 16;
            this.labelTop.Text = "label3";
            this.labelTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTop.Visible = false;
            // 
            // buttonEyedropper
            // 
            this.buttonEyedropper.Location = new System.Drawing.Point(12, 70);
            this.buttonEyedropper.Name = "buttonEyedropper";
            this.buttonEyedropper.Size = new System.Drawing.Size(77, 23);
            this.buttonEyedropper.TabIndex = 17;
            this.buttonEyedropper.Text = "Eyedropper";
            this.buttonEyedropper.UseVisualStyleBackColor = true;
            // 
            // colorBox
            // 
            this.colorBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.colorBox.Location = new System.Drawing.Point(12, 12);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(75, 23);
            this.colorBox.TabIndex = 18;
            this.colorBox.TabStop = false;
            // 
            // PixelEditForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(178, 236);
            this.ControlBox = false;
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.buttonEyedropper);
            this.Controls.Add(this.labelTop);
            this.Controls.Add(this.trackTop);
            this.Controls.Add(this.labelMid);
            this.Controls.Add(this.trackMid);
            this.Controls.Add(this.labelBot);
            this.Controls.Add(this.trackBot);
            this.Controls.Add(this.radioFill);
            this.Controls.Add(this.radioPaint);
            this.Controls.Add(this.imgModeButton);
            this.Controls.Add(this.colorButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Name = "PixelEditForm";
            this.Text = "Edit Pixels";
            ((System.ComponentModel.ISupportInitialize)(this.trackBot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackMid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Emgu.CV.UI.ImageBox.FunctionalModeOption currentMode;
        private Emgu.CV.UI.ImageBox.FunctionalModeOption[] mode;
        private System.Windows.Forms.Form parent;
        private Emgu.CV.Mat matCurrentImage;
        public Emgu.CV.Mat matOutputImage;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button colorButton;
        private Emgu.CV.Structure.MCvScalar activeColor;
        private bool mouseDrag;
        private bool pickingColor;
        private System.Drawing.Point prevPt;
        private System.Windows.Forms.Button imgModeButton;
        private System.Windows.Forms.RadioButton radioPaint;
        private System.Windows.Forms.RadioButton radioFill;
        private System.Windows.Forms.TrackBar trackBot;
        private System.Windows.Forms.Label labelBot;
        private System.Windows.Forms.TrackBar trackMid;
        private System.Windows.Forms.Label labelMid;
        private System.Windows.Forms.TrackBar trackTop;
        private System.Windows.Forms.Label labelTop;
        private System.Windows.Forms.Button buttonEyedropper;
        private Emgu.CV.UI.ImageBox colorBox;
    }
}