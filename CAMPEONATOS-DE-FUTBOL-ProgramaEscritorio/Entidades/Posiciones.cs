using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Posiciones
    {
        #region Atributos
        private int id_posicion;
        private int id_equipo;
        private int pj;
        private int pg;
        private int pe;
        private int pp;
        private int gf;
        private int gc;
        private int dg;
        private int puntaje;
        #endregion

        #region Constructores
        public Posiciones()
        {

        }

        public Posiciones(int idP, int idE, int pJ, int pG, int pE, int pP, int gF, int gC, int dG, int punt)
        {
            pID_Pos = idP;
            pID_Equi = idE;
            pPJ = pJ;
            pPG = pG;
            pPE = pE;
            pPP = pP;
            pGF = gF;
            pGC = gc;
            pDG = dG;
            pPuntaje = punt;
        }

        #endregion

        #region Encapsulamiento
        public int pID_Pos { get => id_posicion; set => id_posicion = value; }
        public int pID_Equi { get => id_equipo; set => id_equipo = value; }
        public int pPJ { get => pj; set => pj = value; }
        public int pPG { get => pg; set => pg = value; }
        public int pPE { get => pe; set => pe = value; }
        public int pPP { get => pp; set => pp = value; }
        public int pGF { get => gf; set => gf = value; }
        public int pGC { get => gc; set => gc = value; }
        public int pDG { get => dg; set => dg = value; }
        public int pPuntaje { get => puntaje; set => puntaje = value; }


        #endregion
    }
}
