using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StepByStep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            List<string> Colors = new List<string>();
            Colors.Add("");
            Colors.Add("Black");
            Colors.Add("White");
            Colors.Add("Red");
            Colors.Add("Green");
            Colors.Add("yellow");
            Colors.Add("Blue");
            Colors.Add("Gray");
            Colors.Add("Orange");
            Colors.Add("");

            domainUpDown.Items.AddRange(Colors);
            domainUpDown.SelectedIndex = 1;

            laText.Font = new System.Drawing.Font("Microsoft Sans Serif", (int)numericUpDown1.Value);

        }

        private void domainUpDown_SelectedItemChanged(object sender, EventArgs e)
        {
            
            string newColor = domainUpDown.Text;
            laText.ForeColor = Color.FromName(newColor);
            if (domainUpDown.SelectedIndex == domainUpDown.Items.Count - 1)
            {
                domainUpDown.SelectedIndex = 1;
            }
            else if (domainUpDown.SelectedIndex == 0)
            {
                domainUpDown.SelectedIndex = domainUpDown.Items.Count - 2;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            laText.Font = new System.Drawing.Font("Microsoft Sans Serif", (int)numericUpDown1.Value);
        }
    }
}
