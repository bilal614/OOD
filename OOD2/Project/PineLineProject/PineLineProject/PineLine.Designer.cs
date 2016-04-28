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
            this.btnLine = new System.Windows.Forms.Button();
            this.btnSink = new System.Windows.Forms.Button();
            this.btnAdjustSpliter = new System.Windows.Forms.Button();
            this.btnSpliter = new System.Windows.Forms.Button();
            this.btnMerger = new System.Windows.Forms.Button();
            this.btnPump = new System.Windows.Forms.Button();
            this.panelLineLeft = new System.Windows.Forms.Panel();
            this.panelDrawing = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.panelRightFill = new System.Windows.Forms.Panel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panelLeft.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelRightFill.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLine
            // 
            this.panelLine.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLine.Location = new System.Drawing.Point(0, 80);
            this.panelLine.Name = "panelLine";
            this.panelLine.Size = new System.Drawing.Size(583, 3);
            this.panelLine.TabIndex = 1;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panelLeft.Controls.Add(this.btnLine);
            this.panelLeft.Controls.Add(this.btnSink);
            this.panelLeft.Controls.Add(this.btnAdjustSpliter);
            this.panelLeft.Controls.Add(this.btnSpliter);
            this.panelLeft.Controls.Add(this.btnMerger);
            this.panelLeft.Controls.Add(this.btnPump);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(107, 518);
            this.panelLeft.TabIndex = 2;
            // 
            // btnLine
            // 
            this.btnLine.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLine.FlatAppearance.BorderSize = 0;
            this.btnLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLine.Image = ((System.Drawing.Image)(resources.GetObject("btnLine.Image")));
            this.btnLine.Location = new System.Drawing.Point(21, 355);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(69, 64);
            this.btnLine.TabIndex = 18;
            this.btnLine.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip.SetToolTip(this.btnLine, "Pineline");
            this.btnLine.UseVisualStyleBackColor = true;
            // 
            // btnSink
            // 
            this.btnSink.AllowDrop = true;
            this.btnSink.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSink.FlatAppearance.BorderSize = 0;
            this.btnSink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSink.Image = ((System.Drawing.Image)(resources.GetObject("btnSink.Image")));
            this.btnSink.Location = new System.Drawing.Point(21, 285);
            this.btnSink.Name = "btnSink";
            this.btnSink.Size = new System.Drawing.Size(69, 64);
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
            this.btnAdjustSpliter.Location = new System.Drawing.Point(21, 215);
            this.btnAdjustSpliter.Name = "btnAdjustSpliter";
            this.btnAdjustSpliter.Size = new System.Drawing.Size(69, 64);
            this.btnAdjustSpliter.TabIndex = 18;
            this.btnAdjustSpliter.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip.SetToolTip(this.btnAdjustSpliter, "Adjustable spliter");
            this.btnAdjustSpliter.UseVisualStyleBackColor = true;
            this.btnAdjustSpliter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAdjustSpliter_MouseDown);
            // 
            // btnSpliter
            // 
            this.btnSpliter.AllowDrop = true;
            this.btnSpliter.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSpliter.FlatAppearance.BorderSize = 0;
            this.btnSpliter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpliter.Image = ((System.Drawing.Image)(resources.GetObject("btnSpliter.Image")));
            this.btnSpliter.Location = new System.Drawing.Point(21, 145);
            this.btnSpliter.Name = "btnSpliter";
            this.btnSpliter.Size = new System.Drawing.Size(69, 64);
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
            this.btnMerger.Location = new System.Drawing.Point(21, 78);
            this.btnMerger.Name = "btnMerger";
            this.btnMerger.Size = new System.Drawing.Size(69, 61);
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
            this.btnPump.Size = new System.Drawing.Size(69, 60);
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
            this.panelLineLeft.Location = new System.Drawing.Point(107, 0);
            this.panelLineLeft.Name = "panelLineLeft";
            this.panelLineLeft.Size = new System.Drawing.Size(3, 518);
            this.panelLineLeft.TabIndex = 3;
            // 
            // panelDrawing
            // 
            this.panelDrawing.AllowDrop = true;
            this.panelDrawing.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelDrawing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDrawing.Location = new System.Drawing.Point(0, 0);
            this.panelDrawing.Name = "panelDrawing";
            this.panelDrawing.Size = new System.Drawing.Size(583, 518);
            this.panelDrawing.TabIndex = 4;
            this.panelDrawing.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelDrawing_DragDrop);
            this.panelDrawing.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelDrawing_DragEnter);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panelTop.Controls.Add(this.panelLine);
            this.panelTop.Controls.Add(this.btnSave);
            this.panelTop.Controls.Add(this.btnNew);
            this.panelTop.Controls.Add(this.btnOpen);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(583, 83);
            this.panelTop.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(521, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(50, 69);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.Location = new System.Drawing.Point(411, 5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(49, 69);
            this.btnNew.TabIndex = 18;
            this.btnNew.Text = "New";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOpen.FlatAppearance.BorderSize = 0;
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
            this.btnOpen.Location = new System.Drawing.Point(466, 5);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(49, 69);
            this.btnOpen.TabIndex = 18;
            this.btnOpen.Text = "Open";
            this.btnOpen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOpen.UseVisualStyleBackColor = true;
            // 
            // panelRightFill
            // 
            this.panelRightFill.Controls.Add(this.panelTop);
            this.panelRightFill.Controls.Add(this.panelDrawing);
            this.panelRightFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRightFill.Location = new System.Drawing.Point(107, 0);
            this.panelRightFill.Name = "panelRightFill";
            this.panelRightFill.Size = new System.Drawing.Size(583, 518);
            this.panelRightFill.TabIndex = 5;
            // 
            // PineLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(690, 518);
            this.Controls.Add(this.panelLineLeft);
            this.Controls.Add(this.panelRightFill);
            this.Controls.Add(this.panelLeft);
            this.Name = "PineLine";
            this.Text = "PineLine";
            this.Load += new System.EventHandler(this.PineLine_Load);
            this.panelLeft.ResumeLayout(false);
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

    }
}