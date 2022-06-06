using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week2
{
    public partial class WhatsMyAge : Form
    {
        public WhatsMyAge()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult mNotifier;
            mNotifier = MessageBox.Show(Convert.ToString(Convert.ToInt32(textBox1.Text)), "Your age is", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
