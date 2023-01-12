using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace My_project
{
    public partial class Register : Form
    {
        
        public Register()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            LoginForm ss = new LoginForm();
            ss.Show();
            this.Close();
        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            AllForm.person = LoginR.Text;
            string connectString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = dbUsers.accdb";
            OleDbConnection conn = new OleDbConnection(connectString);
            conn.Open();
            OleDbCommand command = new OleDbCommand();
            command.CommandText = @"SELECT * FROM tblUsers WHERE [user]='" + LoginR.Text + "' AND [Никнейм]='" + nickname.Text + "'";
            command.Connection = conn;
            OleDbDataReader count = command.ExecuteReader();
            Console.WriteLine(count.HasRows);
            

            if (LoginR.Text.Equals(""))
            {
                MessageBox.Show("Введите логин.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (PassR.Text.Equals(""))
            {
                MessageBox.Show("Введите пароль.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nickname.Text.Equals(""))
            {
                MessageBox.Show("Введите никнейм.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (count.HasRows)
                {
                    MessageBox.Show("Аккаунт уже существует.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    command = new OleDbCommand();
                    command.CommandText = @"INSERT INTO [tblUsers] ([user],[pass],[Никнейм]) VALUES ('" + LoginR.Text + "','" + PassR.Text + "','" + nickname.Text + "')";
                    command.Connection = conn;
                    command.ExecuteNonQuery();
                    this.Hide();
                    MainForm cc = new MainForm();
                    cc.Show();
                }
                conn.Close();
            }
        }



    }
    
}

