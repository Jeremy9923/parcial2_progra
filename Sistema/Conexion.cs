using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Sistema
{
    class Conexion
    {
        public static MySqlConnection getConexion()
        {
            string servidor = "localhost";
            string puerto = "3307";
            string usuario = "root";
            string password = "usbw";
            string bd = "administración de usuarios";
            

            string cadenaConexion = "server=" + servidor + "; port=" + puerto + "; user id=" + usuario + "; password="+password + "; database="+bd;

            MySqlConnection conexion = new MySqlConnection(cadenaConexion);

            return conexion;

        }
    }
}
