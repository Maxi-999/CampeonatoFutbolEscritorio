using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using Entidades;

namespace CapaDatos
{
    public class ClasePartidos : ClaseConexion
    {
        public int abmPartidos(string accion, Partidos objpartido)
        {
            int resultados = -1;
            string orden = string.Empty;

            if (accion == "Agregar")
            {
                orden = "INSERT INTO partidos(id_fecha, id_equipo1, id_equipo2, nro_cancha, goles_equipo1, goles_equipo2) VALUES ('" + objpartido.pID_fecha + "', '" + objpartido.pEquipo1 + "', '" + objpartido.pEquipo2 + "', '" + objpartido.pCancha + "', '" + objpartido.pGoles1 + "', '" + objpartido.pGoles2 + "');";
            }
            MySqlCommand cmd = new MySqlCommand(orden, conexion);
            try
            {
                if (accion != "Contar")
                {
                    AbrirConexion();
                    resultados = cmd.ExecuteNonQuery();
                }
                else
                {
                    AbrirConexion();
                    resultados = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al tratar de guardar, borrar o modificar la base de datos", ex);
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }
            return resultados;
        }
        

        public DataTable listadoPartidos(string cual, int busqueda)
        {

            string orden = string.Empty;
            if (busqueda == 1)
            {
                orden = "SELECT P.nro_cancha AS CANCHA, E.nombre AS LOCALL, P.goles_equipo1 AS GOL_L, R.nombre AS VISITA, P.goles_equipo2 AS GOL_V FROM partidos P, fechas F, equipos E, equipos R WHERE P.id_fecha =" + int.Parse(cual) + " AND P.id_fecha = F.id_fecha AND P.id_equipo1 = E.id_equipo AND P.id_equipo2=R.id_equipo;";
            }
            else if (busqueda == 2)
            {
                //orden = "SELECT P.nro_cancha AS CANCHA, E.nombre AS LOC, P.goles_equipo1 AS GOL_L, R.nombre AS VIS, P.goles_equipo2 AS GOL_V FROM partidos P, fechas F, equipos E, equipos R WHERE P.id_fecha =" + int.Parse(cual) +" AND P.id_fecha = F.id_fecha AND P.id_equipo1 = E.id_equipo AND P.id_equipo2=R.id_equipo";
            }
            MySqlCommand cmd = new MySqlCommand(orden, conexion);
            DataTable ds = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter();
            try
            {
                AbrirConexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar partidos", ex);
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }
            return ds;

        }
    }
}
