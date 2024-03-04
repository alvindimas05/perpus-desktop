using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerpustakaanSigma
{
    public class Database
    {
        public static OdbcConnection Connect()
        {
            var conn = new OdbcConnection("dsn=MSSQL;database=perpustakaan;");
            try
            {
                conn.Open();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Application.Exit();
            }
            return conn;
        }
    }
}
