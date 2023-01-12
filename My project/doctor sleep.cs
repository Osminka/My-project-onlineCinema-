using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_project
{
    public partial class doctor_sleep : Form
    {
        public doctor_sleep()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Probnaya ss = new Probnaya();
            ss.Show();
            this.Close();

            if (AllForm.count % 2 != 0)
            {
                doctor_sleep cc = new doctor_sleep();
                AllForm.favorites.Add(cc.Text);
            }
            AllForm.count = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Oplata ss = new Oplata();
            ss.Show();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            AllForm.count++;
            if (AllForm.count % 2 != 0)
            {
                siticoneButton1.Image = Properties.Resources._1814104_512__8_;
                //...
            }
            else
            {
                siticoneButton1.Image = Properties.Resources._1814104_512__1_;
                //...
            }
        }
    }
}
