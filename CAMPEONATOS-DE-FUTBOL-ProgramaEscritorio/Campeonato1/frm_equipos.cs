using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using CapaDatos;


namespace Campeonato1
{
    public partial class frm_equipos : Form
    {
        public Equipos objEquipoNew = new Equipos();
        public ClaseEquipos objCargaEquipo = new ClaseEquipos();
        public string ruta_pic = "p";
        public int total = 0;
        public frm_equipos()
        {
            InitializeComponent();
            Contar();
            
        }
        private void Contar()
        {
            int busqueda = -1;
            busqueda = objCargaEquipo.abmEquipos("Contar", objEquipoNew);
            if (busqueda == 0)
            {
                lbl_anotados.Text = "Ninguno";
            }
            else
            {
                lbl_anotados.Text = busqueda.ToString() + "/8";
                total = busqueda;
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chk_escudo_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_escudo.Checked == true)
            {
                openFileDialog1.InitialDirectory = @"C:\camp2.2";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {                    
                    pic_escudo.Image = Image.FromFile(openFileDialog1.FileName);
                    ruta_pic = openFileDialog1.FileName;

                }
                else
                {
                    chk_escudo.Checked = false;
                }
            }
            else
            {
                pic_escudo.Image = pic_escudo.InitialImage;
            }
            
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (total < 8 && txt_equipo.Text.Length!=0)
            {
                int ngrabados = -1;
                objEquipoNew.pNombre = txt_equipo.Text;
                objEquipoNew.pRuta = ruta_pic;
                ngrabados = objCargaEquipo.abmEquipos("Agregar", objEquipoNew);
                if (ngrabados != -1)
                {
                    txt_equipo.Text = "";
                    pic_escudo.Image = pic_escudo.InitialImage;
                    chk_escudo.Checked = false;
                    ruta_pic = "p";
                    Contar();
                }
            }
            else
            {
                if (total == 8)
                {
                    MessageBox.Show("No puede haber mas de 8 equipos anotados");
                    txt_equipo.Text = "";
                    chk_escudo.Checked = false;
                    pic_escudo.Image = pic_escudo.InitialImage;
                    txt_equipo.Focus();
                }
                
                else
                {
                    if (txt_equipo.Text.Length == 0)
                    {
                        MessageBox.Show("Debe ingresar un nombre de equipo correcto");
                        chk_escudo.Checked = false;
                        pic_escudo.Image = pic_escudo.InitialImage;
                        txt_equipo.Focus();

                    }
                }
            }

        }
    }
}
