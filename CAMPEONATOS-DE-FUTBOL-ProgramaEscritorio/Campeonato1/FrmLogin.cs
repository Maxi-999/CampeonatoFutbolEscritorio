using CapaDatos;
using Entidades;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X500;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Campeonato1
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
           
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {



        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string password = txtPassword.Text;

            ClaseLogin login = new ClaseLogin();

           
            if (login.Login(usuario, password))
            {
                frm_Principal principal = new frm_Principal();
                principal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            frm_Crear_Usuario crearUsuario = new frm_Crear_Usuario();
            crearUsuario.Show();
            this.Hide();

        }

       

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "admin" && txtPassword.Text == "1234")
            {
                btnCrearUsuario.Enabled = true;
            }
            else
            {
                btnCrearUsuario.Enabled = false;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "admin" && txtPassword.Text == "1234")
            {
                btnCrearUsuario.Enabled = true;
            }
            else
            {
                btnCrearUsuario.Enabled = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
