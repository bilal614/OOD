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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            this.panelLine.Size = new System.Drawing.Size(526, 3);
            this.panelLine.TabIndex = 1;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panelLeft.Controls.Add(this.button4);
            this.panelLeft.Controls.Add(this.button3);
            this.panelLeft.Controls.Add(this.btnSpliter);
            this.panelLeft.Controls.Add(this.btnMerger);
            this.panelLeft.Controls.Add(this.btnPump);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(107, 389);
            this.panelLeft.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(12, 314);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 69);
            this.button4.TabIndex = 18;
            this.button4.Text = "New";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(12, 239);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 69);
            this.button3.TabIndex = 18;
            this.button3.Text = "New";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSpliter
            // 
            this.btnSpliter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSpliter.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSpliter.FlatAppearance.BorderSize = 0;
            this.btnSpliter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpliter.Image = ((System.Drawing.Image)(resources.GetObject("btnSpliter.Image")));
            this.btnSpliter.Location = new System.Drawing.Point(12, 164);
            this.btnSpliter.Name = "btnSpliter";
            this.btnSpliter.Size = new System.Drawing.Size(81, 69);
            this.btnSpliter.TabIndex = 18;
            this.btnSpliter.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip.SetToolTip(this.btnSpliter, "Spliter");
            this.btnSpliter.UseVisualStyleBackColor = true;
            this.btnSpliter.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnMerger
            // 
            this.btnMerger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMerger.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMerger.FlatAppearance.BorderSize = 0;
            this.btnMerger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMerger.Image = ((System.Drawing.Image)(resources.GetObject("btnMerger.Image")));
            this.btnMerger.Location = new System.Drawing.Point(12, 89);
            this.btnMerger.Name = "btnMerger";
            this.btnMerger.Size = new System.Drawing.Size(81, 69);
            this.btnMerger.TabIndex = 18;
            this.btnMerger.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip.SetToolTip(this.btnMerger, "Merger");
            this.btnMerger.UseVisualStyleBackColor = true;
            this.btnMerger.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnPump
            // 
            this.btnPump.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPump.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPump.FlatAppearance.BorderSize = 0;
            this.btnPump.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPump.Image = ((System.Drawing.Image)(resources.GetObject("btnPump.Image")));
            this.btnPump.Location = new System.Drawing.Point(12, 14);
            this.btnPump.Name = "btnPump";
            this.btnPump.Size = new System.Drawing.Size(81, 69);
            this.btnPump.TabIndex = 18;
            this.btnPump.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip.SetToolTip(this.btnPump, "Pump");
            this.btnPump.UseVisualStyleBackColor = true;
            this.btnPump.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // panelLineLeft
            // 
            this.panelLineLeft.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelLineLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLineLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLineLeft.Name = "panelLineLeft";
            this.panelLineLeft.Size = new System.Drawing.Size(3, 389);
            this.panelLineLeft.TabIndex = 3;
            // 
            // panelDrawing
            // 
            this.panelDrawing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDrawing.Location = new System.Drawing.Point(0, 0);
            this.panelDrawing.Name = "panelDrawing";
            this.panelDrawing.Size = new System.Drawing.Size(529, 389);
            this.panelDrawing.TabIndex = 4;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panelTop.Controls.Add(this.panelLine);
            this.panelTop.Controls.Add(this.btnSave);
            this.panelTop.Controls.Add(this.btnNew);
            this.panelTop.Controls.Add(this.btnOpen);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(3, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(526, 83);
            this.panelTop.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(464, 5);
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
            this.btnNew.Location = new System.Drawing.Point(354, 5);
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
            this.btnOpen.Location = new System.Drawing.Point(409, 5);
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
            this.panelRightFill.Controls.Add(this.panelLineLeft);
            this.panelRightFill.Controls.Add(this.panelDrawing);
            this.panelRightFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRightFill.Location = new System.Drawing.Point(107, 0);
            this.panelRightFill.Name = "panelRightFill";
            this.panelRightFill.Size = new System.Drawing.Size(529, 389);
            this.panelRightFill.TabIndex = 5;
            // 
            // PineLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(636, 389);
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
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnSpliter;
        private System.Windows.Forms.Button btnMerger;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btnNew;

    }
}