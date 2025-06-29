using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Ets_yessad
{
    internal class Dbconnect1
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\djaafaryessad\OneDrive\Documents\Ets yessad\Ets yessad\Ets yessad\databaseyessad.mdf;Integrated Security=True");



        public SqlConnection getCon()
        {
            return connection;
        }
        public void OpenCon()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void CloseCon()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
    
}
