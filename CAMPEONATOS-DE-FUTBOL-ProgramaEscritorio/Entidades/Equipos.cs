using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipos
    {
        #region Atributos
        private int id_equipo;
        private string nombre;
        private string ruta_escudo;
        #endregion

        #region Constructores
        public Equipos()
        {

        }

        public Equipos(int id, string nom, string ruta)
        {
            pID = id;
            pNombre = nom;
            pRuta = ruta;
        }

        #endregion

        #region Encapsulamiento
        public int pID { get => id_equipo; set => id_equipo = value; }
        public string pNombre { get => nombre; set => nombre = value; }
        public string pRuta { get => ruta_escudo; set => ruta_escudo = value; }

        #endregion
    }
}
