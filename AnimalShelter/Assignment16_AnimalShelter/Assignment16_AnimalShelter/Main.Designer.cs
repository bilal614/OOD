using Assignment16_AnimalShelter;

namespace Assignment16_AnimalShelter
{
    partial class Main
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
            this.btnAddAnimal = new System.Windows.Forms.Button();
            this.btnAssignAnimal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.Location = new System.Drawing.Point(220, 80);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(174, 59);
            this.btnAddAnimal.TabIndex = 0;
            this.btnAddAnimal.Text = "Add animal";
            this.btnAddAnimal.UseVisualStyleBackColor = true;
            this.btnAddAnimal.Click += new System.EventHandler(this.btnAddAnimal_Click);
            // 
            // btnAssignAnimal
            // 
            this.btnAssignAnimal.Location = new System.Drawing.Point(220, 188);
            this.btnAssignAnimal.Name = "btnAssignAnimal";
            this.btnAssignAnimal.Size = new System.Drawing.Size(174, 66);
            this.btnAssignAnimal.TabIndex = 1;
            this.btnAssignAnimal.Text = "Assign Animal";
            this.btnAssignAnimal.UseVisualStyleBackColor = true;
            this.btnAssignAnimal.Click += new System.EventHandler(this.btnAssignAnimal_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 351);
            this.Controls.Add(this.btnAssignAnimal);
            this.Controls.Add(this.btnAddAnimal);
            this.Name = "Main";
            this.Text = "Animal Shelter";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnAddAnimal;
        private System.Windows.Forms.Button btnAssignAnimal;
    }
}