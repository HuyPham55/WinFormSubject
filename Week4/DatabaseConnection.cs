using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Week4
{
    class DatabaseConnection
    {
        public SqlConnection cnn;
        public SqlCommand cmd;
        public DataTable dta;
        public SqlDataAdapter ada;

        public void LetsConnect()
        {
            string connectionKey = @"Data Source=DESKTOP-IABFNUI\SQLEXPRESS;Initial Catalog=08072022;Integrated Security=True";
            cnn = new SqlConnection(connectionKey);
            cnn.Open();
        }
        public void CloseMyConnection()
        {
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }
        }

        public DataTable ExecuteQuery(string sql)
        {
            LetsConnect();

            ada = new SqlDataAdapter(sql, cnn);
            dta = new DataTable();
            ada.Fill(dta);
            return dta;
        }
    }
}
