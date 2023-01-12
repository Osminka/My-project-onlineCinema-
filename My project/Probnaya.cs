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
    
    public partial class Probnaya : Form
    {
        public Probnaya()
        {
            InitializeComponent();
            siticoneShadowForm.SetShadowForm(this);
        }

        private void siticoneButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (siticoneButton1.Checked)
            {
                избранное1.ChangeText(String.Join(",", AllForm.favorites.ToArray()));
                избранное1.BringToFront();
                AllForm.Bd();
                AllForm.count = 0;
            }
        }

        private void siticoneButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (siticoneButton2.Checked) вкладкаФильмы1.BringToFront();
        }

        public void siticoneButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (siticoneButton3.Checked) вкладкаСериалы1.BringToFront();
        }

        private void siticoneButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (siticoneButton4.Checked) вкладкаМультики1.BringToFront();
        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            LoginForm ss = new LoginForm();
            ss.Show();
            this.Close();
           
        }

        public void VisibleSerial()
        {
            вкладкаСериалы1.BringToFront();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
