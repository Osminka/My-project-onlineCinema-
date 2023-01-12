using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_project
{
    class oCenter
    {
        OleDbDataAdapter oleDaAc = new OleDbDataAdapter();
        OleDbConnection oleCon = new OleDbConnection();

        public static string LoginR = "";
        public static string PassR = "";
        public static string nickname = "";
        private bool bCheckConnect = false;

        private void ConnectDB()
        {
            try
            {
                bCheckConnect = false;
                string sPath = System.Windows.Forms.Application.StartupPath.ToLower();
                string sDatabase = "dbUsers.accdb";
                string sConn = "Provider = Microsoft.ACE.OLEDB.12.0; data source =" + sPath + "\\" + sDatabase;

                if (oleCon.State == ConnectionState.Open)
                {
                    oleCon.Close();
                }

                oleCon.ConnectionString = sConn;
                oleCon.Open();
                bCheckConnect = true;

            }
            catch (Exception ex)
            {
                bCheckConnect = false;
                MessageBox.Show("Error : " + ex.Message.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public DataSet ShowData(string _sSql, string _sTable, DataSet _ds)
        {
            DataSet dsSet;
            if (!bCheckConnect)
            {
                ConnectDB();
            }

            try
            {
                _ds.Clear();
                oleDaAc = new OleDbDataAdapter(_sSql, oleCon);
                OleDbCommandBuilder builder = new OleDbCommandBuilder(oleDaAc);
                oleDaAc.Fill(_ds, _sTable);
                dsSet = _ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dsSet = null;
            }
            finally
            {
                bCheckConnect = false;
                oleCon.Close();
            }

            return dsSet;
        }

        public OleDbDataAdapter ReturnAda
        {
            get
            {
                return oleDaAc;
            }
            set
            {
                oleDaAc = value;
            }
        }

    }
}
