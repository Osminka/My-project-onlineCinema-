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
    public partial class serials : Form
    {
        public serials()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            serials ss = new serials();
            ss.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            chernobyl ss = new chernobyl();
            ss.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            chernobyl ss = new chernobyl();
            ss.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            doctorH ss = new doctorH();
            ss.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            doctorH ss = new doctorH();
            ss.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm ss = new MainForm();
            ss.Show();
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Transparent;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.ForeColor = Color.Maroon;
        }

        private void label9_MouseLeave(object sender, EventArgs e)
        {
            label9.ForeColor = Color.Transparent;
            label11.ForeColor = Color.Transparent;
        }

        private void label9_MouseMove(object sender, MouseEventArgs e)
        {
            label9.ForeColor = Color.Maroon;
            label11.ForeColor = Color.Maroon;
        }

        private void label11_MouseLeave(object sender, EventArgs e)
        {
            label11.ForeColor = Color.Transparent;
            label9.ForeColor = Color.Transparent;
        }

        private void label11_MouseMove(object sender, MouseEventArgs e)
        {
            label11.ForeColor = Color.Maroon;
            label9.ForeColor = Color.Maroon;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Transparent;
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            label3.ForeColor = Color.Maroon;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Transparent;
        }

        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            label4.ForeColor = Color.Maroon;
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7.ForeColor = Color.Transparent;
        }

        private void label7_MouseMove(object sender, MouseEventArgs e)
        {
            label7.ForeColor = Color.Maroon;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Transparent;
        }

        private void label5_MouseMove(object sender, MouseEventArgs e)
        {
            label5.ForeColor = Color.Maroon;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Transparent;
            label8.ForeColor = Color.Transparent;
        }

        private void label6_MouseMove(object sender, MouseEventArgs e)
        {
            label6.ForeColor = Color.Maroon;
            label8.ForeColor = Color.Maroon;
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Transparent;
            label8.ForeColor = Color.Transparent;
        }

        private void label8_MouseMove(object sender, MouseEventArgs e)
        {
            label8.ForeColor = Color.Maroon;
            label6.ForeColor = Color.Maroon;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Transparent;
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            label2.ForeColor = Color.Maroon;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
