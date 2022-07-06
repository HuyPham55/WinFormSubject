using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHAMDUCHUY_2206.ChildrenForm
{
    public partial class StaffForm : Form
    {
        DatabaseConnection cnn = new DatabaseConnection();

        public StaffForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fetchData()
        {
            string sql = "select * from DM_CANBO";
            DataTable dta = cnn.ExecuteQuery(sql);
            dataGridView1.DataSource = dta;
            dta = cnn.ExecuteQuery("select MAPB from DM_PHONGBAN");
            comboBox1.Items.Clear();
            foreach (DataRow row in dta.Rows)
            {
                comboBox1.Items.Add(row["MAPB"]);
            }

            textBox1.DataBindings.Clear();
            textBox1.DataBindings.Add("Text", dataGridView1.DataSource, "MACB");

            textBox2.DataBindings.Clear();
            textBox2.DataBindings.Add("Text", dataGridView1.DataSource, "HOTEN");

            textBox3.DataBindings.Clear();
            textBox3.DataBindings.Add("Text", dataGridView1.DataSource, "NGAYSINH");

            textBox4.DataBindings.Clear();
            textBox4.DataBindings.Add("Text", dataGridView1.DataSource, "GIOITINH");

            textBox5.DataBindings.Clear();
            textBox5.DataBindings.Add("Text", dataGridView1.DataSource, "DIACHI");

            textBox6.DataBindings.Clear();
            textBox6.DataBindings.Add("Text", dataGridView1.DataSource, "CHUCVU");

            textBox1.DataBindings.Clear();
            textBox1.DataBindings.Add("Text", dataGridView1.DataSource, "MACB");

            textBox8.DataBindings.Clear();
            textBox8.DataBindings.Add("Text", dataGridView1.DataSource, "HOCHAM");

            textBox9.DataBindings.Clear();
            textBox9.DataBindings.Add("Text", dataGridView1.DataSource, "HOCVI");

        }
       
        private void StaffForm_Load(object sender, EventArgs e)
        {
            fetchData();
            button2.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();

            textBox3.Clear();

            textBox4.Clear();

            textBox5.Clear();

            textBox6.Clear();

            textBox8.Clear();
            textBox9.Clear();

            button2.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = $"select MACB from DM_CANBO where MACB = {textBox1.Text}";
            SqlCommand cmd = new SqlCommand(sql, cnn.cnn);
            SqlDataReader flag = cmd.ExecuteReader();
            if (flag.Read())
            {
                MessageBox.Show("Already exist", "Alert!");
                flag.Close();
                flag.Dispose();
            }
            else
            {
                sql = $"insert into DM_CANBO values (" +
                    $"'{textBox1.Text}'," +
                    $"'{textBox2.Text}'," +
                    $"'{textBox3.Text}'," +
                    $"'{textBox4.Text}'," +
                    $"'{textBox5.Text}'," +
                    $"'{textBox6.Text}'," +
                    $"'{comboBox1.Text}',"+
                    $"'{textBox8.Text}'," +
                    $"'{textBox9.Text}'" +
                    $")";
                //MessageBox.Show(sql);
                flag.Close();
                flag.Dispose();
                cmd = new SqlCommand(sql, cnn.cnn);
                flag = cmd.ExecuteReader();
                flag.Close();
                flag.Dispose();
                fetchData();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = $"update DM_CANBO set " +
                $"HOTEN = '{textBox2.Text}', " +
                $"NGAYSINH = '{textBox3.Text}', " +
                $"GIOITINH = '{textBox4.Text}', " +
                $"DIACHI = '{textBox5.Text}', " +
                $"CHUCVU = '{textBox6.Text}', " +
                $"MAPB = '{comboBox1.Text}', " +
                $"HOCHAM = '{textBox2.Text}', " +
                $"HOCVI = '{textBox8.Text}' " +
                $"where MACB = {textBox1.Text}";
            SqlCommand cmd = new SqlCommand(sql, cnn.cnn);
            SqlDataReader flag = cmd.ExecuteReader();
            flag.Close();
            flag.Dispose();
            fetchData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Are you want to delete?", "Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string sql = $"delete from DM_CANBO where MACB = {textBox1.Text}";
                SqlCommand cmd = new SqlCommand(sql, cnn.cnn);
                SqlDataReader flag = cmd.ExecuteReader();
                flag.Close();
                flag.Dispose();
                fetchData();
            } else
            {
                this.Close();
            }
         
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Are you want to exit?", "Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            fetchData();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            fetchData();
        }
    }
}
