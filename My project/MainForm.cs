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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            joker ss = new joker();
            ss.Show();
            this.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            joker ss = new joker();
            ss.Show();
            this.Close();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Plus ss = new Plus();
            ss.Show();
            this.Close();

        }

        private void label9_Click(object sender, EventArgs e)
        {
            Plus ss = new Plus();
            ss.Show();
            this.Close();

        }
        private void label11_Click(object sender, EventArgs e)
        {
            Plus ss = new Plus();
            ss.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            bitva ss = new bitva();
            ss.Show();
            this.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            bitva ss = new bitva();
            ss.Show();
            this.Close();

        }
        private void label12_Click(object sender, EventArgs e)
        {
            bitva ss = new bitva();
            ss.Show();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            green_book ss = new green_book();
            ss.Show();
            this.Close();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            green_book ss = new green_book();
            ss.Show();
            this.Close();

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            doctor_sleep ss = new doctor_sleep();
            ss.Show();
            this.Close();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            doctor_sleep ss = new doctor_sleep();
            ss.Show();
            this.Close();

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            time ss = new time();
            ss.Show();
            this.Close();

        }

        private void label7_Click(object sender, EventArgs e)
        {
            time ss = new time();
            ss.Show();
            this.Close();

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Shutter_Island ss = new Shutter_Island();
            ss.Show();
            this.Close();

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Shutter_Island ss = new Shutter_Island();
            ss.Show();
            this.Close();

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Shutter_Island ss = new Shutter_Island();
            ss.Show();
            this.Close();

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            The_Shawshank_Redemption ss = new The_Shawshank_Redemption();
            ss.Show();
            this.Close();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            The_Shawshank_Redemption ss = new The_Shawshank_Redemption();
            ss.Show();
            this.Close();

        }

        private void label10_Click(object sender, EventArgs e)
        {
            The_Shawshank_Redemption ss = new The_Shawshank_Redemption();
            ss.Show();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Film ss = new Film();
            ss.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serials ss = new serials();
            ss.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cartoons ss = new cartoons();
            ss.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            compilations ss = new compilations();
            ss.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            search ss = new search();
            ss.Show();
            
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.ForeColor = Color.Maroon;

        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Transparent;
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

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Transparent;
        }

        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            label4.ForeColor = Color.Maroon;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Transparent;
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            label3.ForeColor = Color.Maroon;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Transparent;
            label12.ForeColor = Color.Transparent;
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            label2.ForeColor = Color.Maroon;
            label12.ForeColor = Color.Maroon;
        }

        private void label12_MouseLeave(object sender, EventArgs e)
        {
            label12.ForeColor = Color.Transparent;
            label2.ForeColor = Color.Transparent;
        }

        private void label12_MouseMove(object sender, MouseEventArgs e)
        {
            label12.ForeColor = Color.Maroon;
            label2.ForeColor = Color.Maroon;
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7.ForeColor = Color.Transparent;
        }

        private void label7_MouseMove(object sender, MouseEventArgs e)
        {
            label7.ForeColor = Color.Maroon;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Transparent;
        }

        private void label6_MouseMove(object sender, MouseEventArgs e)
        {
            label6.ForeColor = Color.Maroon;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Transparent;
            label10.ForeColor = Color.Transparent;
        }

        private void label5_MouseMove(object sender, MouseEventArgs e)
        {
            label5.ForeColor = Color.Maroon;
            label10.ForeColor = Color.Maroon;
        }

        private void label10_MouseLeave(object sender, EventArgs e)
        {
            label10.ForeColor = Color.Transparent;
            label5.ForeColor = Color.Transparent;
        }

        private void label10_MouseMove(object sender, MouseEventArgs e)
        {
            label10.ForeColor = Color.Maroon;
            label5.ForeColor = Color.Maroon;
        }
    }
}
