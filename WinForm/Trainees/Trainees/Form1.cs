using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trainees
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

            List<String> LTrainee = new List<String>();
            LTrainee.Add("Ahmed");
            LTrainee.Add("Aly");
            LTrainee.Add("Mohamed");
            LTrainee.Add("Sayed");
            LTrainee.Add("Peter");
            LTrainee.Add("Hosam");
            LTrainee.Add("Beshoy");

            Trainee.Items.AddRange(LTrainee.ToArray());

            List<String> LLabTrainee = new List<String>();
            LLabTrainee.Add("Hytham");
            LLabTrainee.Add("Hany");
            LLabTrainee.Add("Mahmoud");

            TabTrainee.Items.AddRange(LLabTrainee.ToArray());

        }

        private void btnSTraineeToLab_Click(object sender, EventArgs e)
        {
            foreach (var item in Trainee.CheckedItems.OfType<string>().ToList())
            {
                TabTrainee.Items.Add(item);
                Trainee.Items.Remove(item);
            }
        }

        private void btnTTraineeToLab_Click(object sender, EventArgs e)
        {
            TabTrainee.Items.AddRange(Trainee.Items);
            Trainee.Items.Clear();
        }

        private void btnSTabToTrainee_Click(object sender, EventArgs e)
        {
            foreach (var item in TabTrainee.CheckedItems.OfType<string>().ToList())
            {
                Trainee.Items.Add(item);
                TabTrainee.Items.Remove(item);
            }
        }

        private void btnTTabToTrainee_Click(object sender, EventArgs e)
        {
            Trainee.Items.AddRange(TabTrainee.Items);
            TabTrainee.Items.Clear();
        }
    }
}
