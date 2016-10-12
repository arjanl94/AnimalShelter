namespace AnimalShelter
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbname = new System.Windows.Forms.TextBox();
            this.tbhabits = new System.Windows.Forms.TextBox();
            this.cmbgender = new System.Windows.Forms.ComboBox();
            this.cmbanimal = new System.Windows.Forms.ComboBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.lbanimals = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbproducts = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnaddproduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Animal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gender:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bad Habits:";
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(94, 68);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(113, 20);
            this.tbname.TabIndex = 4;
            // 
            // tbhabits
            // 
            this.tbhabits.Location = new System.Drawing.Point(94, 145);
            this.tbhabits.Name = "tbhabits";
            this.tbhabits.Size = new System.Drawing.Size(113, 20);
            this.tbhabits.TabIndex = 5;
            // 
            // cmbgender
            // 
            this.cmbgender.FormattingEnabled = true;
            this.cmbgender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.cmbgender.Location = new System.Drawing.Point(94, 107);
            this.cmbgender.Name = "cmbgender";
            this.cmbgender.Size = new System.Drawing.Size(113, 21);
            this.cmbgender.TabIndex = 6;
            // 
            // cmbanimal
            // 
            this.cmbanimal.FormattingEnabled = true;
            this.cmbanimal.Items.AddRange(new object[] {
            "Cat",
            "Dog"});
            this.cmbanimal.Location = new System.Drawing.Point(94, 28);
            this.cmbanimal.Name = "cmbanimal";
            this.cmbanimal.Size = new System.Drawing.Size(113, 21);
            this.cmbanimal.TabIndex = 7;
            this.cmbanimal.SelectedIndexChanged += new System.EventHandler(this.cmbanimal_SelectedIndexChanged);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(94, 171);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(113, 23);
            this.btnadd.TabIndex = 8;
            this.btnadd.Text = "Add Animal";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // lbanimals
            // 
            this.lbanimals.FormattingEnabled = true;
            this.lbanimals.Location = new System.Drawing.Point(227, 28);
            this.lbanimals.Name = "lbanimals";
            this.lbanimals.Size = new System.Drawing.Size(337, 134);
            this.lbanimals.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "List of animals:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(224, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "List of products:";
            // 
            // lbproducts
            // 
            this.lbproducts.FormattingEnabled = true;
            this.lbproducts.Location = new System.Drawing.Point(227, 275);
            this.lbproducts.Name = "lbproducts";
            this.lbproducts.Size = new System.Drawing.Size(337, 134);
            this.lbproducts.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 275);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 20);
            this.textBox1.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Price:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(94, 310);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(113, 20);
            this.textBox2.TabIndex = 16;
            // 
            // btnaddproduct
            // 
            this.btnaddproduct.Location = new System.Drawing.Point(94, 336);
            this.btnaddproduct.Name = "btnaddproduct";
            this.btnaddproduct.Size = new System.Drawing.Size(113, 23);
            this.btnaddproduct.TabIndex = 17;
            this.btnaddproduct.Text = "Add Product";
            this.btnaddproduct.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 555);
            this.Controls.Add(this.btnaddproduct);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbproducts);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbanimals);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.cmbanimal);
            this.Controls.Add(this.cmbgender);
            this.Controls.Add(this.tbhabits);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.TextBox tbhabits;
        private System.Windows.Forms.ComboBox cmbgender;
        private System.Windows.Forms.ComboBox cmbanimal;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.ListBox lbanimals;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbproducts;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnaddproduct;
    }
}

