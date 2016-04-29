namespace PineLineProject
{
    partial class PineLine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PineLine));
            this.panelLine = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lbMax = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnSink = new System.Windows.Forms.Button();
            this.btnAdjustSpliter = new System.Windows.Forms.Button();
            this.btnSpliter = new System.Windows.Forms.Button();
            this.btnMerger = new System.Windows.Forms.Button();
            this.btnPump = new System.Windows.Forms.Button();
            this.panelLineLeft = new System.Windows.Forms.Panel();
            this.panelDrawing = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.panelRightFill = new System.Windows.Forms.Panel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panelLeft.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panelRightFill.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLine
            // 
            this.panelLine.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLine.Location = new System.Drawing.Point(0, 88);
            this.panelLine.Name = "panelLine";
            this.panelLine.Size = new System.Drawing.Size(586, 3);
            this.panelLine.TabIndex = 1;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panelLeft.Controls.Add(this.groupBox2);
            this.panelLeft.Controls.Add(this.groupBox1);
            this.panelLeft.Controls.Add(this.button1);
            this.panelLeft.Controls.Add(this.btnLine);
            this.panelLeft.Controls.Add(this.btnSink);
            this.panelLeft.Controls.Add(this.btnAdjustSpliter);
            this.panelLeft.Controls.Add(this.btnSpliter);
            this.panelLeft.Controls.Add(this.btnMerger);
            this.panelLeft.Controls.Add(this.btnPump);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(135, 506);
            this.panelLeft.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDown3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.numericUpDown4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(3, 409);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(126, 85);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adjustable Spliter ";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Enabled = false;
            this.numericUpDown3.Location = new System.Drawing.Point(60, 52);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(55, 20);
            this.numericUpDown3.TabIndex = 23;
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Lower:";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Enabled = false;
            this.numericUpDown4.Location = new System.Drawing.Point(60, 26);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(55, 20);
            this.numericUpDown4.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Upper:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.lbMax);
            this.groupBox1.Location = new System.Drawing.Point(3, 318);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(126, 85);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Pump Setting";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Enabled = false;
            this.numericUpDown2.Location = new System.Drawing.Point(60, 52);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(55, 20);
            this.numericUpDown2.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Current:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Location = new System.Drawing.Point(60, 26);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(55, 20);
            this.numericUpDown1.TabIndex = 21;
            // 
            // lbMax
            // 
            this.lbMax.AutoSize = true;
            this.lbMax.Location = new System.Drawing.Point(7, 29);
            this.lbMax.Name = "lbMax";
            this.lbMax.Size = new System.Drawing.Size(30, 13);
            this.lbMax.TabIndex = 20;
            this.lbMax.Text = "Max:";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(21, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 31);
            this.button1.TabIndex = 19;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip.SetToolTip(this.button1, "Delete Pipeline / component");
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnLine
            // 
            this.btnLine.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLine.FlatAppearance.BorderSize = 0;
            this.btnLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLine.Image = ((System.Drawing.Image)(resources.GetObject("btnLine.Image")));
            this.btnLine.Location = new System.Drawing.Point(21, 235);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(92, 40);
            this.btnLine.TabIndex = 18;
            this.btnLine.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip.SetToolTip(this.btnLine, "Pineline");
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnSink
            // 
            this.btnSink.AllowDrop = true;
            this.btnSink.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSink.FlatAppearance.BorderSize = 0;
            this.btnSink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSink.Image = ((System.Drawing.Image)(resources.GetObject("btnSink.Image")));
            this.btnSink.Location = new System.Drawing.Point(21, 189);
            this.btnSink.Name = "btnSink";
            this.btnSink.Size = new System.Drawing.Size(92, 40);
            this.btnSink.TabIndex = 18;
            this.btnSink.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip.SetToolTip(this.btnSink, "Sink");
            this.btnSink.UseVisualStyleBackColor = true;
            this.btnSink.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSink_MouseDown);
            // 
            // btnAdjustSpliter
            // 
            this.btnAdjustSpliter.AllowDrop = true;
            this.btnAdjustSpliter.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdjustSpliter.FlatAppearance.BorderSize = 0;
            this.btnAdjustSpliter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdjustSpliter.Image = ((System.Drawing.Image)(resources.GetObject("btnAdjustSpliter.Image")));
            this.btnAdjustSpliter.Location = new System.Drawing.Point(21, 143);
            this.btnAdjustSpliter.Name = "btnAdjustSpliter";
            this.btnAdjustSpliter.Size = new System.Drawing.Size(92, 40);
            this.btnAdjustSpliter.TabIndex = 18;
            this.btnAdjustSpliter.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip.SetToolTip(this.btnAdjustSpliter, "Adjustable spliter");
            this.btnAdjustSpliter.UseVisualStyleBackColor = true;
            this.btnAdjustSpliter.Click += new System.EventHandler(this.btnAdjustSpliter_Click);
            this.btnAdjustSpliter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAdjustSpliter_MouseDown);
            // 
            // btnSpliter
            // 
            this.btnSpliter.AllowDrop = true;
            this.btnSpliter.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSpliter.FlatAppearance.BorderSize = 0;
            this.btnSpliter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpliter.Image = ((System.Drawing.Image)(resources.GetObject("btnSpliter.Image")));
            this.btnSpliter.Location = new System.Drawing.Point(21, 97);
            this.btnSpliter.Name = "btnSpliter";
            this.btnSpliter.Size = new System.Drawing.Size(92, 40);
            this.btnSpliter.TabIndex = 18;
            this.btnSpliter.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip.SetToolTip(this.btnSpliter, "Spliter");
            this.btnSpliter.UseVisualStyleBackColor = true;
            this.btnSpliter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSpliter_MouseDown);
            // 
            // btnMerger
            // 
            this.btnMerger.AllowDrop = true;
            this.btnMerger.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMerger.FlatAppearance.BorderSize = 0;
            this.btnMerger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMerger.Image = ((System.Drawing.Image)(resources.GetObject("btnMerger.Image")));
            this.btnMerger.Location = new System.Drawing.Point(21, 54);
            this.btnMerger.Name = "btnMerger";
            this.btnMerger.Size = new System.Drawing.Size(92, 37);
            this.btnMerger.TabIndex = 18;
            this.btnMerger.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip.SetToolTip(this.btnMerger, "Merger");
            this.btnMerger.UseVisualStyleBackColor = true;
            this.btnMerger.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMerger_MouseDown);
            // 
            // btnPump
            // 
            this.btnPump.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPump.FlatAppearance.BorderSize = 0;
            this.btnPump.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPump.Image = ((System.Drawing.Image)(resources.GetObject("btnPump.Image")));
            this.btnPump.Location = new System.Drawing.Point(21, 12);
            this.btnPump.Name = "btnPump";
            this.btnPump.Size = new System.Drawing.Size(92, 36);
            this.btnPump.TabIndex = 18;
            this.btnPump.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip.SetToolTip(this.btnPump, "Pump");
            this.btnPump.UseVisualStyleBackColor = true;
            this.btnPump.Click += new System.EventHandler(this.btnPump_Click);
            this.btnPump.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnPump_MouseDown);
            // 
            // panelLineLeft
            // 
            this.panelLineLeft.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelLineLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLineLeft.Location = new System.Drawing.Point(135, 0);
            this.panelLineLeft.Name = "panelLineLeft";
            this.panelLineLeft.Size = new System.Drawing.Size(3, 506);
            this.panelLineLeft.TabIndex = 3;
            // 
            // panelDrawing
            // 
            this.panelDrawing.AllowDrop = true;
            this.panelDrawing.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelDrawing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDrawing.Location = new System.Drawing.Point(0, 0);
            this.panelDrawing.Name = "panelDrawing";
            this.panelDrawing.Size = new System.Drawing.Size(586, 506);
            this.panelDrawing.TabIndex = 4;
            this.panelDrawing.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelDrawing_DragDrop);
            this.panelDrawing.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelDrawing_DragEnter);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panelTop.Controls.Add(this.panelLine);
            this.panelTop.Controls.Add(this.btnExit);
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Controls.Add(this.btnSaveAs);
            this.panelTop.Controls.Add(this.btnSave);
            this.panelTop.Controls.Add(this.btnNew);
            this.panelTop.Controls.Add(this.btnOpen);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(586, 91);
            this.panelTop.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(517, 18);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(57, 52);
            this.btnExit.TabIndex = 18;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip.SetToolTip(this.btnExit, "Exit application");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(454, 18);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(57, 52);
            this.btnClose.TabIndex = 18;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip.SetToolTip(this.btnClose, "Close current drawing network");
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveAs.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSaveAs.FlatAppearance.BorderSize = 0;
            this.btnSaveAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAs.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveAs.Image")));
            this.btnSaveAs.Location = new System.Drawing.Point(391, 18);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(57, 52);
            this.btnSaveAs.TabIndex = 18;
            this.btnSaveAs.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip.SetToolTip(this.btnSaveAs, "Save as ");
            this.btnSaveAs.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(331, 18);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(54, 52);
            this.btnSave.TabIndex = 18;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip.SetToolTip(this.btnSave, "Save drawing network");
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.Location = new System.Drawing.Point(209, 18);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(54, 52);
            this.btnNew.TabIndex = 18;
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip.SetToolTip(this.btnNew, "New drawing network");
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOpen.FlatAppearance.BorderSize = 0;
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
            this.btnOpen.Location = new System.Drawing.Point(269, 18);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(56, 52);
            this.btnOpen.TabIndex = 18;
            this.btnOpen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip.SetToolTip(this.btnOpen, "Open drawing network form file");
            this.btnOpen.UseVisualStyleBackColor = true;
            // 
            // panelRightFill
            // 
            this.panelRightFill.Controls.Add(this.panelTop);
            this.panelRightFill.Controls.Add(this.panelDrawing);
            this.panelRightFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRightFill.Location = new System.Drawing.Point(135, 0);
            this.panelRightFill.Name = "panelRightFill";
            this.panelRightFill.Size = new System.Drawing.Size(586, 506);
            this.panelRightFill.TabIndex = 5;
            // 
            // PineLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(721, 506);
            this.ControlBox = false;
            this.Controls.Add(this.panelLineLeft);
            this.Controls.Add(this.panelRightFill);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "PineLine";
            this.Text = "PineLine";
            this.Load += new System.EventHandler(this.PineLine_Load);
            this.panelLeft.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelRightFill.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLine;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelLineLeft;
        private System.Windows.Forms.Panel panelDrawing;
        private System.Windows.Forms.Button btnPump;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Panel panelRightFill;
        private System.Windows.Forms.Button btnSink;
        private System.Windows.Forms.Button btnAdjustSpliter;
        private System.Windows.Forms.Button btnSpliter;
        private System.Windows.Forms.Button btnMerger;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSaveAs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lbMax;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label label3;
    }
}