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

namespace Week2
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        mDataConnection mConnection = new mDataConnection();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            string query = "Select * from CHUCVU";
            dta = mConnection.ExecuteQuery(query);
            dataGridView1.DataSource = dta;
        }
    }
}
