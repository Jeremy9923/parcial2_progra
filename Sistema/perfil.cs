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
    public partial class perfil : Form
    {
        public perfil()
        {
            InitializeComponent();
        }

        private void perfil_Load(object sender, EventArgs e)
        {
            textBox1.Text = Session.nombre;
            textBox2.Text = Session.apellido;
            textBox3.Text = Session.email;
            textBox4.Text = Session.usuario;
        }
    }
}
