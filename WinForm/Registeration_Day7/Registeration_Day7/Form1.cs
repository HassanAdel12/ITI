using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Registeration_Day7
{
    public partial class Form1 : Form
    {
        bool Register = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textFirstName.Text = string.Empty;
            textLastName.Text = string.Empty;
            textEmail.Text = string.Empty;
            textPassword.Text = string.Empty;
            textConfirmPassword.Text = string.Empty;
            textDate.Text = string.Empty;
            textPhone.Text = string.Empty;
            textAddress.Text = string.Empty;
            radioMale.Checked = false;
            radioFemale.Checked = false;
            laFristName.Text = string.Empty;
            laLastName.Text = string.Empty;
            laEmail.Text = string.Empty;
            laPassword.Text = string.Empty;
            lagender.Text = string.Empty;
            laDate.Text = string.Empty;
            laPhone.Text = string.Empty;
            laAddress.Text = string.Empty;
            laSubmit.Text = string.Empty;
        }

        private void textFirstName_TextChanged(object sender, EventArgs e)
        {
            if (textFirstName.Text.Length < 3 )
            {
                laFristName.Text = "Frist Name must contain at least 5 characters";
                Register = false;
            }
            else
            {
                laFristName.Text = string.Empty;
                Register = true;
            }
        }

        private void textLastName_TextChanged(object sender, EventArgs e)
        {
            if (textLastName.Text.Length < 3 )
            {
                laLastName.Text = "Last Name must contain at least 5 characters";
                Register = false;
            }
            else
            {
                laLastName.Text = string.Empty;
                Register = true;
            }
        }

        private void textEmail_TextChanged(object sender, EventArgs e)
        {
            if (!textEmail.Text.EndsWith("@gmail.com"))
            {
                laEmail.Text = "Email must Ends With @gmail.com";
                Register = false;
            }
            else
            {
                laEmail.Text = string.Empty;
                Register = true;
            }
        }

        private void textConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (textPassword.Text != textConfirmPassword.Text || textPassword.Text.Length < 3 )
            {
                laPassword.Text = "Password and Confirm Password didn't matched";
                Register = false;
            }
            else
            {
                laPassword.Text = string.Empty;
                Register = true;
            }
        }

        private void textDate_TextChanged(object sender, EventArgs e)
        {
            if (textDate.Text.Length <= 6)
            {
                laDate.Text = "invaild format matched";
                Register = false;
            }
            else
            {
                if (textDate.Text.Length != 10 ||
                    textDate.Text.ElementAt(2) != '/' ||
                    textDate.Text.ElementAt(5) != '/')
                {
                    laDate.Text = "invaild format matched";
                    Register = false;
                }
                else
                {
                    laDate.Text = string.Empty;
                    Register = true;
                }
            }
        }

        private void textPhone_TextChanged(object sender, EventArgs e)
        {
            if (!(textPhone.Text.StartsWith("01") && textPhone.Text.Length == 11 ))
            {
                laPhone.Text = "not match 01#########";
                Register = false;
            }
            else
            {
                laPhone.Text = string.Empty;
                Register = true;
            }
        }

        private void textAddress_TextChanged(object sender, EventArgs e)
        {
            if (textAddress.Text == string.Empty)
            {
                laAddress.Text = "Invaild ..";
                Register = false;
            }
            else
            {
                laAddress.Text = string.Empty;
                Register = true;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            textFirstName_TextChanged(sender, e);
            textLastName_TextChanged(sender, e);
            textEmail_TextChanged(sender, e);
            textConfirmPassword_TextChanged(sender, e);
            textDate_TextChanged(sender, e);
            textPhone_TextChanged(sender, e);
            textAddress_TextChanged(sender,e);

            if (!(radioMale.Checked || radioFemale.Checked))
            {
                lagender.Text = "must Choose at least one Gender";
                Register = false;
            }
            else
            {
                lagender.Text = string.Empty;
                Register = true;
            }

            if (Register)
            {
                laSubmit.Text = "Thank you, Your Registeration is valid";
            }
            else
            {
                laSubmit.Text = string.Empty;
            }
        }

        
    }
}
