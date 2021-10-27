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
    public partial class frmPrincipal : Form
    {


        public frmPrincipal()
        {
            InitializeComponent();

            label1.Text = "BIENVENIDO " + Session.usuario;



            if (Session.usuario == "admin")
            {
                this.subMenuRegistrarUsuario.Visible = true;
            }
            else
            {
                this.subMenuRegistrarUsuario.Visible = false;

                this.subMenuConsultarUsuarios.Visible = false;
                this.logToolStripMenuItem.Visible = false;
            }
        }

        private void subMenuRegistrarUsuario_Click(object sender, EventArgs e)
        {
            frmRegistro frmRegistro = new frmRegistro();
            frmRegistro.Visible = true;
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }

        private void menuCerrarSession_Click(object sender, EventArgs e)
        {
            
            
            this.Close();
           

            frmLogin frm = new frmLogin();
            frm.Visible = true;

            Session ss = new Session();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void menuUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void subMenuConsultarUsuarios_Click(object sender, EventArgs e)
        {
            MostrarUsuarios musua = new MostrarUsuarios();
            musua.Show();
        }

        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logs logs = new logs();

            logs.Show();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            perfil perfil = new perfil();
            perfil.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}