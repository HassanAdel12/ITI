using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DataGruid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DataGruid_Load(object sender, EventArgs e)
        {

        }

        private void btnChooseLocation_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Text Document|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textSelectedPath.Text = openFileDialog.FileName;

            }
        }

        private void btnAddToDataGruid_Click(object sender, EventArgs e)
        {
            
            dataGridView.Rows.Add(new string[] { textName.Text, textAddress.Text, textSalary.Text, dateTime.Text});

        }

        private void btnSaveDataToFile_Click(object sender, EventArgs e)
        {
            using (TextWriter tw = new StreamWriter(openFileDialog.FileName))
            {
                for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        tw.Write($"{dataGridView.Rows[i].Cells[j].Value.ToString()}");

                        if (!(j == dataGridView.Columns.Count - 1))
                        {
                            tw.Write("|");
                        }
                    }
                    tw.WriteLine();
                }
            }
            
        }


    }
}
