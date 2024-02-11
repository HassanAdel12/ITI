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
    public partial class Form2 : Form
    {
        Form1 formFormat;
        FontStyle BoldStyle, ItalicStyle, UnderLineStyle;
       

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.formFormat = form1;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            List<string> Fonts = new List<string>();
            Fonts.Add("Arial");
            Fonts.Add("Calibri");
            Fonts.Add("Batang");
            Fonts.Add("Chiller");
            comboBox.DataSource = Fonts;


        }

        private void Red_CheckedChanged(object sender, EventArgs e)
        {
            if (Red.Checked)
            {
                ColorText.Color = System.Drawing.Color.Red;
            }
        }

        private void Green_CheckedChanged(object sender, EventArgs e)
        {
            if (Green.Checked)
            {
                ColorText.Color = System.Drawing.Color.Green;
            }
        }


        private void Blue_CheckedChanged(object sender, EventArgs e)
        {
            if (Blue.Checked)
            {
                ColorText.Color = System.Drawing.Color.Blue;
            }
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            int size;
            if (int.TryParse(TextSize.Text,out size))
            {
                if(size >= 0 && size <= 150)
                {
                    FontText.Font = new System.Drawing.Font
                        (comboBox.SelectedItem.ToString(), size, BoldStyle | ItalicStyle | UnderLineStyle);

                }
                else
                {
                    FontText.Font = new System.Drawing.Font
                        (comboBox.SelectedItem.ToString(), 150, BoldStyle | ItalicStyle | UnderLineStyle);
                }

                formFormat.checkColor(ColorText.Color);
                formFormat.checkFont(FontText.Font);
                
                this.Hide();

            }
            else
            {
                MessageBox.Show("invaild ..");
            }

        }


        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }


        private void Bold_CheckedChanged(object sender, EventArgs e)
        {
            if (Bold.Checked)
            {
                BoldStyle = System.Drawing.FontStyle.Bold;
            }
            else
            {
                BoldStyle = FontStyle.Regular;
            }
            
        }

        private void Italic_CheckedChanged(object sender, EventArgs e)
        {
            if (Italic.Checked)
            {
                ItalicStyle = System.Drawing.FontStyle.Italic;
            }
            else
            {
                ItalicStyle = FontStyle.Regular;
            }
        }

        private void UnderLine_CheckedChanged(object sender, EventArgs e)
        {
            if (UnderLine.Checked)
            {
                UnderLineStyle = System.Drawing.FontStyle.Underline;
            }
            else
            {
                UnderLineStyle = FontStyle.Regular;
            }
        }

        
    }
}
