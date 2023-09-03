using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugadores
    {
        #region Atributos
        private int id_jugador;
        private string nombre;
        private string apellido;
        private int dni;
        private int edad;
        private DateTime fecha_nac;
        private int id_equipo;
        #endregion

        #region Constructores
        public Jugadores()
        {

        }

        public Jugadores(int id_jug, string nom, string ape, int dni, int anios, DateTime nac, int equi)
        {
            pIdJugador = id_jug;
            pNombre = nom;
            pApellido = ape;
            pDni = dni;
            pEdad = anios;
            pFechaNac = nac;
            pEquipo = equi;
        }

        #endregion

        #region Encapsulamiento
        public int pIdJugador { get => id_jugador; set => id_jugador = value; }
        public string pNombre { get => nombre; set => nombre = value; }
        public string pApellido { get => apellido; set => apellido = value; }
        public int pDni { get => dni; set => dni = value; }
        public int pEdad { get => edad; set => edad = value; }
        public DateTime pFechaNac { get => fecha_nac; set => fecha_nac = value; }
        public int pEquipo { get => id_equipo; set => id_equipo = value; }

        #endregion
    }
}
