using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18_PhamDucHuy
{
    public partial class Form1 : Form
    {
        DatabaseConnection dbc = new DatabaseConnection();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult mNotifier;
            mNotifier = MessageBox.Show("Are you sure to exit?", "Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(mNotifier == DialogResult.Yes) {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            if (username.Length == 0 && password.Length == 0)
            {
                MessageBox.Show("Please enter credentials", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else {
                string sql = $"select * from DANGNHAP where Username='{username}' and MatKhau='{password}'";
                //dbc.ExecuteQuery(sql);
               
                if (dbc.ResultExist(sql))
                {
                    (new MainForm()).Show();
                    this.Visible = false;
                } else
                {
                    MessageBox.Show("Wrong credentials", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
    }
}
