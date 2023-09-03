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
    public class ClaseFecha : ClaseConexion
    {
        public int abmFechas(string accion, Fechas objFecha)
        {
            int resultados = -1;
            string orden = string.Empty;

            if (accion == "Agregar")
            {
                orden = "INSERT INTO fechas(nro_fecha, dia) VALUES (@fecha, @diafecha);";
            }
            if (accion == "Contar")
            {
                orden = "Select count (*) From equipos;";
            }
            MySqlCommand cmd = new MySqlCommand(orden, conexion);
            cmd.Parameters.AddWithValue("@fecha", objFecha.pNum_fecha.ToUpper());
            cmd.Parameters.AddWithValue("@diafecha", objFecha.pDia_fecha);


           //MySqlCommand cmd = new MySqlCommand(orden, conexion);
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
        public List<Fechas> listadoFechas()
        {
            string orden = string.Empty;
            orden = "SELECT id_fecha, nro_fecha, dia FROM fechas;";
            MySqlCommand cmd = new MySqlCommand(orden, conexion);
            List<Fechas> ds = new List<Fechas>();

            try
            {
                AbrirConexion();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Fechas pFechas = new Fechas();

                    pFechas.pID_fecha = dr.GetInt32(0);
                    pFechas.pNum_fecha = (dr.GetString(1)).ToUpper();
                    pFechas.pDia_fecha = dr.GetDateTime(2);
                   
                    ds.Add(pFechas);
                }
                ds = ds.OrderBy(x => x.pNum_fecha[0]).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar fechas", ex);
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
