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
    public partial class bones : Form
    {
        public bones()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Probnaya ss = new Probnaya();
            ss.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Oplata ss = new Oplata();
            ss.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Probnaya ss = new Probnaya();
            ss.VisibleSerial();
            ss.Show();

            if (AllForm.count % 2 != 0)
            {
                bones cc = new bones();
                AllForm.favorites.Add(cc.Text);
            }
            AllForm.count = 0;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void siticoneControlBox2_Click(object sender, EventArgs e)
        {

        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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
