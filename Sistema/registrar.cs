using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sistema
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }
   
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now;
           
          
            
            try
            {
                int codigo = int.Parse(txtid.Text);
                String nombre = txtnombre.Text;
                String apellido = txtapellido.Text;
                String email = txtemail.Text;
                String username = txtusuario.Text;
                String password = txtcontraseña.Text;
                

                if (codigo > 0 && nombre != "" && apellido != "" && email != "" && username != "" && password != "")
                {

                    string sql = "INSERT INTO account (codUser, firstname,lastname, email, registerDate,username,password) VALUES ('" + codigo + "', '" + nombre + "','" + apellido + "','" + email + "','" + fecha.ToString("yyyy-MM-dd")+ "','" + username + "','" + password + "')";

                    ;
                    MySqlConnection conexion = Conexion.getConexion();
                    conexion.Open();


                    try
                    {
                        MySqlCommand comando = new MySqlCommand(sql, conexion);
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Registro guardado");

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error al guardar: " + ex.Message);
                    }
                    finally
                    {
                        conexion.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Debe completar todos los campos");
                }
            }
            catch (FormatException fex)
            {
                MessageBox.Show("Datos incorrectos: " + fex.Message);
            }


        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtid.Text);
            String nombre = txtnombre.Text;
            String apellido = txtapellido.Text;
            String email = txtemail.Text;
            String username = txtusuario.Text;
            String password = txtcontraseña.Text;

            string sql = "UPDATE account SET codUser='" + codigo + "', firstname='" + nombre + "', lastname='" + apellido + "', email='" + email + "',username ='" + username + "',password= '" + password + "' WHERE coduser='" + codigo + "'";

            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro modificado");

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void btnactualiar_Click(object sender, EventArgs e)
        {
            String id = txtid.Text;

            string sql = "DELETE FROM account WHERE coduser='" + id + "'";

            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro eliminado");
                limpiar();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
            private void limpiar()
            {

                txtid.Text = "";
                txtnombre.Text = "";
                txtapellido.Text = "";
                txtemail.Text = "";
                txtusuario.Text = "";
                txtcontraseña.Text = "";

            }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
    }

