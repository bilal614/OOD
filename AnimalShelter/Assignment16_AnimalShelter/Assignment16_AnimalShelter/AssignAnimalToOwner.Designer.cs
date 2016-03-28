namespace Assignment16_AnimalShelter
{
    partial class AssignAnimalToOwner
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
            this.btnAssign = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.listBoxAnimal = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbChipNr = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.ListBox();
            this.btnAnimalOfOwner = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(53, 172);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(232, 41);
            this.btnAssign.TabIndex = 6;
            this.btnAssign.Text = "Assign animal to owner";
            this.btnAssign.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(129, 88);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(103, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // listBoxAnimal
            // 
            this.listBoxAnimal.FormattingEnabled = true;
            this.listBoxAnimal.Location = new System.Drawing.Point(12, 240);
            this.listBoxAnimal.Name = "listBoxAnimal";
            this.listBoxAnimal.Size = new System.Drawing.Size(736, 199);
            this.listBoxAnimal.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lbChipNr);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 128);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // lbChipNr
            // 
            this.lbChipNr.AutoSize = true;
            this.lbChipNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChipNr.Location = new System.Drawing.Point(25, 28);
            this.lbChipNr.Name = "lbChipNr";
            this.lbChipNr.Size = new System.Drawing.Size(77, 13);
            this.lbChipNr.TabIndex = 0;
            this.lbChipNr.Text = "Chip number";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(129, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(169, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Owner number";
            // 
            // lbResult
            // 
            this.lbResult.FormattingEnabled = true;
            this.lbResult.Location = new System.Drawing.Point(372, 19);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(370, 121);
            this.lbResult.TabIndex = 5;
            // 
            // btnAnimalOfOwner
            // 
            this.btnAnimalOfOwner.Location = new System.Drawing.Point(425, 172);
            this.btnAnimalOfOwner.Name = "btnAnimalOfOwner";
            this.btnAnimalOfOwner.Size = new System.Drawing.Size(232, 41);
            this.btnAnimalOfOwner.TabIndex = 6;
            this.btnAnimalOfOwner.Text = "Show animals of owner";
            this.btnAnimalOfOwner.UseVisualStyleBackColor = true;
            // 
            // AssignAnimalToOwner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 452);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.btnAnimalOfOwner);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.listBoxAnimal);
            this.Controls.Add(this.groupBox1);
            this.Name = "AssignAnimalToOwner";
            this.Text = "Assign Animal To Owner";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox listBoxAnimal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbChipNr;
        private System.Windows.Forms.ListBox lbResult;
        private System.Windows.Forms.Button btnAnimalOfOwner;
    }
}