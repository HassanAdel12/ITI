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
            this.Txt = new System.Windows.Forms.TextBox();
            this.C = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.Dot = new System.Windows.Forms.Button();
            this.Eql = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.Sub = new System.Windows.Forms.Button();
            this.Mul = new System.Windows.Forms.Button();
            this.Div = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txt
            // 
            this.Txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt.Location = new System.Drawing.Point(33, 42);
            this.Txt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txt.Name = "Txt";
            this.Txt.ReadOnly = true;
            this.Txt.Size = new System.Drawing.Size(309, 41);
            this.Txt.TabIndex = 0;
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(29, 111);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(55, 35);
            this.C.TabIndex = 1;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = true;
            this.C.Click += new System.EventHandler(this.C_Click);
            // 
            // num7
            // 
            this.num7.Location = new System.Drawing.Point(29, 187);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(55, 35);
            this.num7.TabIndex = 2;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = true;
            this.num7.Click += new System.EventHandler(this.num7_Click);
            // 
            // num4
            // 
            this.num4.Location = new System.Drawing.Point(29, 255);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(55, 35);
            this.num4.TabIndex = 3;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = true;
            this.num4.Click += new System.EventHandler(this.num4_Click);
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(29, 309);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(55, 35);
            this.num1.TabIndex = 4;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = true;
            this.num1.Click += new System.EventHandler(this.num1_Click);
            // 
            // num8
            // 
            this.num8.Location = new System.Drawing.Point(113, 187);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(55, 35);
            this.num8.TabIndex = 5;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = true;
            this.num8.Click += new System.EventHandler(this.num8_Click);
            // 
            // num5
            // 
            this.num5.Location = new System.Drawing.Point(113, 254);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(55, 35);
            this.num5.TabIndex = 6;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = true;
            this.num5.Click += new System.EventHandler(this.num5_Click);
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(113, 308);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(55, 35);
            this.num2.TabIndex = 7;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = true;
            this.num2.Click += new System.EventHandler(this.num2_Click);
            // 
            // num9
            // 
            this.num9.Location = new System.Drawing.Point(202, 187);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(55, 35);
            this.num9.TabIndex = 8;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = true;
            this.num9.Click += new System.EventHandler(this.num9_Click);
            // 
            // num6
            // 
            this.num6.Location = new System.Drawing.Point(202, 255);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(55, 35);
            this.num6.TabIndex = 9;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = true;
            this.num6.Click += new System.EventHandler(this.num6_Click);
            // 
            // num3
            // 
            this.num3.Location = new System.Drawing.Point(202, 309);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(55, 35);
            this.num3.TabIndex = 10;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = true;
            this.num3.Click += new System.EventHandler(this.num3_Click);
            // 
            // num0
            // 
            this.num0.Location = new System.Drawing.Point(29, 367);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(55, 35);
            this.num0.TabIndex = 11;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = true;
            this.num0.Click += new System.EventHandler(this.num0_Click);
            // 
            // Dot
            // 
            this.Dot.Location = new System.Drawing.Point(113, 367);
            this.Dot.Name = "Dot";
            this.Dot.Size = new System.Drawing.Size(55, 35);
            this.Dot.TabIndex = 12;
            this.Dot.Text = ".";
            this.Dot.UseVisualStyleBackColor = true;
            this.Dot.Click += new System.EventHandler(this.Dot_Click);
            // 
            // Eql
            // 
            this.Eql.Location = new System.Drawing.Point(202, 367);
            this.Eql.Name = "Eql";
            this.Eql.Size = new System.Drawing.Size(55, 35);
            this.Eql.TabIndex = 13;
            this.Eql.Text = "=";
            this.Eql.UseVisualStyleBackColor = true;
            this.Eql.Click += new System.EventHandler(this.Eql_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(287, 187);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(55, 35);
            this.add.TabIndex = 14;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // Sub
            // 
            this.Sub.Location = new System.Drawing.Point(287, 254);
            this.Sub.Name = "Sub";
            this.Sub.Size = new System.Drawing.Size(55, 35);
            this.Sub.TabIndex = 15;
            this.Sub.Text = "-";
            this.Sub.UseVisualStyleBackColor = true;
            this.Sub.Click += new System.EventHandler(this.Sub_Click);
            // 
            // Mul
            // 
            this.Mul.Location = new System.Drawing.Point(287, 309);
            this.Mul.Name = "Mul";
            this.Mul.Size = new System.Drawing.Size(55, 35);
            this.Mul.TabIndex = 16;
            this.Mul.Text = "*";
            this.Mul.UseVisualStyleBackColor = true;
            this.Mul.Click += new System.EventHandler(this.Mul_Click);
            // 
            // Div
            // 
            this.Div.Location = new System.Drawing.Point(287, 367);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(55, 35);
            this.Div.TabIndex = 17;
            this.Div.Text = "/";
            this.Div.UseVisualStyleBackColor = true;
            this.Div.Click += new System.EventHandler(this.Div_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 451);
            this.Controls.Add(this.Div);
            this.Controls.Add(this.Mul);
            this.Controls.Add(this.Sub);
            this.Controls.Add(this.add);
            this.Controls.Add(this.Eql);
            this.Controls.Add(this.Dot);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.C);
            this.Controls.Add(this.Txt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button Dot;
        private System.Windows.Forms.Button Eql;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button Sub;
        private System.Windows.Forms.Button Mul;
        private System.Windows.Forms.Button Div;
    }
}

