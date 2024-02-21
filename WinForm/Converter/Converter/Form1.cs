using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter
{
    public partial class Converter : Form
    {
        double Value;
        double Result;

        public Converter()
        {
            InitializeComponent();
        }

        
        private void btnConvert_Click(object sender, EventArgs e)
        {

            if (double.TryParse(textValue.Text,out Value))
            {

                if (radioMtoK.Checked)
                {
                    Result = Value * 0.001;
                    textResult.Text = Result.ToString();
                }
                else if (radioMtoMi.Checked)
                {
                    Result = Value * 0.0006;
                    textResult.Text = Result.ToString();
                }
                else if (radioMitoM.Checked)
                {
                    Result = Value * 1609.344;
                    textResult.Text = Result.ToString();
                }
                LaErrorValue.Text = "";
            }
            else
            {
                textResult.Text = "";
                LaErrorValue.Text = "Value must be number !";
            }
        }

        private void Converter_Load(object sender, EventArgs e)
        {

            int startingPoint = (this.Width / 8);
            String tmp = "";
            for (int i = 0; i < startingPoint; i++)
            {
                tmp += " ";
            }

            this.Text = $"{tmp}{this.Text}";
        }

       
    }
}
