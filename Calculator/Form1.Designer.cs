namespace Calculator
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.number1 = new System.Windows.Forms.Button();
            this.number2 = new System.Windows.Forms.Button();
            this.number3 = new System.Windows.Forms.Button();
            this.number4 = new System.Windows.Forms.Button();
            this.number5 = new System.Windows.Forms.Button();
            this.number6 = new System.Windows.Forms.Button();
            this.number7 = new System.Windows.Forms.Button();
            this.number8 = new System.Windows.Forms.Button();
            this.number9 = new System.Windows.Forms.Button();
            this.number0 = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.Addition = new System.Windows.Forms.Button();
            this.Subtraction = new System.Windows.Forms.Button();
            this.Equals = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(49, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(527, 31);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // number1
            // 
            this.number1.Location = new System.Drawing.Point(49, 149);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(107, 73);
            this.number1.TabIndex = 1;
            this.number1.Text = "1";
            this.number1.UseVisualStyleBackColor = true;
            this.number1.Click += new System.EventHandler(this.button1_Click);
            // 
            // number2
            // 
            this.number2.Location = new System.Drawing.Point(181, 149);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(109, 73);
            this.number2.TabIndex = 2;
            this.number2.Text = "2";
            this.number2.UseVisualStyleBackColor = true;
            this.number2.Click += new System.EventHandler(this.number2_Click);
            // 
            // number3
            // 
            this.number3.Location = new System.Drawing.Point(315, 149);
            this.number3.Name = "number3";
            this.number3.Size = new System.Drawing.Size(114, 73);
            this.number3.TabIndex = 3;
            this.number3.Text = "3";
            this.number3.UseVisualStyleBackColor = true;
            this.number3.Click += new System.EventHandler(this.number3_Click);
            // 
            // number4
            // 
            this.number4.Location = new System.Drawing.Point(458, 149);
            this.number4.Name = "number4";
            this.number4.Size = new System.Drawing.Size(118, 73);
            this.number4.TabIndex = 4;
            this.number4.Text = "4";
            this.number4.UseVisualStyleBackColor = true;
            this.number4.Click += new System.EventHandler(this.number4_Click);
            // 
            // number5
            // 
            this.number5.Location = new System.Drawing.Point(49, 242);
            this.number5.Name = "number5";
            this.number5.Size = new System.Drawing.Size(107, 69);
            this.number5.TabIndex = 5;
            this.number5.Text = "5";
            this.number5.UseVisualStyleBackColor = true;
            this.number5.Click += new System.EventHandler(this.number5_Click);
            // 
            // number6
            // 
            this.number6.Location = new System.Drawing.Point(181, 242);
            this.number6.Name = "number6";
            this.number6.Size = new System.Drawing.Size(109, 69);
            this.number6.TabIndex = 6;
            this.number6.Text = "6";
            this.number6.UseVisualStyleBackColor = true;
            this.number6.Click += new System.EventHandler(this.number6_Click);
            // 
            // number7
            // 
            this.number7.Location = new System.Drawing.Point(315, 242);
            this.number7.Name = "number7";
            this.number7.Size = new System.Drawing.Size(114, 69);
            this.number7.TabIndex = 7;
            this.number7.Text = "7";
            this.number7.UseVisualStyleBackColor = true;
            this.number7.Click += new System.EventHandler(this.number7_Click);
            // 
            // number8
            // 
            this.number8.Location = new System.Drawing.Point(458, 242);
            this.number8.Name = "number8";
            this.number8.Size = new System.Drawing.Size(118, 69);
            this.number8.TabIndex = 8;
            this.number8.Text = "8";
            this.number8.UseVisualStyleBackColor = true;
            this.number8.Click += new System.EventHandler(this.number8_Click);
            // 
            // number9
            // 
            this.number9.Location = new System.Drawing.Point(49, 328);
            this.number9.Name = "number9";
            this.number9.Size = new System.Drawing.Size(107, 72);
            this.number9.TabIndex = 9;
            this.number9.Text = "9";
            this.number9.UseVisualStyleBackColor = true;
            this.number9.Click += new System.EventHandler(this.number9_Click);
            // 
            // number0
            // 
            this.number0.Location = new System.Drawing.Point(181, 328);
            this.number0.Name = "number0";
            this.number0.Size = new System.Drawing.Size(109, 72);
            this.number0.TabIndex = 10;
            this.number0.Text = "0";
            this.number0.UseVisualStyleBackColor = true;
            this.number0.Click += new System.EventHandler(this.number0_Click);
            // 
            // multiplication
            // 
            this.multiplication.Location = new System.Drawing.Point(49, 424);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(107, 76);
            this.multiplication.TabIndex = 11;
            this.multiplication.Text = "X";
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.Click += new System.EventHandler(this.multiplication_Click);
            // 
            // Division
            // 
            this.Division.Location = new System.Drawing.Point(181, 424);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(109, 76);
            this.Division.TabIndex = 12;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.Division_Click);
            // 
            // Addition
            // 
            this.Addition.Location = new System.Drawing.Point(324, 424);
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(105, 76);
            this.Addition.TabIndex = 13;
            this.Addition.Text = "+";
            this.Addition.UseVisualStyleBackColor = true;
            this.Addition.Click += new System.EventHandler(this.Addition_Click);
            // 
            // Subtraction
            // 
            this.Subtraction.Location = new System.Drawing.Point(458, 424);
            this.Subtraction.Name = "Subtraction";
            this.Subtraction.Size = new System.Drawing.Size(118, 76);
            this.Subtraction.TabIndex = 14;
            this.Subtraction.Text = "-";
            this.Subtraction.UseVisualStyleBackColor = true;
            this.Subtraction.Click += new System.EventHandler(this.Subtraction_Click);
            // 
            // Equals
            // 
            this.Equals.Location = new System.Drawing.Point(458, 518);
            this.Equals.Name = "Equals";
            this.Equals.Size = new System.Drawing.Size(118, 76);
            this.Equals.TabIndex = 15;
            this.Equals.Text = "=";
            this.Equals.UseVisualStyleBackColor = true;
            this.Equals.Click += new System.EventHandler(this.Equals_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(49, 518);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(107, 76);
            this.Clear.TabIndex = 16;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 632);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Equals);
            this.Controls.Add(this.Subtraction);
            this.Controls.Add(this.Addition);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.number0);
            this.Controls.Add(this.number9);
            this.Controls.Add(this.number8);
            this.Controls.Add(this.number7);
            this.Controls.Add(this.number6);
            this.Controls.Add(this.number5);
            this.Controls.Add(this.number4);
            this.Controls.Add(this.number3);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button number1;
        private System.Windows.Forms.Button number2;
        private System.Windows.Forms.Button number3;
        private System.Windows.Forms.Button number4;
        private System.Windows.Forms.Button number5;
        private System.Windows.Forms.Button number6;
        private System.Windows.Forms.Button number7;
        private System.Windows.Forms.Button number8;
        private System.Windows.Forms.Button number9;
        private System.Windows.Forms.Button number0;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.Button Addition;
        private System.Windows.Forms.Button Subtraction;
        private System.Windows.Forms.Button Equals;
        private System.Windows.Forms.Button Clear;
    }
}

