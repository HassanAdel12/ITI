using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGruid2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChooseLocation_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Text Document|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textSelectedPath.Text = openFileDialog.FileName;
                string[] raw_text = System.IO.File.ReadAllLines(openFileDialog.FileName);
                string[] data_col = null;

                foreach (string text_line in raw_text)
                {
                    
                    data_col = text_line.Split('|');
                    dataGridView.Rows.Add(data_col);
                    
                }
            }

        }
    }
}
