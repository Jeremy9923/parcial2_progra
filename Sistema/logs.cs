using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class logs : Form
    {
        public logs()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void logs_Load(object sender, EventArgs e)
        {
            Control control = new Control();
            dataGridView1.DataSource = control.mostrar_log();
        }
    }
}
