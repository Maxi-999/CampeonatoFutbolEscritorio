using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Login
    {
        public Login(int id_usuario, string usuario, string password)
        {
            this.id_usuario = id_usuario;
            this.usuario = usuario;
            this.password = password;
        }

        public int id_usuario { get; set; }
        public string usuario { get; set; }
        public string password { get; set; }
    }
}

