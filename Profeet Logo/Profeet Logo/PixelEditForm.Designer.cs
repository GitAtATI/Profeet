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
            this.radioPaint = new System.Windows.Forms.RadioButton();
            this.radioFill = new System.Windows.Forms.RadioButton();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEyedropper = new System.Windows.Forms.Button();
            this.colorBox = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
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
            this.trackBar3.Location = new System.Drawing.Point(98, 180);
            this.trackBar3.Minimum = 1;
            this.trackBar3.Name = "trackBot";
            this.trackBar3.Size = new System.Drawing.Size(74, 45);
            this.trackBar3.TabIndex = 11;
            this.trackBar3.Value = 1;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBot_Scroll);
            // 
            // labelBot
            // 
            this.label3.Location = new System.Drawing.Point(95, 154);
            this.label3.Name = "labelBot";
            this.label3.Size = new System.Drawing.Size(75, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Size: 1";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackMid
            // 
            this.trackBar2.Location = new System.Drawing.Point(98, 106);
            this.trackBar2.Name = "trackMid";
            this.trackBar2.Size = new System.Drawing.Size(74, 45);
            this.trackBar2.TabIndex = 13;
            this.trackBar2.Visible = false;
            this.trackBar2.Scroll += new System.EventHandler(this.trackMid_Scroll);
            // 
            // labelMid
            // 
            this.label2.Location = new System.Drawing.Point(95, 80);
            this.label2.Name = "labelMid";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // trackTop
            // 
            this.trackBar1.Location = new System.Drawing.Point(96, 41);
            this.trackBar1.Name = "trackTop";
            this.trackBar1.Size = new System.Drawing.Size(74, 45);
            this.trackBar1.TabIndex = 15;
            this.trackBar1.Visible = false;
            this.trackBar1.Scroll += new System.EventHandler(this.trackTop_Scroll);
            // 
            // labelTop
            // 
            this.label1.Location = new System.Drawing.Point(93, 12);
            this.label1.Name = "labelTop";
            this.label1.Size = new System.Drawing.Size(75, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "label3";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // buttonEyedropper
            // 
            this.buttonEyedropper.Location = new System.Drawing.Point(12, 70);
            this.buttonEyedropper.Name = "buttonEyedropper";
            this.buttonEyedropper.Size = new System.Drawing.Size(77, 23);
            this.buttonEyedropper.TabIndex = 17;
            this.buttonEyedropper.Text = "Eyedropper";
            this.buttonEyedropper.UseVisualStyleBackColor = true;
            this.buttonEyedropper.Click += new System.EventHandler(this.buttonEyedropper_Click);
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.radioFill);
            this.Controls.Add(this.radioPaint);
            this.Controls.Add(this.colorButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Name = "PixelEditForm";
            this.Text = "Edit Pixels";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Form parent;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button colorButton;
        private Emgu.CV.Structure.MCvScalar activeColor;
        public bool pickingColor;
        private System.Drawing.Point prevPt;
        private System.Windows.Forms.RadioButton radioPaint;
        private System.Windows.Forms.RadioButton radioFill;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEyedropper;
        private Emgu.CV.UI.ImageBox colorBox;
    }
}