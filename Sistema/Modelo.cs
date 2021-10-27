using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema
{
    class Modelo
    {
       


        public bool existeUsuario(string usuario)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "SELECT codUser FROM account WHERE username LIKE @username";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@username", usuario);

            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public Usuarios porUsuario(string usuario)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "SELECT codUser,firstname,lastname,email,username,password FROM account WHERE username LIKE @username";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@username", usuario);

            reader = comando.ExecuteReader();

            Usuarios usr = null;

            while (reader.Read())
            {
                usr = new Usuarios();
                usr._codUser = int.Parse(reader["codUser"].ToString());
                usr._firstname = reader["firstname"].ToString();
                usr._lastname = reader["lastname"].ToString();
                usr._email = reader["email"].ToString();
                usr._username = reader["username"].ToString();
                usr._password = reader["password"].ToString();

            }
            return usr;
        }
    }
}
