using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema
{
    class Usuarios
    {
        DateTime registerDte;
        int codUser;
        string firstname, lastname, email, username, password;

        public int _codUser { get => codUser; set => codUser = value; }
        public string _firstname { get => firstname; set => firstname = value; }
        public string _lastname { get => lastname; set => lastname = value; }
        public string _email { get => email; set => email = value; }
        public DateTime _fecha { get => registerDte; set => registerDte = value; }
        public string _username { get => username; set => username = value; }
        public string _password { get => password; set => password = value; }
    }
}
