using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Sistema
{
    class Control
    {
        string instrucion;
        public string ctrlRegistro(Usuarios usuario)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";

            if(string.IsNullOrEmpty(usuario._firstname) || string.IsNullOrEmpty(usuario._lastname) || string.IsNullOrEmpty(usuario._email) || string.IsNullOrEmpty(usuario._username)|| string.IsNullOrEmpty(usuario._password))
            {
                respuesta = "Debe llenar todos los campos";
            } else
            {
                
                    if (modelo.existeUsuario(usuario._username))
                    {
                        respuesta = "El usuario ya existe";
                    }
            }
            return respuesta;

        }
        public DataTable mostrar_usuario()
        {
            
            instrucion = "select codUser,firstname,lastname,email,registerDate,username,password from account";
            MySqlDataAdapter adp = new MySqlDataAdapter(instrucion,Conexion.getConexion());
            DataTable consulta = new DataTable();
            adp.Fill(consulta).ToString();
            return consulta;

        }
        public DataTable mostrar_log()
        {

            instrucion = "select codUser,username,timeLoggedIn from userlog";
            MySqlDataAdapter adp = new MySqlDataAdapter(instrucion, Conexion.getConexion());
            DataTable consulta = new DataTable();
            adp.Fill(consulta).ToString();
            return consulta;

        }

        public string ctrlLogin(string usuario, string password)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";
            Usuarios datosUsuario = null;

            if(string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(password))
            {
                respuesta = "Debe llenar todos los campos";
            } else
            {
                datosUsuario = modelo.porUsuario(usuario);

                if(datosUsuario == null)
                {
                    respuesta = "El usuario no existe";
                } else
                {
                    if(datosUsuario._password != password)
                    {
                        respuesta = "El usuario y/o contraseña no coinciden";
                    } else
                    {
                        Session.id = datosUsuario._codUser;
                        Session.usuario = usuario;
                        Session.nombre = datosUsuario._firstname;
                        Session.apellido = datosUsuario._lastname;
                        Session.email=datosUsuario._email;
                        
                    }
                }
            }
            return respuesta;
        }

        

    }
}
