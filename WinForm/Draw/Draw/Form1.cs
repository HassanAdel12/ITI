using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw
{
    public partial class Form1 : Form
    {
        private bool mouseIsDown = false;

        public Form1()
        {
            InitializeComponent();
        }


        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseIsDown)
            {
                Graphics G = panel1.CreateGraphics();
                Brush brush = new SolidBrush(Color.Blue);
                G.FillEllipse(brush, e.X, e.Y, 25, 25);

            }
                
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseIsDown = true;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseIsDown = false;
        }
    }
}
