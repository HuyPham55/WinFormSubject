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
    public partial class FormHangHoa : Form
    {
        public FormHangHoa()
        {
            InitializeComponent();
        }
        DatabaseConnection dbc = new DatabaseConnection();      
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormHangHoa_Load(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            string sql = "select * from Hanghoa";
            dta = dbc.GetData(sql);
            dataGridView1.DataSource = dta;
        }
    }
}
