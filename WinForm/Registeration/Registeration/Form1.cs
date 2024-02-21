using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registeration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            bool Register = true;
            if (textName.Text.Length <= 5)
            {
                LaName.Text = "Name must contain at least 5 characters";
                Register = false;
            }
            else
            {
                LaName.Text = "";
            }

            if (!textEmail.Text.EndsWith("@gmail.com"))
            {
                LaEmail.Text = "Email must Ends With @gmail.com";
                Register = false;
            }
            else
            {
                LaEmail.Text = "";
            }

            if (!(radioMale.Checked || radioFemale.Checked ))
            {
                LaGender.Text = "must Choose at least one Gender";
                Register = false;
            }
            else
            {
                LaGender.Text = "";
            }

            if (!(checkFootball.Checked || checkTennis.Checked || checkSwimming.Checked))
            {
                LaHoppies.Text = "must Choose at least one Hoppy";
                Register = false;
            }
            else
            {
                LaHoppies.Text = "";
            }

            if (Register)
            {
                LaRegister.Text = "Thank you, Your Registeration is valid";
            }
            else
            {
                LaRegister.Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
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
