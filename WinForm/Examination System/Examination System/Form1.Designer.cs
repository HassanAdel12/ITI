namespace Examination_System
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolNew = new System.Windows.Forms.ToolStripDropDownButton();
            this.Course = new System.Windows.Forms.ToolStripMenuItem();
            this.Question = new System.Windows.Forms.ToolStripMenuItem();
            this.Exam = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolTakeExam = new System.Windows.Forms.ToolStripDropDownButton();
            this.CSharp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolNew,
            this.toolStripSeparator1,
            this.toolTakeExam});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip.ShowItemToolTips = false;
            this.toolStrip.Size = new System.Drawing.Size(800, 31);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip";
            // 
            // toolNew
            // 
            this.toolNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolNew.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Course,
            this.Question,
            this.Exam});
            this.toolNew.Image = ((System.Drawing.Image)(resources.GetObject("toolNew.Image")));
            this.toolNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolNew.Name = "toolNew";
            this.toolNew.Size = new System.Drawing.Size(53, 28);
            this.toolNew.Text = "New";
            this.toolNew.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // Course
            // 
            this.Course.Name = "Course";
            this.Course.Size = new System.Drawing.Size(224, 26);
            this.Course.Text = "Course";
            // 
            // Question
            // 
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(224, 26);
            this.Question.Text = "Question";
            this.Question.Click += new System.EventHandler(this.Question_Click);
            // 
            // Exam
            // 
            this.Exam.Name = "Exam";
            this.Exam.Size = new System.Drawing.Size(224, 26);
            this.Exam.Text = "Exam";
            this.Exam.Click += new System.EventHandler(this.Exam_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolTakeExam
            // 
            this.toolTakeExam.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolTakeExam.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CSharp});
            this.toolTakeExam.Image = ((System.Drawing.Image)(resources.GetObject("toolTakeExam.Image")));
            this.toolTakeExam.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolTakeExam.Name = "toolTakeExam";
            this.toolTakeExam.Size = new System.Drawing.Size(92, 24);
            this.toolTakeExam.Text = "Take Exam";
            this.toolTakeExam.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // CSharp
            // 
            this.CSharp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.CSharp.Name = "CSharp";
            this.CSharp.Size = new System.Drawing.Size(110, 26);
            this.CSharp.Text = "C#";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(100, 26);
            this.toolStripMenuItem2.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Examination System";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripDropDownButton toolNew;
        private System.Windows.Forms.ToolStripDropDownButton toolTakeExam;
        private System.Windows.Forms.ToolStripMenuItem Course;
        private System.Windows.Forms.ToolStripMenuItem Question;
        private System.Windows.Forms.ToolStripMenuItem Exam;
        private System.Windows.Forms.ToolStripMenuItem CSharp;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

