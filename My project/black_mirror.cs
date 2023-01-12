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
    public partial class black_mirror : Form
    {
        
        public black_mirror()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {         
            this.Close();
            Probnaya ss = new Probnaya();
            ss.VisibleSerial();
            ss.Show();


            if (AllForm.count % 2 != 0)
            {
                black_mirror cc = new black_mirror();
                AllForm.favorites.Add(cc.Text);
            }
            AllForm.count = 0;

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
