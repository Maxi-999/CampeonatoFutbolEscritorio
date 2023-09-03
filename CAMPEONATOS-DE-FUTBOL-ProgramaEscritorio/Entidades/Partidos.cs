using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Partidos
    {
        #region Atributos
        private int id_partido;
        private int id_fecha;
        private int id_equipo1;
        private int id_equipo2;
        private int nro_cancha;
        private int id_estado;
        private int goles_equipo1;
        private int goles_equipo2;
      
        #endregion

        #region Constructores
        public Partidos()
        {

        }

        public Partidos(int id, int fecha, int equipo1, int equipo2, int cancha, int estado, int goles1, int goles2)
        {
            pID_partido = id;
            pID_fecha = fecha;
            pEquipo1 = equipo1;
            pEquipo2 = equipo2;
            pCancha = cancha;
            pEstado = estado;
            pGoles1 = goles1;
            pGoles2 = goles2;

        }

        #endregion

        #region Encapsulamiento
        public int pID_partido { get => id_partido; set => id_partido = value; }
        public int pID_fecha { get => id_fecha; set => id_fecha = value; }
        public int pEquipo1 { get => id_equipo1; set => id_equipo1 = value; }
        public int pEquipo2 { get => id_equipo2; set => id_equipo2 = value; }
        public int pCancha { get => nro_cancha; set => nro_cancha = value; }
        public int pEstado { get => id_estado; set => id_estado = value; }
        public int pGoles1 { get => goles_equipo1; set => goles_equipo1 = value; }
        public int pGoles2 { get => goles_equipo2; set => goles_equipo2 = value; }
        #endregion
    }
}

