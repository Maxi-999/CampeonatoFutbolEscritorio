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
    public class ClaseJugadores : ClaseConexion
    {
        public int abmJugadores(string accion, Jugadores objJugador)
        {
        
            int resultados = -1;
            string orden = string.Empty;

            if (accion == "Agregar")
            {
                orden = "INSERT INTO jugadores(nombre, apellido, fecha_nac, dni, edad, id_equipo) VALUES (@nombre, @apellido, @fechaNac, @dni, @edad, @equipos);";

                MySqlCommand cmd = new MySqlCommand(orden, conexion);
                cmd.Parameters.AddWithValue("@nombre", objJugador.pNombre.ToUpper());
                cmd.Parameters.AddWithValue("@apellido", objJugador.pApellido.ToUpper());
                cmd.Parameters.AddWithValue("@fechaNac", objJugador.pFechaNac);
                cmd.Parameters.AddWithValue("@dni", objJugador.pDni);
                cmd.Parameters.AddWithValue("@edad", objJugador.pEdad);
                cmd.Parameters.AddWithValue("@equipos", objJugador.pEquipo);

                try
                {
                    AbrirConexion();
                    resultados = cmd.ExecuteNonQuery();
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
            }

            return resultados;
        }
    }
}
