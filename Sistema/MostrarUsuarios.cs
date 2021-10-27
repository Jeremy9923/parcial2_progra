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
    public partial class MostrarUsuarios : Form
    {
        public MostrarUsuarios()
        {
            InitializeComponent();
        }
        Control cont = new Control();
        private void MostrarUsuarios_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cont.mostrar_usuario();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
