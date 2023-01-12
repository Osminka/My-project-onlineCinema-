using System;
using System.Drawing;
using System.Data.OleDb;
using System.Windows.Forms;

namespace My_project
{
    public partial class LoginForm : Form
    {
       
        public LoginForm()
        {
            InitializeComponent();
            this.Pass.AutoSize = false;
            this.Pass.Size = new Size(this.Pass.Size.Width, 33);
        }
        private void buttonlogin_Click(object sender, EventArgs e)
        {
            AllForm.person = Login.Text;
            string connectString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = dbUsers.accdb";
            OleDbConnection conn = new OleDbConnection(connectString);
            conn.Open();
            OleDbCommand command = new OleDbCommand();
            command.CommandText = @"SELECT COUNT (*) FROM tblUsers WHERE [user]='" + Login.Text + "' AND [pass]='" + Pass.Text + "'";
            command.Connection = conn;
            int count = (int)command.ExecuteScalar();
            if (count > 0)
            {
                this.Hide();
                Probnaya ss = new Probnaya();
                ss.Show();       
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register ss = new Register();
            ss.Show();
        }

    }
}
