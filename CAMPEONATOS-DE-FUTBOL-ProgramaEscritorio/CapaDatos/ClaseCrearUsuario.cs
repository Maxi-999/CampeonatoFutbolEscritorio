using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;


using MySql.Data.MySqlClient;
using System.IO;
using System.Security.Cryptography;

namespace CapaDatos
{
    public class ClaseCrearUsuario:ClaseConexion
    {
        public string abmCrearUsuario(string accion, CrearUsuario objCrearUsuario)
        {
            string resultados = "";
            string orden = string.Empty;

            if (accion == "Agregar")
            {
                orden = "INSERT INTO crear_usuario(nombre, apellido, Usuario, dni, clave, confirmacion_clave) VALUES (@nombre, @apellido, @Usuario, @dni, @clave, @confirmacion_clave)";

                MySqlConnection conexion = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=1982;database=campeonato2v2");
                MySqlCommand cmd = new MySqlCommand(orden, conexion);
                cmd.Parameters.AddWithValue("@nombre", objCrearUsuario.Nombre.ToUpper());
                cmd.Parameters.AddWithValue("@apellido", objCrearUsuario.Apellido.ToUpper());
                cmd.Parameters.AddWithValue("@Usuario", objCrearUsuario.Usuario1);
                cmd.Parameters.AddWithValue("@dni", objCrearUsuario.Dni);

                // Encrypt the password using AES
                string encryptedPassword = EncryptPassword(objCrearUsuario.Clave);
                cmd.Parameters.AddWithValue("@clave", encryptedPassword);

                cmd.Parameters.AddWithValue("@confirmacion_clave", objCrearUsuario.Confirmacion_Clave1);

                try
                {
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                    resultados = "Usuario agregado correctamente";
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al tratar de guardar, borrar o modificar la base de datos", ex);
                }
                finally
                {
                    conexion.Close();
                    cmd.Dispose();
                }
            }

            return resultados;
        }

        private string EncryptPassword(string password)
        {
            string encryptionKey = "mi_clave"; // Reemplaza con tu clave de cifrado real

            using (AesCryptoServiceProvider aes = new AesCryptoServiceProvider())
            {
                aes.Key = Encoding.UTF8.GetBytes(encryptionKey);
                aes.Mode = CipherMode.ECB;
                aes.Padding = PaddingMode.PKCS7;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                byte[] encryptedBytes = null;

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                        cryptoStream.Write(passwordBytes, 0, passwordBytes.Length);
                        cryptoStream.FlushFinalBlock();
                        encryptedBytes = memoryStream.ToArray();
                    }
                }

                return Convert.ToBase64String(encryptedBytes);
            }
        }




    }
}
