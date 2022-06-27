using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DatabaseConnection cnn = new DatabaseConnection();
        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            string query = comboBox1.Text;
            dta = cnn.ExecuteQuery($"select * from NHANVIEN where ma_PB='{query}'");
            /*
             * Crystal report viewer
             * Add Existing Item => Browse to BaoCao_NhanVien                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     .rpt file
             * 
             * BaoCao_NhanVien Baocao = new BaoCao_NhanVien();
             * BaoCao.SetDataSource(dta)
             * CRV1.ReportSource = BaoCao;
             * 
             * */
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            string sql = "select * from PhongBan order by ma_PB";
            dta = cnn.ExecuteQuery(sql);
            comboBox1.DataSource = dta;
            comboBox1.DisplayMember = "ma_PB";
        }
    }
}
                         