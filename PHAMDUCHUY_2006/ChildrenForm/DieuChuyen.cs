using PHAMDUCHUY_20062022;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHAMDUCHUY_2006.ChildrenForm
{
    public partial class DieuChuyen : Form
    {
        DatabaseConnection connection = new DatabaseConnection();
        public DieuChuyen()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DieuChuyen_Load(object sender, EventArgs e)
        {
            string sql = $"select * from dieuchuyen";
            DataTable dta = new DataTable();
            dta = connection.ExecuteQuery(sql);
            dataGridView1.DataSource = dta;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string ngaydc = textBox3.Text;
            string tinhtrang = textBox6.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
