using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using Entidades;

using MySql.Data.MySqlClient;

namespace Campeonato1
{
    public partial class frm_carga_jugadores : Form
    {
        public Jugadores objJugador = new Jugadores();
        public ClaseJugadores objCargaJugador = new ClaseJugadores();
        private int nro_equipo = -1;
        private string nom_equipo = "";

        public frm_carga_jugadores(int id_equipo_p, string nombre_p)
        {
            InitializeComponent();
            nro_equipo = id_equipo_p;
            nom_equipo = nombre_p;
            lbl_equipo.Text = nom_equipo;
        }

        private void Limpiar()
        {
            txt_apellido.Clear();
            txt_nombres.Clear();
            txt_dni.Clear();
            mtb_nac.Clear();
            lbl_edad.Text = "..";
        }


        private void btn_agregar_Click(object sender, EventArgs e)
        {
            string nombre = txt_nombres.Text;
            if (!Regex.IsMatch(nombre, @"^[a-zA-Z]+$"))
            {
                //MessageBox.Show("El campo Nombre solo debe contener letras");
                //return;
            }
            string apellido = txt_apellido.Text;
            if (!Regex.IsMatch(apellido, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("El campo Apellido solo debe contener letras");
                return;
            }
            string dni = txt_dni.Text;
            if (!Regex.IsMatch(dni, @"^\d{8}$"))
            {
                MessageBox.Show("El campo DNI debe tener un máximo de 8 dígitos");
                return;
            }

            DateTime minDate = new DateTime(1973, 1, 1);
            DateTime maxDate = new DateTime(2007, 9, 30);
            DateTime dateOfBirth;

            if (!DateTime.TryParse(mtb_nac.Text, out dateOfBirth))
            {
                MessageBox.Show("Fecha de nacimiento inválida");
                return;
            }

            if (dateOfBirth < minDate || dateOfBirth > maxDate)
            {
                MessageBox.Show("La fecha de nacimiento no está en el rango aceptado");
                return;
            }

            // Establish a connection to the Access database
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=1982;database=campeonato2v2";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Create a query to check if the new player already exists in the database
                string query = "SELECT COUNT(*) FROM jugadores WHERE nombre = @nombre AND apellido = @apellido AND dni = @dni";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@apellido", apellido);
                    command.Parameters.AddWithValue("@dni", dni);

                    // Execute the query and retrieve the count of players with the same name, last name, and DNI
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    // If the count is greater than 0, display an error message and return from the method
                    if (count > 0)
                    {
                        MessageBox.Show("El jugador ya existe en la base de datos");
                        return;
                    }
                }
            }

            
        }



       

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void txt_apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ingresa solo letras
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_nombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ingresa solo letras
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo puede ingresar numeros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void mtb_nac_Leave(object sender, EventArgs e)
        {
            DateTime ahora = DateTime.Now;
            DateTime cumple = Convert.ToDateTime(this.mtb_nac.Text);
            TimeSpan edad = ahora.Subtract(cumple);
            lbl_edad.Text = ((int)((edad.TotalDays)/365.25)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
