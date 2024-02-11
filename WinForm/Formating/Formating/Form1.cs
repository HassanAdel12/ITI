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

namespace Formating
{
    public partial class Form1 : Form
    {
        Form2 Form2;

        public Form1()
        {
            InitializeComponent();
        }

        public void checkColor (Color c)
        {
            richTextBox.ForeColor = c;
        }
        public void checkFont(Font f)
        {
            richTextBox.Font = f;
        }

        private void BtnFormat_Click(object sender, EventArgs e)
        {
            if (richTextBox.Text == "")
            {
                MessageBox.Show("Write a word ..");
            }
            else
            {
                if (Form2 == null)
                {
                    Form2 = new Form2(this);
                }

                Form2.Show();
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
