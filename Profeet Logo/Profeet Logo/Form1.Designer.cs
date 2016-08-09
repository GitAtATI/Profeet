namespace Profeet
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.originalImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.functionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorReductionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editPixelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edgeDetectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.steppingResizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stitchChecksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorLimitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.floatStitchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stitchSimulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.overlayTrackBar = new System.Windows.Forms.TrackBar();
            this.overlayCheckBox = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioCustom = new System.Windows.Forms.RadioButton();
            this.radioHundred = new System.Windows.Forms.RadioButton();
            this.radioZero = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.overlayTrackBar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.functionsToolStripMenuItem,
            this.stitchChecksToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1396, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.saveToolStripMenuItem1.Text = "Save As";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.originalImageToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // originalImageToolStripMenuItem
            // 
            this.originalImageToolStripMenuItem.Name = "originalImageToolStripMenuItem";
            this.originalImageToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.originalImageToolStripMenuItem.Text = "Original Image";
            this.originalImageToolStripMenuItem.Click += new System.EventHandler(this.originalImageToolStripMenuItem_Click);
            // 
            // functionsToolStripMenuItem
            // 
            this.functionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorReductionToolStripMenuItem,
            this.editPixelsToolStripMenuItem,
            this.edgeDetectionToolStripMenuItem,
            this.resizeToolStripMenuItem,
            this.steppingResizeToolStripMenuItem,
            this.debugToolStripMenuItem});
            this.functionsToolStripMenuItem.Name = "functionsToolStripMenuItem";
            this.functionsToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.functionsToolStripMenuItem.Text = "Functions";
            // 
            // colorReductionToolStripMenuItem
            // 
            this.colorReductionToolStripMenuItem.Name = "colorReductionToolStripMenuItem";
            this.colorReductionToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.colorReductionToolStripMenuItem.Text = "Color Reduction";
            this.colorReductionToolStripMenuItem.Click += new System.EventHandler(this.colorReductionToolStripMenuItem_Click);
            // 
            // editPixelsToolStripMenuItem
            // 
            this.editPixelsToolStripMenuItem.Name = "editPixelsToolStripMenuItem";
            this.editPixelsToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.editPixelsToolStripMenuItem.Text = "Edit Pixels";
            this.editPixelsToolStripMenuItem.Click += new System.EventHandler(this.editPixelsToolStripMenuItem_Click);
            // 
            // edgeDetectionToolStripMenuItem
            // 
            this.edgeDetectionToolStripMenuItem.Name = "edgeDetectionToolStripMenuItem";
            this.edgeDetectionToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.edgeDetectionToolStripMenuItem.Text = "Edge Detection";
            this.edgeDetectionToolStripMenuItem.Click += new System.EventHandler(this.edgeDetectionToolStripMenuItem_Click);
            // 
            // resizeToolStripMenuItem
            // 
            this.resizeToolStripMenuItem.Name = "resizeToolStripMenuItem";
            this.resizeToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.resizeToolStripMenuItem.Text = "Resize";
            this.resizeToolStripMenuItem.Click += new System.EventHandler(this.resizeToolStripMenuItem_Click);
            // 
            // steppingResizeToolStripMenuItem
            // 
            this.steppingResizeToolStripMenuItem.Name = "steppingResizeToolStripMenuItem";
            this.steppingResizeToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.steppingResizeToolStripMenuItem.Text = "Stepping Resize";
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.debugToolStripMenuItem.Text = "Debug";
            this.debugToolStripMenuItem.Click += new System.EventHandler(this.debugToolStripMenuItem_Click);
            // 
            // stitchChecksToolStripMenuItem
            // 
            this.stitchChecksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorLimitToolStripMenuItem,
            this.floatStitchToolStripMenuItem,
            this.stitchSimulationToolStripMenuItem});
            this.stitchChecksToolStripMenuItem.Name = "stitchChecksToolStripMenuItem";
            this.stitchChecksToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.stitchChecksToolStripMenuItem.Text = "Stitch Checks";
            // 
            // colorLimitToolStripMenuItem
            // 
            this.colorLimitToolStripMenuItem.Name = "colorLimitToolStripMenuItem";
            this.colorLimitToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.colorLimitToolStripMenuItem.Text = "Color Limit";
            this.colorLimitToolStripMenuItem.Click += new System.EventHandler(this.colorLimitToolStripMenuItem_Click);
            // 
            // floatStitchToolStripMenuItem
            // 
            this.floatStitchToolStripMenuItem.Name = "floatStitchToolStripMenuItem";
            this.floatStitchToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.floatStitchToolStripMenuItem.Text = "Float Stitch";
            this.floatStitchToolStripMenuItem.Click += new System.EventHandler(this.floatStitchLimitToolStripMenuItem_Click);
            // 
            // stitchSimulationToolStripMenuItem
            // 
            this.stitchSimulationToolStripMenuItem.Name = "stitchSimulationToolStripMenuItem";
            this.stitchSimulationToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.stitchSimulationToolStripMenuItem.Text = "Stitch Simulation";
            this.stitchSimulationToolStripMenuItem.Click += new System.EventHandler(this.stitchSimulationToolStripMenuItem_Click);
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(0, 27);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(1396, 444);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            this.imageBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imageBox1_MouseDown);
            this.imageBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imageBox1_MouseMove);
            this.imageBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imageBox1_MouseUp);
            // 
            // overlayTrackBar
            // 
            this.overlayTrackBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.overlayTrackBar.Enabled = false;
            this.overlayTrackBar.Location = new System.Drawing.Point(238, 0);
            this.overlayTrackBar.Maximum = 100;
            this.overlayTrackBar.Name = "overlayTrackBar";
            this.overlayTrackBar.Size = new System.Drawing.Size(1158, 36);
            this.overlayTrackBar.TabIndex = 4;
            this.overlayTrackBar.Value = 100;
            this.overlayTrackBar.Scroll += new System.EventHandler(this.overlayTrackBar_Scroll);
            // 
            // overlayCheckBox
            // 
            this.overlayCheckBox.AutoSize = true;
            this.overlayCheckBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.overlayCheckBox.Location = new System.Drawing.Point(0, 0);
            this.overlayCheckBox.Name = "overlayCheckBox";
            this.overlayCheckBox.Size = new System.Drawing.Size(62, 36);
            this.overlayCheckBox.TabIndex = 5;
            this.overlayCheckBox.Text = "Overlay";
            this.overlayCheckBox.UseVisualStyleBackColor = true;
            this.overlayCheckBox.CheckedChanged += new System.EventHandler(this.overlayCheckBox_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioCustom);
            this.panel1.Controls.Add(this.radioHundred);
            this.panel1.Controls.Add(this.radioZero);
            this.panel1.Controls.Add(this.overlayCheckBox);
            this.panel1.Controls.Add(this.overlayTrackBar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 477);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1396, 36);
            this.panel1.TabIndex = 4;
            // 
            // radioCustom
            // 
            this.radioCustom.AutoSize = true;
            this.radioCustom.Enabled = false;
            this.radioCustom.Location = new System.Drawing.Point(172, 9);
            this.radioCustom.Name = "radioCustom";
            this.radioCustom.Size = new System.Drawing.Size(60, 17);
            this.radioCustom.TabIndex = 8;
            this.radioCustom.TabStop = true;
            this.radioCustom.Text = "Custom";
            this.radioCustom.UseVisualStyleBackColor = true;
            this.radioCustom.CheckedChanged += new System.EventHandler(this.radioCustom_CheckedChanged);
            // 
            // radioHundred
            // 
            this.radioHundred.AutoSize = true;
            this.radioHundred.Enabled = false;
            this.radioHundred.Location = new System.Drawing.Point(114, 9);
            this.radioHundred.Name = "radioHundred";
            this.radioHundred.Size = new System.Drawing.Size(51, 17);
            this.radioHundred.TabIndex = 7;
            this.radioHundred.TabStop = true;
            this.radioHundred.Text = "100%";
            this.radioHundred.UseVisualStyleBackColor = true;
            this.radioHundred.CheckedChanged += new System.EventHandler(this.radioHundred_CheckedChanged);
            // 
            // radioZero
            // 
            this.radioZero.AutoSize = true;
            this.radioZero.Enabled = false;
            this.radioZero.Location = new System.Drawing.Point(68, 9);
            this.radioZero.Name = "radioZero";
            this.radioZero.Size = new System.Drawing.Size(39, 17);
            this.radioZero.TabIndex = 6;
            this.radioZero.TabStop = true;
            this.radioZero.Text = "0%";
            this.radioZero.UseVisualStyleBackColor = true;
            this.radioZero.CheckedChanged += new System.EventHandler(this.radioZero_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 513);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.overlayTrackBar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem originalImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem functionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorReductionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editPixelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edgeDetectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stitchChecksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorLimitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem floatStitchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stitchSimulationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem steppingResizeToolStripMenuItem;
        private System.Windows.Forms.TrackBar overlayTrackBar;
        private System.Windows.Forms.CheckBox overlayCheckBox;
        private Emgu.CV.UI.ImageBox imageBox1;
        private Emgu.CV.Image<Emgu.CV.Structure.Bgr, System.Byte> originalImg;
        private Emgu.CV.Image<Emgu.CV.Structure.Bgr, System.Byte> tempImg;
        private Emgu.CV.Image<Emgu.CV.Structure.Bgr, System.Byte> currentImg;
        private System.Drawing.Point lastClicked;
        private System.Windows.Forms.Form generalForm;
        private string origImageFile;
        private Emgu.CV.Mat matCurrentImage;
        private Emgu.CV.Mat matTempImage;
        private Emgu.CV.Mat matScaledImg;
        private Profeet_Logo.functionControls modelessForm;
        private System.Windows.Forms.Panel panel1;
        private Profeet_Logo.PixelEditForm editForm;
        private bool mouseDrag;
        public Emgu.CV.UI.ImageBox.FunctionalModeOption[] mode;
        private int factorX;
        private int factorY;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.RadioButton radioCustom;
        private System.Windows.Forms.RadioButton radioHundred;
        private System.Windows.Forms.RadioButton radioZero;
    }
}