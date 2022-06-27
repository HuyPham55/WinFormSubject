using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHAMDUCHUY_2206
{
    class DatabaseConnection
    {
        public SqlConnection cnn;
        public SqlCommand cmd;
        public DataTable dta;
        public SqlDataAdapter ada;

        public void LetsConnect()
        {
            string connectionKey = @"Data Source=DESKTOP-QAKVRQJ;Initial Catalog=PHAMDUCHUY;Integrated Security=True";
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

      
        /*
         * create proc sp_search_unit @id char(10)
         * as
         * being
         * select ma_NV as [Employer ID], ten_NV as [Employee name], nhanvien.ma_PB, ten_PB, he_so_luong, ma_CV, dien_thoai
         * from NHANVIEN, PHONGBAN
         * where PHONGBAN.ma_PB = HANVIEN.ma_PB and nhanvien.ma_PB = @ma_PB
         * end;
         * 
         * EXEC sp_search_uunit 'P4'
         * 
         * */
    }
}
