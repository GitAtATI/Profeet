﻿using System;

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
            this.edgeDetectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.steppingResizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stitchChecksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorLimitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.floatStitchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stitchSimulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelImage = new System.Windows.Forms.Panel();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.panelPaint = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.checkEditing = new System.Windows.Forms.CheckBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioFill = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.colorBoxPreset6 = new Emgu.CV.UI.ImageBox();
            this.colorBoxPreset5 = new Emgu.CV.UI.ImageBox();
            this.buttonEyedropper = new System.Windows.Forms.Button();
            this.colorBox = new Emgu.CV.UI.ImageBox();
            this.buttonColor = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.colorBoxPreset2 = new Emgu.CV.UI.ImageBox();
            this.colorBoxPreset1 = new Emgu.CV.UI.ImageBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.colorBoxPreset4 = new Emgu.CV.UI.ImageBox();
            this.colorBoxPreset3 = new Emgu.CV.UI.ImageBox();
            this.radioPaint = new System.Windows.Forms.RadioButton();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkFunctionalMode = new System.Windows.Forms.CheckBox();
            this.panelOverlay = new System.Windows.Forms.Panel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.radioCustom = new System.Windows.Forms.RadioButton();
            this.radioHundred = new System.Windows.Forms.RadioButton();
            this.overlayCheckBox = new System.Windows.Forms.CheckBox();
            this.radioZero = new System.Windows.Forms.RadioButton();
            this.overlayTrackBar = new System.Windows.Forms.TrackBar();
            this.menuStrip1.SuspendLayout();
            this.panelImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.panelPaint.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorBoxPreset6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBoxPreset5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorBoxPreset2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBoxPreset1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorBoxPreset4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBoxPreset3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            this.panelOverlay.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.overlayTrackBar)).BeginInit();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(984, 25);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
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
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 19);
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
            this.edgeDetectionToolStripMenuItem,
            this.resizeToolStripMenuItem,
            this.steppingResizeToolStripMenuItem,
            this.debugToolStripMenuItem});
            this.functionsToolStripMenuItem.Name = "functionsToolStripMenuItem";
            this.functionsToolStripMenuItem.Size = new System.Drawing.Size(71, 19);
            this.functionsToolStripMenuItem.Text = "Functions";
            // 
            // colorReductionToolStripMenuItem
            // 
            this.colorReductionToolStripMenuItem.Name = "colorReductionToolStripMenuItem";
            this.colorReductionToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.colorReductionToolStripMenuItem.Text = "Color Reduction";
            this.colorReductionToolStripMenuItem.Click += new System.EventHandler(this.colorReductionToolStripMenuItem_Click);
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
            this.steppingResizeToolStripMenuItem.Click += new System.EventHandler(this.steppingResizeToolStripMenuItem_Click);
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
            this.stitchChecksToolStripMenuItem.Size = new System.Drawing.Size(90, 19);
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
            // panelImage
            // 
            this.panelImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelImage.Controls.Add(this.imageBox1);
            this.panelImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelImage.Location = new System.Drawing.Point(0, 25);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(984, 686);
            this.panelImage.TabIndex = 1;
            // 
            // imageBox1
            // 
            this.imageBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox1.Location = new System.Drawing.Point(0, 0);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(980, 682);
            this.imageBox1.TabIndex = 0;
            this.imageBox1.TabStop = false;
            this.imageBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imageBox1_MouseDown);
            this.imageBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imageBox1_MouseMove);
            this.imageBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imageBox1_MouseUp);
            // 
            // panelPaint
            // 
            this.panelPaint.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPaint.Controls.Add(this.tableLayoutPanel1);
            this.panelPaint.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelPaint.Location = new System.Drawing.Point(711, 25);
            this.panelPaint.Name = "panelPaint";
            this.panelPaint.Size = new System.Drawing.Size(273, 686);
            this.panelPaint.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.checkEditing, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.radioButton4, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.radioButton3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.radioFill, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonEyedropper, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.colorBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonColor, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.radioPaint, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.trackBar1, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.trackBar2, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.trackBar3, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.checkFunctionalMode, 0, 9);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(269, 682);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // checkEditing
            // 
            this.checkEditing.AutoSize = true;
            this.checkEditing.Location = new System.Drawing.Point(137, 615);
            this.checkEditing.Name = "checkEditing";
            this.checkEditing.Size = new System.Drawing.Size(100, 24);
            this.checkEditing.TabIndex = 19;
            this.checkEditing.Text = "Edit Pixels";
            this.checkEditing.UseVisualStyleBackColor = true;
            this.checkEditing.CheckedChanged += new System.EventHandler(this.checkEditing_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton4.Enabled = false;
            this.radioButton4.Location = new System.Drawing.Point(137, 275);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(129, 62);
            this.radioButton4.TabIndex = 10;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton3.Enabled = false;
            this.radioButton3.Location = new System.Drawing.Point(3, 275);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(128, 62);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioFill
            // 
            this.radioFill.AutoSize = true;
            this.radioFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioFill.Enabled = false;
            this.radioFill.Location = new System.Drawing.Point(137, 207);
            this.radioFill.Name = "radioFill";
            this.radioFill.Size = new System.Drawing.Size(129, 62);
            this.radioFill.TabIndex = 8;
            this.radioFill.TabStop = true;
            this.radioFill.Text = "Fill Tool";
            this.radioFill.UseVisualStyleBackColor = true;
            this.radioFill.CheckedChanged += new System.EventHandler(this.radioFill_CheckedChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.colorBoxPreset6, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.colorBoxPreset5, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(137, 139);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(129, 62);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // colorBoxPreset6
            // 
            this.colorBoxPreset6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorBoxPreset6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorBoxPreset6.Enabled = false;
            this.colorBoxPreset6.Location = new System.Drawing.Point(67, 3);
            this.colorBoxPreset6.Name = "colorBoxPreset6";
            this.colorBoxPreset6.Size = new System.Drawing.Size(59, 56);
            this.colorBoxPreset6.TabIndex = 3;
            this.colorBoxPreset6.TabStop = false;
            this.colorBoxPreset6.Click += new System.EventHandler(this.colorBoxPreset6_Click);
            // 
            // colorBoxPreset5
            // 
            this.colorBoxPreset5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorBoxPreset5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorBoxPreset5.Enabled = false;
            this.colorBoxPreset5.Location = new System.Drawing.Point(3, 3);
            this.colorBoxPreset5.Name = "colorBoxPreset5";
            this.colorBoxPreset5.Size = new System.Drawing.Size(58, 56);
            this.colorBoxPreset5.TabIndex = 2;
            this.colorBoxPreset5.TabStop = false;
            this.colorBoxPreset5.Click += new System.EventHandler(this.colorBoxPreset5_Click);
            // 
            // buttonEyedropper
            // 
            this.buttonEyedropper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEyedropper.Enabled = false;
            this.buttonEyedropper.Location = new System.Drawing.Point(3, 139);
            this.buttonEyedropper.Name = "buttonEyedropper";
            this.buttonEyedropper.Size = new System.Drawing.Size(128, 62);
            this.buttonEyedropper.TabIndex = 5;
            this.buttonEyedropper.Text = "Eyedropper";
            this.buttonEyedropper.UseVisualStyleBackColor = true;
            this.buttonEyedropper.Click += new System.EventHandler(this.buttonEyedropper_Click);
            // 
            // colorBox
            // 
            this.colorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorBox.Enabled = false;
            this.colorBox.Location = new System.Drawing.Point(3, 3);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(128, 62);
            this.colorBox.TabIndex = 1;
            this.colorBox.TabStop = false;
            // 
            // buttonColor
            // 
            this.buttonColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonColor.Enabled = false;
            this.buttonColor.Location = new System.Drawing.Point(3, 71);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(128, 62);
            this.buttonColor.TabIndex = 2;
            this.buttonColor.Text = "Color";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.colorBoxPreset2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.colorBoxPreset1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(137, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(129, 62);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // colorBoxPreset2
            // 
            this.colorBoxPreset2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorBoxPreset2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorBoxPreset2.Enabled = false;
            this.colorBoxPreset2.Location = new System.Drawing.Point(67, 3);
            this.colorBoxPreset2.Name = "colorBoxPreset2";
            this.colorBoxPreset2.Size = new System.Drawing.Size(59, 56);
            this.colorBoxPreset2.TabIndex = 3;
            this.colorBoxPreset2.TabStop = false;
            this.colorBoxPreset2.Click += new System.EventHandler(this.colorBoxPreset2_Click);
            // 
            // colorBoxPreset1
            // 
            this.colorBoxPreset1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorBoxPreset1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorBoxPreset1.Enabled = false;
            this.colorBoxPreset1.Location = new System.Drawing.Point(3, 3);
            this.colorBoxPreset1.Name = "colorBoxPreset1";
            this.colorBoxPreset1.Size = new System.Drawing.Size(58, 56);
            this.colorBoxPreset1.TabIndex = 2;
            this.colorBoxPreset1.TabStop = false;
            this.colorBoxPreset1.Click += new System.EventHandler(this.colorBoxPreset1_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.colorBoxPreset4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.colorBoxPreset3, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(137, 71);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(129, 62);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // colorBoxPreset4
            // 
            this.colorBoxPreset4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorBoxPreset4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorBoxPreset4.Enabled = false;
            this.colorBoxPreset4.Location = new System.Drawing.Point(67, 3);
            this.colorBoxPreset4.Name = "colorBoxPreset4";
            this.colorBoxPreset4.Size = new System.Drawing.Size(59, 56);
            this.colorBoxPreset4.TabIndex = 3;
            this.colorBoxPreset4.TabStop = false;
            this.colorBoxPreset4.Click += new System.EventHandler(this.colorBoxPreset4_Click);
            // 
            // colorBoxPreset3
            // 
            this.colorBoxPreset3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorBoxPreset3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorBoxPreset3.Enabled = false;
            this.colorBoxPreset3.Location = new System.Drawing.Point(3, 3);
            this.colorBoxPreset3.Name = "colorBoxPreset3";
            this.colorBoxPreset3.Size = new System.Drawing.Size(58, 56);
            this.colorBoxPreset3.TabIndex = 2;
            this.colorBoxPreset3.TabStop = false;
            this.colorBoxPreset3.Click += new System.EventHandler(this.colorBoxPreset3_Click);
            // 
            // radioPaint
            // 
            this.radioPaint.AutoSize = true;
            this.radioPaint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioPaint.Enabled = false;
            this.radioPaint.Location = new System.Drawing.Point(3, 207);
            this.radioPaint.Name = "radioPaint";
            this.radioPaint.Size = new System.Drawing.Size(128, 62);
            this.radioPaint.TabIndex = 7;
            this.radioPaint.TabStop = true;
            this.radioPaint.Text = "Paintbrush";
            this.radioPaint.UseVisualStyleBackColor = true;
            this.radioPaint.CheckedChanged += new System.EventHandler(this.radioPaint_CheckedChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar1.Location = new System.Drawing.Point(137, 411);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(129, 62);
            this.trackBar1.TabIndex = 12;
            this.trackBar1.Visible = false;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar2.Location = new System.Drawing.Point(137, 479);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(129, 62);
            this.trackBar2.TabIndex = 13;
            this.trackBar2.Visible = false;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBar3
            // 
            this.trackBar3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar3.Location = new System.Drawing.Point(137, 547);
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(129, 62);
            this.trackBar3.TabIndex = 14;
            this.trackBar3.Visible = false;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 408);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(128, 68);
            this.label1.TabIndex = 15;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 476);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 68);
            this.label2.TabIndex = 16;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 544);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 68);
            this.label3.TabIndex = 17;
            this.label3.Text = "label3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Visible = false;
            // 
            // checkFunctionalMode
            // 
            this.checkFunctionalMode.AutoSize = true;
            this.checkFunctionalMode.Checked = true;
            this.checkFunctionalMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkFunctionalMode.Location = new System.Drawing.Point(3, 615);
            this.checkFunctionalMode.Name = "checkFunctionalMode";
            this.checkFunctionalMode.Size = new System.Drawing.Size(105, 24);
            this.checkFunctionalMode.TabIndex = 18;
            this.checkFunctionalMode.Text = "Pan & Zoom";
            this.checkFunctionalMode.UseVisualStyleBackColor = true;
            this.checkFunctionalMode.CheckedChanged += new System.EventHandler(this.checkFunctionalMode_CheckedChanged);
            // 
            // panelOverlay
            // 
            this.panelOverlay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelOverlay.Controls.Add(this.tableLayoutPanel5);
            this.panelOverlay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelOverlay.Location = new System.Drawing.Point(0, 666);
            this.panelOverlay.Name = "panelOverlay";
            this.panelOverlay.Size = new System.Drawing.Size(711, 45);
            this.panelOverlay.TabIndex = 3;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.61669F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.38331F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.overlayTrackBar, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(707, 41);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 4;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.tableLayoutPanel6.Controls.Add(this.radioCustom, 3, 0);
            this.tableLayoutPanel6.Controls.Add(this.radioHundred, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.overlayCheckBox, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.radioZero, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(366, 35);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // radioCustom
            // 
            this.radioCustom.AutoSize = true;
            this.radioCustom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioCustom.Enabled = false;
            this.radioCustom.Location = new System.Drawing.Point(276, 3);
            this.radioCustom.Name = "radioCustom";
            this.radioCustom.Size = new System.Drawing.Size(87, 29);
            this.radioCustom.TabIndex = 3;
            this.radioCustom.TabStop = true;
            this.radioCustom.Text = "Custom";
            this.radioCustom.UseVisualStyleBackColor = true;
            this.radioCustom.CheckedChanged += new System.EventHandler(this.radioCustom_CheckedChanged);
            // 
            // radioHundred
            // 
            this.radioHundred.AutoSize = true;
            this.radioHundred.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioHundred.Enabled = false;
            this.radioHundred.Location = new System.Drawing.Point(185, 3);
            this.radioHundred.Name = "radioHundred";
            this.radioHundred.Size = new System.Drawing.Size(85, 29);
            this.radioHundred.TabIndex = 2;
            this.radioHundred.TabStop = true;
            this.radioHundred.Text = "100%";
            this.radioHundred.UseVisualStyleBackColor = true;
            this.radioHundred.CheckedChanged += new System.EventHandler(this.radioHundred_CheckedChanged);
            // 
            // overlayCheckBox
            // 
            this.overlayCheckBox.AutoSize = true;
            this.overlayCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overlayCheckBox.Enabled = false;
            this.overlayCheckBox.Location = new System.Drawing.Point(3, 3);
            this.overlayCheckBox.Name = "overlayCheckBox";
            this.overlayCheckBox.Size = new System.Drawing.Size(85, 29);
            this.overlayCheckBox.TabIndex = 0;
            this.overlayCheckBox.Text = "Overlay";
            this.overlayCheckBox.UseVisualStyleBackColor = true;
            this.overlayCheckBox.CheckedChanged += new System.EventHandler(this.overlayCheckBox_CheckedChanged);
            // 
            // radioZero
            // 
            this.radioZero.AutoSize = true;
            this.radioZero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioZero.Enabled = false;
            this.radioZero.Location = new System.Drawing.Point(94, 3);
            this.radioZero.Name = "radioZero";
            this.radioZero.Size = new System.Drawing.Size(85, 29);
            this.radioZero.TabIndex = 1;
            this.radioZero.TabStop = true;
            this.radioZero.Text = "0%";
            this.radioZero.UseVisualStyleBackColor = true;
            this.radioZero.CheckedChanged += new System.EventHandler(this.radioZero_CheckedChanged);
            // 
            // overlayTrackBar
            // 
            this.overlayTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overlayTrackBar.Enabled = false;
            this.overlayTrackBar.Location = new System.Drawing.Point(375, 3);
            this.overlayTrackBar.Maximum = 100;
            this.overlayTrackBar.Name = "overlayTrackBar";
            this.overlayTrackBar.Size = new System.Drawing.Size(329, 35);
            this.overlayTrackBar.TabIndex = 1;
            this.overlayTrackBar.TickFrequency = 10;
            this.overlayTrackBar.Scroll += new System.EventHandler(this.overlayTrackBar_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 711);
            this.Controls.Add(this.panelOverlay);
            this.Controls.Add(this.panelPaint);
            this.Controls.Add(this.panelImage);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.panelPaint.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.colorBoxPreset6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBoxPreset5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.colorBoxPreset2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBoxPreset1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.colorBoxPreset4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBoxPreset3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            this.panelOverlay.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.overlayTrackBar)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem edgeDetectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stitchChecksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorLimitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem floatStitchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stitchSimulationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem steppingResizeToolStripMenuItem;
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
        private bool mouseDrag;
        public Emgu.CV.UI.ImageBox.FunctionalModeOption[] mode;
        private int factorX;
        private int factorY;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.Panel panelImage;
        private System.Windows.Forms.Panel panelPaint;
        private System.Windows.Forms.Panel panelOverlay;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioFill;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private Emgu.CV.UI.ImageBox colorBoxPreset6;
        private Emgu.CV.UI.ImageBox colorBoxPreset5;
        private System.Windows.Forms.Button buttonEyedropper;
        private Emgu.CV.UI.ImageBox colorBox;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Emgu.CV.UI.ImageBox colorBoxPreset2;
        private Emgu.CV.UI.ImageBox colorBoxPreset1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Emgu.CV.UI.ImageBox colorBoxPreset4;
        private Emgu.CV.UI.ImageBox colorBoxPreset3;
        private System.Windows.Forms.RadioButton radioPaint;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.RadioButton radioCustom;
        private System.Windows.Forms.RadioButton radioHundred;
        private System.Windows.Forms.CheckBox overlayCheckBox;
        private System.Windows.Forms.RadioButton radioZero;
        private System.Windows.Forms.TrackBar overlayTrackBar;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkFunctionalMode;
        private Emgu.CV.Structure.MCvScalar activeColor;
        private Emgu.CV.Structure.MCvScalar preset1;
        private Emgu.CV.Structure.MCvScalar preset2;
        private Emgu.CV.Structure.MCvScalar preset3;
        private Emgu.CV.Structure.MCvScalar preset4;
        private Emgu.CV.Structure.MCvScalar preset5;
        private Emgu.CV.Structure.MCvScalar preset6;
        public bool pickingColor;
        private System.Windows.Forms.CheckBox checkEditing;
    }
}