using System;
using System.Drawing;
using System.Windows.Forms;

namespace My_project
{
    public partial class ВкладкаСериалы : UserControl
    {
        public ВкладкаСериалы()
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
            doctorH ss = new doctorH();
            
            ss.Show();       
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Probnaya form1 = (Probnaya)Application.OpenForms["Probnaya"]; // Где Form1 это имя формы содежащаяся в переменной Name.
            if (form1 != null) // Если форма существует, то изменяем свойства её объектов
            {
                form1.Close(); // Закрываем текущую форму
            }
            Plus ss = new Plus();
            ss.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Probnaya form1 = (Probnaya)Application.OpenForms["Probnaya"]; // Где Form1 это имя формы содежащаяся в переменной Name.
            if (form1 != null) // Если форма существует, то изменяем свойства её объектов
            {
                form1.Close(); // Закрываем текущую форму
            }
            chernobyl ss = new chernobyl();
            ss.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Probnaya form1 = (Probnaya)Application.OpenForms["Probnaya"]; // Где Form1 это имя формы содежащаяся в переменной Name.
            if (form1 != null) // Если форма существует, то изменяем свойства её объектов
            {
                form1.Close(); // Закрываем текущую форму
            }
            bones ss = new bones();
            ss.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Probnaya form1 = (Probnaya)Application.OpenForms["Probnaya"]; // Где Form1 это имя формы содежащаяся в переменной Name.
            if (form1 != null) // Если форма существует, то изменяем свойства её объектов
            {
                form1.Close();// Закрываем текущую форму
            }
            mentalist ss = new mentalist();
            ss.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Probnaya form1 = (Probnaya)Application.OpenForms["Probnaya"]; // Где Form1 это имя формы содежащаяся в переменной Name.
            if (form1 != null) // Если форма существует, то изменяем свойства её объектов
            {
                form1.Close(); // Закрываем текущую форму
            }
            peacky_blinders ss = new peacky_blinders();
            ss.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Probnaya form1 = (Probnaya)Application.OpenForms["Probnaya"]; // Где Form1 это имя формы содежащаяся в переменной Name.
            if (form1 != null) // Если форма существует, то изменяем свойства её объектов
            {
                form1.Close(); // Закрываем текущую форму
            }
            How_to_Get ss = new How_to_Get();
            ss.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Probnaya form1 = (Probnaya)Application.OpenForms["Probnaya"]; // Где Form1 это имя формы содежащаяся в переменной Name.
            if (form1 != null) // Если форма существует, то изменяем свойства её объектов
            {
                form1.Close(); // Закрываем текущую форму
            }
            black_mirror ss = new black_mirror();
            ss.Show();
        }

        private void ВкладкаСериалы_Load(object sender, EventArgs e)
        {

        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.ForeColor = Color.Silver;

        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Transparent;
        }

        private void label9_MouseMove(object sender, MouseEventArgs e)
        {
            label9.ForeColor = Color.Silver;
            label11.ForeColor = Color.Silver;
        }

        private void label9_MouseLeave(object sender, EventArgs e)
        {
            label9.ForeColor = Color.Transparent;
            label11.ForeColor = Color.Transparent;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Transparent;
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            label2.ForeColor = Color.Silver;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Transparent;
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            label3.ForeColor = Color.Silver;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Transparent;
        }

        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            label4.ForeColor = Color.Silver;
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7.ForeColor = Color.Transparent;
        }

        private void label7_MouseMove(object sender, MouseEventArgs e)
        {
            label7.ForeColor = Color.Silver;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Transparent;
            label8.ForeColor = Color.Transparent;
        }

        private void label6_MouseMove(object sender, MouseEventArgs e)
        {
            label6.ForeColor = Color.Silver;
            label8.ForeColor = Color.Silver;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Transparent;
        }

        private void label5_MouseMove(object sender, MouseEventArgs e)
        {
            label5.ForeColor = Color.Silver;
        }
    }
}
