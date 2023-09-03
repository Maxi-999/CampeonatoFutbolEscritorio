using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CrearUsuario
    {
        #region Atributos
        private int id_Usuario;
        private string Usuario;
        private string nombre;
        private string apellido;
        private int dni;
        private string clave;
        private string Confirmacion_Clave;
       
        private int telefono;
        private string tipo_Usuario;
        private int cadena;

        public CrearUsuario()
        {
        }

        public CrearUsuario(int cadena)
        {
            this.cadena = cadena;
        }


        #endregion

        #region Constructores




        public CrearUsuario(int id_Usuario, string usuario, int telefono, string tipo_Usuario, string nombre, 
            string apellido, int dni, string clave, string confirmacion_Clave, 
            string email, string password)
        {
            this.Id_Usuario = id_Usuario;
            Usuario1 = usuario;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
            this.Clave = clave;
            Confirmacion_Clave1 = confirmacion_Clave;
           
            this.Tipo_Usuario = tipo_Usuario;
            this.Telefono = telefono;
        }

        #endregion


        #region encapsulamiento
        public int Id_Usuario { get => id_Usuario; set => id_Usuario = value; }
        public string Usuario1 { get => Usuario; set => Usuario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Dni { get => dni; set => dni = value; }
        public string Clave { get => clave; set => clave = value; }
        public string Confirmacion_Clave1 { get => Confirmacion_Clave; set => Confirmacion_Clave = value; }
       
        public string Tipo_Usuario { get => tipo_Usuario; set => tipo_Usuario = value; }
        public int Telefono { get => telefono; set => telefono = value; }

        #endregion

    }
}
