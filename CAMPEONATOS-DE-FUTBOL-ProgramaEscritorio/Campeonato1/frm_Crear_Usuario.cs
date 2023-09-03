using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using MySql.Data.MySqlClient;

namespace Campeonato1
{
    public partial class frm_Crear_Usuario : Form
    {
        public frm_Crear_Usuario()
        {
            InitializeComponent();
           
        }

        private void frm_Crear_Usuario_Load(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            ClaseConexion conexion = new ClaseConexion();
            MySqlConnection connection = new MySqlConnection(conexion.cadena);
            connection.Open();

            if (!ValidarTexto(txtNombre.Text))
            {
                MessageBox.Show("No se pueden ingresar números ni caracteres especiales en el campo de nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ValidarTexto(txtApelldio.Text))
            {
                MessageBox.Show("No se pueden ingresar números ni caracteres especiales en el campo de apellido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ValidarTexto(txtUsuario.Text))
            {
                MessageBox.Show("No se pueden ingresar números ni caracteres especiales en el campo de usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ValidarDNI(txtDNI.Text))
            {
                MessageBox.Show("Debe ingresar un número válido de DNI en el campo correspondiente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtClave.Text.Length > 12)
            {
                MessageBox.Show("La clave no puede tener más de 12 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtClave.Text != txtRepClave.Text)
            {
                MessageBox.Show("Las claves ingresadas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "INSERT INTO crear_usuario (Usuario, nombre, apellido, dni, clave, confirmacion_clave) VALUES (@usuario, @nombre, @apellido, @dni, @clave, @confirmacion_clave)";

            MySqlCommand command = new MySqlCommand(query, connection);

            command.Parameters.AddWithValue("@nombre", txtNombre.Text);
            command.Parameters.AddWithValue("@apellido", txtApelldio.Text);
            command.Parameters.AddWithValue("@usuario", txtUsuario.Text);
            command.Parameters.AddWithValue("@dni", int.Parse(txtDNI.Text));
            command.Parameters.AddWithValue("@clave", txtClave.Text);
            command.Parameters.AddWithValue("@confirmacion_clave", txtRepClave.Text);

            command.ExecuteNonQuery();

            connection.Close();

            MessageBox.Show("Los datos se han guardado correctamente en la base de datos.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FrmLogin loginForm = new FrmLogin();
            loginForm.Show();
            this.Hide();


        }

        private bool ValidarTexto(string texto)
        {
            return !texto.Any(char.IsDigit) && !texto.Any(char.IsPunctuation) && !texto.Any(char.IsSymbol);
        }

        private bool ValidarDNI(string dni)
        {
            return int.TryParse(dni, out int result) && dni.Length == 8;
        }
    }
}
