namespace Trainees
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
            this.Trainee = new System.Windows.Forms.CheckedListBox();
            this.TabTrainee = new System.Windows.Forms.CheckedListBox();
            this.btnSTraineeToLab = new System.Windows.Forms.Button();
            this.btnTTraineeToLab = new System.Windows.Forms.Button();
            this.btnSTabToTrainee = new System.Windows.Forms.Button();
            this.btnTTabToTrainee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trainee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(546, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lab Trainee";
            // 
            // Trainee
            // 
            this.Trainee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Trainee.FormattingEnabled = true;
            this.Trainee.Location = new System.Drawing.Point(41, 139);
            this.Trainee.Name = "Trainee";
            this.Trainee.Size = new System.Drawing.Size(262, 304);
            this.Trainee.TabIndex = 2;
            // 
            // TabTrainee
            // 
            this.TabTrainee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabTrainee.FormattingEnabled = true;
            this.TabTrainee.Location = new System.Drawing.Point(500, 139);
            this.TabTrainee.Name = "TabTrainee";
            this.TabTrainee.Size = new System.Drawing.Size(258, 304);
            this.TabTrainee.TabIndex = 3;
            // 
            // btnSTraineeToLab
            // 
            this.btnSTraineeToLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSTraineeToLab.Location = new System.Drawing.Point(363, 173);
            this.btnSTraineeToLab.Name = "btnSTraineeToLab";
            this.btnSTraineeToLab.Size = new System.Drawing.Size(58, 39);
            this.btnSTraineeToLab.TabIndex = 4;
            this.btnSTraineeToLab.Text = ">";
            this.btnSTraineeToLab.UseVisualStyleBackColor = true;
            this.btnSTraineeToLab.Click += new System.EventHandler(this.btnSTraineeToLab_Click);
            // 
            // btnTTraineeToLab
            // 
            this.btnTTraineeToLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTTraineeToLab.Location = new System.Drawing.Point(363, 234);
            this.btnTTraineeToLab.Name = "btnTTraineeToLab";
            this.btnTTraineeToLab.Size = new System.Drawing.Size(58, 39);
            this.btnTTraineeToLab.TabIndex = 5;
            this.btnTTraineeToLab.Text = ">>";
            this.btnTTraineeToLab.UseVisualStyleBackColor = true;
            this.btnTTraineeToLab.Click += new System.EventHandler(this.btnTTraineeToLab_Click);
            // 
            // btnSTabToTrainee
            // 
            this.btnSTabToTrainee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSTabToTrainee.Location = new System.Drawing.Point(363, 342);
            this.btnSTabToTrainee.Name = "btnSTabToTrainee";
            this.btnSTabToTrainee.Size = new System.Drawing.Size(58, 39);
            this.btnSTabToTrainee.TabIndex = 6;
            this.btnSTabToTrainee.Text = "<";
            this.btnSTabToTrainee.UseVisualStyleBackColor = true;
            this.btnSTabToTrainee.Click += new System.EventHandler(this.btnSTabToTrainee_Click);
            // 
            // btnTTabToTrainee
            // 
            this.btnTTabToTrainee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTTabToTrainee.Location = new System.Drawing.Point(363, 411);
            this.btnTTabToTrainee.Name = "btnTTabToTrainee";
            this.btnTTabToTrainee.Size = new System.Drawing.Size(58, 39);
            this.btnTTabToTrainee.TabIndex = 7;
            this.btnTTabToTrainee.Text = "<<";
            this.btnTTabToTrainee.UseVisualStyleBackColor = true;
            this.btnTTabToTrainee.Click += new System.EventHandler(this.btnTTabToTrainee_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 521);
            this.Controls.Add(this.btnTTabToTrainee);
            this.Controls.Add(this.btnSTabToTrainee);
            this.Controls.Add(this.btnTTraineeToLab);
            this.Controls.Add(this.btnSTraineeToLab);
            this.Controls.Add(this.TabTrainee);
            this.Controls.Add(this.Trainee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Trainees";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox Trainee;
        private System.Windows.Forms.CheckedListBox TabTrainee;
        private System.Windows.Forms.Button btnSTraineeToLab;
        private System.Windows.Forms.Button btnTTraineeToLab;
        private System.Windows.Forms.Button btnSTabToTrainee;
        private System.Windows.Forms.Button btnTTabToTrainee;
    }
}

