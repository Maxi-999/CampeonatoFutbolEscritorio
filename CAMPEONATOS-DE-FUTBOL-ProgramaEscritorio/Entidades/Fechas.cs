using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Fechas
    {
        #region Atributos
        private int id_fecha;
        private string nro_fecha;
        private DateTime dia_fecha;
        #endregion

        #region Constructores
        public Fechas()
        {

        }

        public Fechas(int id, string num, DateTime dia)
        {
            pID_fecha = id;
            pNum_fecha = num;
            pDia_fecha = dia;
        }

        #endregion

        #region Encapsulamiento
        public int pID_fecha { get => id_fecha; set => id_fecha = value; }
        public string pNum_fecha { get => nro_fecha; set => nro_fecha= value; }
        public DateTime pDia_fecha { get => dia_fecha; set => dia_fecha = value; }

        #endregion
    }
}
