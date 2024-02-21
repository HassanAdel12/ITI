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

namespace DataGruid3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Add(new string[] { textName.Text, textPhone.Text, dateTime.Text });
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Text Document|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
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
}
