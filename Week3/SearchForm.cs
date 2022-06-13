using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Week3
{
    public partial class SearchForm : Form
    {
        DatabaseConnection connection = new DatabaseConnection();
        public SearchForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string keyword = textBox1.Text;
            string sql = $"select * from NHANVIEN where ma_NV like {keyword}";
            DataTable dta = new DataTable();
            dta = connection.ExecuteQuery(sql);
            dataGridView1.DataSource = dta;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
