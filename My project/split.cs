﻿using System;
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
    public partial class split : Form
    {
        public split()
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
                split cc = new split();
                AllForm.favorites.Add(cc.Text);
            }
            AllForm.count = 0;
        }

        private void button1_Click(object sender, EventArgs e)
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
