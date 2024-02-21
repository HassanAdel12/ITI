using System.Windows.Forms;

namespace Converter
{
    partial class Converter
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
            this.textValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textResult = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.radioMtoK = new System.Windows.Forms.RadioButton();
            this.radioMtoMi = new System.Windows.Forms.RadioButton();
            this.radioMitoM = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LaErrorValue = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textValue
            // 
            this.textValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textValue.Location = new System.Drawing.Point(116, 109);
            this.textValue.Name = "textValue";
            this.textValue.Size = new System.Drawing.Size(205, 30);
            this.textValue.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Value :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Result :";
            // 
            // textResult
            // 
            this.textResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textResult.Location = new System.Drawing.Point(116, 227);
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(205, 30);
            this.textResult.TabIndex = 3;
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(208, 402);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(233, 61);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // radioMtoK
            // 
            this.radioMtoK.AutoSize = true;
            this.radioMtoK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMtoK.Location = new System.Drawing.Point(43, 53);
            this.radioMtoK.Name = "radioMtoK";
            this.radioMtoK.Size = new System.Drawing.Size(173, 24);
            this.radioMtoK.TabIndex = 5;
            this.radioMtoK.TabStop = true;
            this.radioMtoK.Text = "Meter to Kilometer ";
            this.radioMtoK.UseVisualStyleBackColor = true;
            // 
            // radioMtoMi
            // 
            this.radioMtoMi.AutoSize = true;
            this.radioMtoMi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMtoMi.Location = new System.Drawing.Point(43, 106);
            this.radioMtoMi.Name = "radioMtoMi";
            this.radioMtoMi.Size = new System.Drawing.Size(128, 24);
            this.radioMtoMi.TabIndex = 6;
            this.radioMtoMi.TabStop = true;
            this.radioMtoMi.Text = "Meter to Mile";
            this.radioMtoMi.UseVisualStyleBackColor = true;
            // 
            // radioMitoM
            // 
            this.radioMitoM.AutoSize = true;
            this.radioMitoM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMitoM.Location = new System.Drawing.Point(43, 155);
            this.radioMitoM.Name = "radioMitoM";
            this.radioMitoM.Size = new System.Drawing.Size(128, 24);
            this.radioMitoM.TabIndex = 7;
            this.radioMitoM.TabStop = true;
            this.radioMitoM.Text = "Mile to Meter";
            this.radioMitoM.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioMtoK);
            this.groupBox1.Controls.Add(this.radioMitoM);
            this.groupBox1.Controls.Add(this.radioMtoMi);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(367, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 233);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Unit";
            // 
            // LaErrorValue
            // 
            this.LaErrorValue.AutoSize = true;
            this.LaErrorValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaErrorValue.ForeColor = System.Drawing.Color.Red;
            this.LaErrorValue.Location = new System.Drawing.Point(111, 171);
            this.LaErrorValue.Name = "LaErrorValue";
            this.LaErrorValue.Size = new System.Drawing.Size(0, 25);
            this.LaErrorValue.TabIndex = 9;
            // 
            // Converter
            // 
            this.ClientSize = new System.Drawing.Size(700, 544);
            this.Controls.Add(this.LaErrorValue);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textValue);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Converter";
            this.Text = "Converter";
            this.Load += new System.EventHandler(this.Converter_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.RadioButton radioMtoK;
        private System.Windows.Forms.RadioButton radioMtoMi;
        private System.Windows.Forms.RadioButton radioMitoM;
        private System.Windows.Forms.GroupBox groupBox1;
        private Label LaErrorValue;
    }
}

