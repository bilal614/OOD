namespace Assignment16_AnimalShelter
{
    partial class AddAnimal
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioCat = new System.Windows.Forms.RadioButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.radioDog = new System.Windows.Forms.RadioButton();
            this.tbLocataion = new System.Windows.Forms.TextBox();
            this.dateTimePickerEntryDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxAnimal = new System.Windows.Forms.ListBox();
            this.btnAddAnimal = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnShowAnimals = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entry Date";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioCat);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.radioDog);
            this.groupBox1.Controls.Add(this.tbLocataion);
            this.groupBox1.Controls.Add(this.dateTimePickerEntryDate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 216);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General information";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioCat
            // 
            this.radioCat.AutoSize = true;
            this.radioCat.Location = new System.Drawing.Point(193, 126);
            this.radioCat.Name = "radioCat";
            this.radioCat.Size = new System.Drawing.Size(41, 17);
            this.radioCat.TabIndex = 3;
            this.radioCat.TabStop = true;
            this.radioCat.Text = "Cat";
            this.radioCat.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(129, 157);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(221, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(129, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(221, 20);
            this.textBox2.TabIndex = 2;
            // 
            // radioDog
            // 
            this.radioDog.AutoSize = true;
            this.radioDog.Location = new System.Drawing.Point(129, 126);
            this.radioDog.Name = "radioDog";
            this.radioDog.Size = new System.Drawing.Size(45, 17);
            this.radioDog.TabIndex = 2;
            this.radioDog.TabStop = true;
            this.radioDog.Text = "Dog";
            this.radioDog.UseVisualStyleBackColor = true;
            this.radioDog.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // tbLocataion
            // 
            this.tbLocataion.Location = new System.Drawing.Point(129, 53);
            this.tbLocataion.Name = "tbLocataion";
            this.tbLocataion.Size = new System.Drawing.Size(221, 20);
            this.tbLocataion.TabIndex = 2;
            // 
            // dateTimePickerEntryDate
            // 
            this.dateTimePickerEntryDate.Location = new System.Drawing.Point(129, 25);
            this.dateTimePickerEntryDate.Name = "dateTimePickerEntryDate";
            this.dateTimePickerEntryDate.Size = new System.Drawing.Size(221, 20);
            this.dateTimePickerEntryDate.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Habits";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Pedigree";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Location found";
            // 
            // listBoxAnimal
            // 
            this.listBoxAnimal.FormattingEnabled = true;
            this.listBoxAnimal.Location = new System.Drawing.Point(12, 234);
            this.listBoxAnimal.Name = "listBoxAnimal";
            this.listBoxAnimal.Size = new System.Drawing.Size(647, 199);
            this.listBoxAnimal.TabIndex = 2;
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.Location = new System.Drawing.Point(430, 22);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(147, 35);
            this.btnAddAnimal.TabIndex = 3;
            this.btnAddAnimal.Text = "Add animal";
            this.btnAddAnimal.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(430, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 41);
            this.button2.TabIndex = 3;
            this.button2.Text = "Show a list cat";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(430, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Show list of dogs";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnShowAnimals
            // 
            this.btnShowAnimals.Location = new System.Drawing.Point(430, 73);
            this.btnShowAnimals.Name = "btnShowAnimals";
            this.btnShowAnimals.Size = new System.Drawing.Size(147, 37);
            this.btnShowAnimals.TabIndex = 3;
            this.btnShowAnimals.Text = "Show list of animals";
            this.btnShowAnimals.UseVisualStyleBackColor = true;
            // 
            // AddAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 443);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnShowAnimals);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddAnimal);
            this.Controls.Add(this.listBoxAnimal);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddAnimal";
            this.Text = "Animal Shelter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioCat;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton radioDog;
        private System.Windows.Forms.TextBox tbLocataion;
        private System.Windows.Forms.DateTimePicker dateTimePickerEntryDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxAnimal;
        private System.Windows.Forms.Button btnAddAnimal;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnShowAnimals;
    }
}

