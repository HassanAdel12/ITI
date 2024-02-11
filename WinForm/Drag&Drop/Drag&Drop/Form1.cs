using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drag_Drop
{
    public partial class Form1 : Form
    {
        private bool mouseIsDown = false;
        private Point firstPoint;

        public Form1()
        {
            InitializeComponent();
            

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            firstPoint = e.Location;
            mouseIsDown = true;
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseIsDown = false;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseIsDown)
            {
                int xDiff = firstPoint.X - e.Location.X;
                int yDiff = firstPoint.Y - e.Location.Y;

                int x = this.panel2.Location.X - xDiff;
                int y = this.panel2.Location.Y - yDiff;
                this.panel2.Location = new Point(x, y);
            }
        }
    }
}
