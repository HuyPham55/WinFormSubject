using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18_PhamDucHuy.ChildrenForms
{
    public partial class InboundForm : Form
    {
        DatabaseConnection dbc = new DatabaseConnection();
        public InboundForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult mNotifier;
            mNotifier = MessageBox.Show("Are you sure to exit?", "Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (mNotifier == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void InboundForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCustomers();
            LoadReceipts();
        }

        private void LoadProducts()
        {
            DataTable dta = new DataTable();
            string sql = "select * from Hanghoa";
            dta = dbc.GetData(sql);
            comboBox1.DataSource = dta;
            comboBox1.ValueMember = "mahang";
            comboBox1.DisplayMember = "tenhang";
        }

        private void LoadCustomers()
        {
            DataTable dta = new DataTable();
            string sql = "select * from Khachhang";
            dta = dbc.GetData(sql);
            comboBox2.DataSource = dta;
            comboBox2.ValueMember = "makhach";
            comboBox2.DisplayMember = "hoten";
        }

        private void LoadReceipts()
        {
            DataTable dta = new DataTable();
            string sql = "select * from Phieuthu";
            dta = dbc.GetData(sql);
            dataGridView1.DataSource = dta;

            if (dbc.ResultExist(sql))
            {
                button2.Enabled = false;
            }
        }




        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            comboBox1.SelectedIndex = 0;

            comboBox2.SelectedIndex = 0;

            numericUpDown1.Value = 0;

            textBox6.Clear();

            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = $"select sophieu from Phieuthu where sophieu = {textBox1.Text}";
            if (dbc.ResultExist(sql))
            {
                MessageBox.Show("Already exist", "Alert!");
            } else
            {
                sql = $"insert into Phieuthu values (" +
                   $"'{textBox1.Text}'," +
                   $"'{comboBox1.SelectedValue}'," +
                   $"'{comboBox2.SelectedValue}'," +
                   $"'{dateTimePicker1.Value}'," +
                   $" {numericUpDown1.Value}," +
                   $" {numericUpDown2.Value}," +
                   $"'{textBox6.Text}'" +
                   $")";

             
                dbc.ExecuteQuery(sql);
                LoadReceipts();
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Are you want to delete?", "Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes && textBox1.Text.Length != 0)
            {
                string sql = $"delete from Phieuthu where sophieu = {textBox1.Text}";
                dbc.ExecuteQuery(sql);
                LoadReceipts();
            }
            else
            {
                this.Close();
            }
        }
    }
}
