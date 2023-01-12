using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_project
{
    class AllForm
    {
        public static string person = "";
        public static int count = 0;
        public static List<string> favorites = new List<string>();
        public static string textBox = "";
        public static void Bd()
        {
            Console.WriteLine(person);
            try
            {
                var result = String.Join(", ", favorites.ToArray());
                Console.WriteLine(result);
                string connectString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=dbUsers.accdb;";
                OleDbConnection conn = new OleDbConnection(connectString);
                conn.Open();
                OleDbCommand command = new OleDbCommand();
                //command.CommandText = @"INSERT INTO [tblUsers] [Избранное] VALUES ('" + result + "') WHERE [user]='" + person + "'";
                command.CommandText = @"UPDATE [tblUsers] SET [Избранное]='" + result + "' WHERE [user]='" + person + "'";

                command.Connection = conn;
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {

            }
        }
        public static string GetText()
        {
            return textBox;
        }

        
        
    }
}
