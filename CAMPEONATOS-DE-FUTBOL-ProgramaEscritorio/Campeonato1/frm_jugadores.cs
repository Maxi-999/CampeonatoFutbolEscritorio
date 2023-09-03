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
    public partial class frm_jugadores : Form
    {
        public string dato = "";
        public ClaseEquipos objEquipos = new ClaseEquipos();
        public Equipos objEquipoConsulta = new Equipos(); 
        public DateTime Actual = DateTime.Now.ToLocalTime();
        public frm_jugadores()
        {
            InitializeComponent();
            var ta = new ToolTip();
            var tr = new ToolTip();
            var ts = new ToolTip();
            var tq = new ToolTip();
            ta.SetToolTip(btn_agregar, "Agregar jugador");
            tr.SetToolTip(btn_reemplazar, "Modificar jugador");
            ts.SetToolTip(btn_sancionar, "Sancionar jugador");
            tq.SetToolTip(btn_quitar, "Quitar jugador");
            CargarCmbE();
            lbl_jug_anota.Text = dgv_equipo.RowCount.ToString();
        }
        private void CargarCmbE()
        {
            //se llena el comboBox con los equipos de la base de datos
            cmb_equipos.DataSource = objEquipos.listadoEquipos();
            cmb_equipos.DisplayMember = "pNombre";
            cmb_equipos.ValueMember = "pID";
            cmb_equipos.SelectedIndex = -1;
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (cmb_equipos.SelectedIndex == -1)
            {
                MessageBox.Show("Primero debe elegir un equipo");
            }
            else
            {
                int id_equipo_sel = int.Parse(cmb_equipos.SelectedValue.ToString());
                string nombre_sel = cmb_equipos.GetItemText(cmb_equipos.SelectedItem);
                frm_carga_jugadores form_carga = new frm_carga_jugadores(id_equipo_sel, nombre_sel);
                form_carga.ShowDialog();
            }
            
        }

        private void btn_equipo_Click(object sender, EventArgs e)
        {
            if (cmb_equipos.SelectedIndex == -1)
            {
                MessageBox.Show("Primero debe elegir un equipo");
            }
            else
            {
                int busqueda = 3;
                dato = cmb_equipos.SelectedValue.ToString();
                dgv_equipo.Columns.Clear();
                dgv_equipo.DataSource = null;
                DataTable dt = new DataTable();
                objEquipoConsulta = objEquipos.BsquedaEquipo(dato);
                dt = objEquipos.listadoEquipos(dato, busqueda);
                dgv_equipo.DataSource = dt;
                dgv_equipo.Columns[0].Width = 125;
                dgv_equipo.Columns[1].Width = 125;
                dgv_equipo.Columns[2].Width = 80;
                dgv_equipo.Columns[3].Width = 60;
                lbl_equipo.Text = objEquipoConsulta.pNombre;
                lbl_jug_anota.Text = dgv_equipo.RowCount.ToString();
                if ((objEquipoConsulta.pRuta == "p"))
                {
                    pic_escudo2.Image = pic_escudo2.InitialImage;
                }
                else
                {
                    pic_escudo2.Image = Image.FromFile(objEquipoConsulta.pRuta);
                }
            }
            
            
        }

        private void frm_jugadores_Activated(object sender, EventArgs e)
        {
            if(cmb_equipos.SelectedIndex != -1)
            {
                int busqueda = 3;
                dato = cmb_equipos.SelectedValue.ToString();
                dgv_equipo.Columns.Clear();
                dgv_equipo.DataSource = null;
                DataTable dt = new DataTable();
                objEquipoConsulta = objEquipos.BsquedaEquipo(dato);
                dt = objEquipos.listadoEquipos(dato, busqueda);
                dgv_equipo.DataSource = dt;
                dgv_equipo.Columns[0].Width = 125;
                dgv_equipo.Columns[1].Width = 125;
                dgv_equipo.Columns[2].Width = 80;
                dgv_equipo.Columns[3].Width = 60;
                lbl_jug_anota.Text = dgv_equipo.RowCount.ToString();
            }
            
        }
    }   
}
