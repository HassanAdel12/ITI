using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string op = string.Empty;
        double fristNum;
        double SecondNum;
        double Result = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Eql_Click(object sender, EventArgs e)
        {
            
            if(!(double.TryParse(Txt.Text, out SecondNum)))
            {
                SecondNum = 0;
            }
            



            if (op == "add")
            {
                Result = fristNum + SecondNum;
            }
            else if (op == "sub")
            {
                Result = fristNum - SecondNum;
            }
            else if (op == "mul")
            {
                Result = fristNum * SecondNum;
            }
            else if (op == "div")
            {
                if (SecondNum != 0)
                    Result = fristNum / SecondNum;
                else
                    MessageBox.Show("Error divide by zero");
            }
            Txt.Text = Result.ToString();
            op = string.Empty;
        }

        private void C_Click(object sender, EventArgs e)
        {
            Txt.Text = string.Empty;
            fristNum = 0;
            SecondNum = 0;
            Result = 0;
            op = string.Empty;
        }

        //public void num_Click()
        //{
        //    Txt.Text += num0.Text;
        //}

        private void num0_Click(object sender, EventArgs e)
        {
            Txt.Text += num0.Text;
        }

        private void num1_Click(object sender, EventArgs e)
        {
            Txt.Text += num1.Text;
        }

        private void num2_Click(object sender, EventArgs e)
        {
            Txt.Text += num2.Text;
        }

        private void num3_Click(object sender, EventArgs e)
        {
            Txt.Text += num3.Text;
        }

        private void num4_Click(object sender, EventArgs e)
        {
            Txt.Text += num4.Text;
        }

        private void num5_Click(object sender, EventArgs e)
        {
            Txt.Text += num5.Text;
        }

        private void num6_Click(object sender, EventArgs e)
        {
            Txt.Text += num6.Text;
        }

        private void num7_Click(object sender, EventArgs e)
        {
            Txt.Text += num7.Text;
        }

        private void num8_Click(object sender, EventArgs e)
        {
            Txt.Text += num8.Text;
        }

        private void num9_Click(object sender, EventArgs e)
        {
            Txt.Text += num9.Text;
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            Txt.Text += Dot.Text;
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (op == string.Empty) {
                if (!(double.TryParse(Txt.Text, out fristNum)))
                {
                    fristNum = 0;
                }
                op = "add";
                Txt.Text = string.Empty;
            }
            else
            {
                if (!(double.TryParse(Txt.Text, out SecondNum)))
                {
                    SecondNum = 0;
                }

                if (op == "add")
                {
                    Result = fristNum + SecondNum;
                }
                else if (op == "sub")
                {
                    Result = fristNum - SecondNum;
                }
                else if (op == "mul")
                {
                    Result = fristNum * SecondNum;
                }
                else if (op == "div")
                {
                    if (SecondNum != 0)
                        Result = fristNum / SecondNum;
                    else
                        MessageBox.Show("Error divide by zero");
                }
                fristNum = Result;
                op = "add";
                Txt.Text = string.Empty;
            }
        }

        private void Sub_Click(object sender, EventArgs e)
        {
            if (op == string.Empty)
            {
                if (!(double.TryParse(Txt.Text, out fristNum)))
                {
                    fristNum = 0;
                }
                op = "sub";
                Txt.Text = string.Empty;
            }
            else
            {
                if (!(double.TryParse(Txt.Text, out SecondNum)))
                {
                    SecondNum = 0;
                }

                if (op == "add")
                {
                    Result = fristNum + SecondNum;
                }
                else if (op == "sub")
                {
                    Result = fristNum - SecondNum;
                }
                else if (op == "mul")
                {
                    Result = fristNum * SecondNum;
                }
                else if (op == "div")
                {
                    if (SecondNum != 0)
                        Result = fristNum / SecondNum;
                    else
                        MessageBox.Show("Error divide by zero");
                }
                fristNum = Result;
                op = "sub";
                Txt.Text = string.Empty;
            }
        }

        private void Mul_Click(object sender, EventArgs e)
        {
            if (op == string.Empty)
            {
                if (!(double.TryParse(Txt.Text, out fristNum)))
                {
                    fristNum = 0;
                }
                op = "mul";
                Txt.Text = string.Empty;
            }
            else
            {
                if (!(double.TryParse(Txt.Text, out SecondNum)))
                {
                    SecondNum = 0;
                }

                if (op == "add")
                {
                    Result = fristNum + SecondNum;
                }
                else if (op == "sub")
                {
                    Result = fristNum - SecondNum;
                }
                else if (op == "mul")
                {
                    Result = fristNum * SecondNum;
                }
                else if (op == "div")
                {
                    if (SecondNum != 0)
                        Result = fristNum / SecondNum;
                    else
                        MessageBox.Show("Error divide by zero");
                }
                fristNum = Result;
                op = "mul";
                Txt.Text = string.Empty;
            }
        }

        private void Div_Click(object sender, EventArgs e)
        {
            if (op == string.Empty)
            {
                if (!(double.TryParse(Txt.Text, out fristNum)))
                {
                    fristNum = 0;
                }
                op = "div";
                Txt.Text = string.Empty;
            }
            else
            {
                if (!(double.TryParse(Txt.Text, out SecondNum)))
                {
                    SecondNum = 0;
                }

                if (op == "add")
                {
                    Result = fristNum + SecondNum;
                }
                else if (op == "sub")
                {
                    Result = fristNum - SecondNum;
                }
                else if (op == "mul")
                {
                    Result = fristNum * SecondNum;
                }
                else if (op == "div")
                {
                    if (SecondNum != 0)
                        Result = fristNum / SecondNum;
                    else
                        MessageBox.Show("Error divide by zero");
                }
                fristNum = Result;
                op = "div";
                Txt.Text = string.Empty;
            }
        }
    }
}
