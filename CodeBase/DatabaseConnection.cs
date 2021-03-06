using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBase
{
    class DatabaseConnection
    {
        public SqlConnection cnn;
        public SqlCommand cmd;
        public DataTable dta;
        public SqlDataAdapter ada;

        public void LetsConnect()
        {
            string connectionKey = @"Data Source=DESKTOP-VA254TL\SQLEXPRESS;Initial Catalog=06072022;Integrated Security=True";
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

        public DataTable GetData(string sql)
        {
            LetsConnect();

            ada = new SqlDataAdapter(sql, cnn);
            dta = new DataTable();
            ada.Fill(dta);
            return dta;
        }

      
        public void ExecuteQuery(string query)
        {
            LetsConnect();
            SqlCommand cmd = new SqlCommand(query, cnn);
            cmd.ExecuteNonQuery();
            CloseMyConnection();
        }

        public bool ResultExist(string query)
        {
            SqlCommand cmd = new SqlCommand(query, cnn);
            SqlDataReader flag = cmd.ExecuteReader();
            return flag.Read();
        }
    }
}
