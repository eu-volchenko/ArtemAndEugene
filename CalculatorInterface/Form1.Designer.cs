namespace CalculatorInterface
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
            this.button_plus = new System.Windows.Forms.Button();
            this.button_minus = new System.Windows.Forms.Button();
            this.button_multiply = new System.Windows.Forms.Button();
            this.button_divide = new System.Windows.Forms.Button();
            this.textBox_a = new System.Windows.Forms.TextBox();
            this.textBox_b = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_answer = new System.Windows.Forms.TextBox();
            this.button_calculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_plus
            // 
            this.button_plus.Location = new System.Drawing.Point(187, 27);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(75, 23);
            this.button_plus.TabIndex = 0;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = true;
            // 
            // button_minus
            // 
            this.button_minus.Location = new System.Drawing.Point(187, 70);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(75, 23);
            this.button_minus.TabIndex = 1;
            this.button_minus.Text = "-";
            this.button_minus.UseVisualStyleBackColor = true;
            // 
            // button_multiply
            // 
            this.button_multiply.Location = new System.Drawing.Point(187, 112);
            this.button_multiply.Name = "button_multiply";
            this.button_multiply.Size = new System.Drawing.Size(75, 23);
            this.button_multiply.TabIndex = 2;
            this.button_multiply.Text = "*";
            this.button_multiply.UseVisualStyleBackColor = true;
            // 
            // button_divide
            // 
            this.button_divide.Location = new System.Drawing.Point(187, 156);
            this.button_divide.Name = "button_divide";
            this.button_divide.Size = new System.Drawing.Size(75, 23);
            this.button_divide.TabIndex = 3;
            this.button_divide.Text = "/";
            this.button_divide.UseVisualStyleBackColor = true;
            // 
            // textBox_a
            // 
            this.textBox_a.Location = new System.Drawing.Point(41, 29);
            this.textBox_a.Name = "textBox_a";
            this.textBox_a.Size = new System.Drawing.Size(100, 20);
            this.textBox_a.TabIndex = 4;
            // 
            // textBox_b
            // 
            this.textBox_b.Location = new System.Drawing.Point(41, 70);
            this.textBox_b.Name = "textBox_b";
            this.textBox_b.Size = new System.Drawing.Size(100, 20);
            this.textBox_b.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "a = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "b =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Answer - ";
            // 
            // textBox_answer
            // 
            this.textBox_answer.Location = new System.Drawing.Point(69, 228);
            this.textBox_answer.Name = "textBox_answer";
            this.textBox_answer.Size = new System.Drawing.Size(100, 20);
            this.textBox_answer.TabIndex = 9;
            // 
            // button_calculate
            // 
            this.button_calculate.Location = new System.Drawing.Point(15, 123);
            this.button_calculate.Name = "button_calculate";
            this.button_calculate.Size = new System.Drawing.Size(133, 27);
            this.button_calculate.TabIndex = 10;
            this.button_calculate.Text = "Calculate";
            this.button_calculate.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button_calculate);
            this.Controls.Add(this.textBox_answer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_b);
            this.Controls.Add(this.textBox_a);
            this.Controls.Add(this.button_divide);
            this.Controls.Add(this.button_multiply);
            this.Controls.Add(this.button_minus);
            this.Controls.Add(this.button_plus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button_multiply;
        private System.Windows.Forms.Button button_divide;
        private System.Windows.Forms.TextBox textBox_a;
        private System.Windows.Forms.TextBox textBox_b;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_answer;
        private System.Windows.Forms.Button button_calculate;
    }
}

