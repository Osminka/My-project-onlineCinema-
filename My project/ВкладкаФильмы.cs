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
    public partial class ВкладкаФильмы : UserControl
    {
        public ВкладкаФильмы()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Probnaya form1 = (Probnaya)Application.OpenForms["Probnaya"]; // Где Form1 это имя формы содежащаяся в переменной Name.
            if (form1 != null) // Если форма существует, то изменяем свойства её объектов
            {
                form1.Close(); // Закрываем текущую форму
            }
            joker ss = new joker();
            ss.Show();
            
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Probnaya form1 = (Probnaya)Application.OpenForms["Probnaya"]; // Где Form1 это имя формы содежащаяся в переменной Name.
            if (form1 != null) // Если форма существует, то изменяем свойства её объектов
            {
                form1.Close(); // Закрываем текущую форму
            }
            doctor_sleep ss = new doctor_sleep();
            ss.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Probnaya form1 = (Probnaya)Application.OpenForms["Probnaya"]; // Где Form1 это имя формы содежащаяся в переменной Name.
            if (form1 != null) // Если форма существует, то изменяем свойства её объектов
            {
                form1.Close(); // Закрываем текущую форму
            }
            green_book ss = new green_book();
            ss.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Probnaya form1 = (Probnaya)Application.OpenForms["Probnaya"]; // Где Form1 это имя формы содежащаяся в переменной Name.
            if (form1 != null) // Если форма существует, то изменяем свойства её объектов
            {
                form1.Close(); // Закрываем текущую форму
            }
            bitva ss = new bitva();
            ss.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Probnaya form1 = (Probnaya)Application.OpenForms["Probnaya"]; // Где Form1 это имя формы содежащаяся в переменной Name.
            if (form1 != null) // Если форма существует, то изменяем свойства её объектов
            {
                form1.Close(); // Закрываем текущую форму
            }
            time ss = new time();
            ss.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Probnaya form1 = (Probnaya)Application.OpenForms["Probnaya"]; // Где Form1 это имя формы содежащаяся в переменной Name.
            if (form1 != null) // Если форма существует, то изменяем свойства её объектов
            {
                form1.Close(); // Закрываем текущую форму
            }
            Shutter_Island ss = new Shutter_Island();
            ss.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Probnaya form1 = (Probnaya)Application.OpenForms["Probnaya"]; // Где Form1 это имя формы содежащаяся в переменной Name.
            if (form1 != null) // Если форма существует, то изменяем свойства её объектов
            {
                form1.Close(); // Закрываем текущую форму
            }
            The_Shawshank_Redemption ss = new The_Shawshank_Redemption();
            ss.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Probnaya form1 = (Probnaya)Application.OpenForms["Probnaya"]; // Где Form1 это имя формы содежащаяся в переменной Name.
            if (form1 != null) // Если форма существует, то изменяем свойства её объектов
            {
                form1.Close(); // Закрываем текущую форму
            }
            split ss = new split();
            ss.Show();
        }

        private void ВкладкаФильмы_Load(object sender, EventArgs e)
        {

        }
    }
}
