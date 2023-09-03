using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Entidades;
using CapaDatos;
using System.Text.RegularExpressions;
using System.CodeDom.Compiler;

namespace Campeonato1
{
    public partial class frm_sorteo : Form
    {
        public Partidos objpartido = new Partidos();
        public ClasePartidos objCargapartido = new ClasePartidos();
        public Equipos objEquipoNew = new Equipos();
        public List<Equipos> objCargaE = new List<Equipos>();
        public ClaseEquipos objCargaEquipo = new ClaseEquipos();
        public Fechas objFechas = new Fechas();
        public ClaseFecha objClaseFecha = new ClaseFecha();
        public ClasePosiciones objEquipoPos = new ClasePosiciones();


        public frm_sorteo()
        {
            InitializeComponent();
            Contar();
            CargarCmbE();
            CargarEquipos();
        }

        private void CargarCmbE()
        {
            cmb_fechas.DataSource = objClaseFecha.listadoFechas();
            cmb_fechas.DisplayMember = "pNum_fecha";
            cmb_fechas.ValueMember = "pID_fecha";

            cmb_fechas.SelectedIndex = -1;

        }

        private void CargarEquipos()
        {
            int busqueda = -1;
            objCargaE = objCargaEquipo.listadoEquipos();
            busqueda = objCargaEquipo.abmEquipos("Contar", objEquipoNew);
            switch (busqueda)
            {
                case 1:
                    txt_equipo1.Text = ((List<Equipos>)objCargaE)[0].pNombre;
                    break;
                case 2:
                    txt_equipo1.Text = ((List<Equipos>)objCargaE)[0].pNombre;
                    txt_equipo2.Text = ((List<Equipos>)objCargaE)[1].pNombre;
                    break;
                case 3:
                    txt_equipo1.Text = ((List<Equipos>)objCargaE)[0].pNombre;
                    txt_equipo2.Text = ((List<Equipos>)objCargaE)[1].pNombre;
                    txt_equipo3.Text = ((List<Equipos>)objCargaE)[2].pNombre;
                    break;
                case 4:
                    txt_equipo1.Text = ((List<Equipos>)objCargaE)[0].pNombre;
                    txt_equipo2.Text = ((List<Equipos>)objCargaE)[1].pNombre;
                    txt_equipo3.Text = ((List<Equipos>)objCargaE)[2].pNombre;
                    txt_equipo4.Text = ((List<Equipos>)objCargaE)[3].pNombre;
                    break;
                case 5:
                    txt_equipo1.Text = ((List<Equipos>)objCargaE)[0].pNombre;
                    txt_equipo2.Text = ((List<Equipos>)objCargaE)[1].pNombre;
                    txt_equipo3.Text = ((List<Equipos>)objCargaE)[2].pNombre;
                    txt_equipo4.Text = ((List<Equipos>)objCargaE)[3].pNombre;
                    txt_equipo5.Text = ((List<Equipos>)objCargaE)[4].pNombre;
                    break;
                case 6:
                    txt_equipo1.Text = ((List<Equipos>)objCargaE)[0].pNombre;
                    txt_equipo2.Text = ((List<Equipos>)objCargaE)[1].pNombre;
                    txt_equipo3.Text = ((List<Equipos>)objCargaE)[2].pNombre;
                    txt_equipo4.Text = ((List<Equipos>)objCargaE)[3].pNombre;
                    txt_equipo5.Text = ((List<Equipos>)objCargaE)[4].pNombre;
                    txt_equipo6.Text = ((List<Equipos>)objCargaE)[5].pNombre;
                    break;
                case 7:
                    txt_equipo1.Text = ((List<Equipos>)objCargaE)[0].pNombre;
                    txt_equipo2.Text = ((List<Equipos>)objCargaE)[1].pNombre;
                    txt_equipo3.Text = ((List<Equipos>)objCargaE)[2].pNombre;
                    txt_equipo4.Text = ((List<Equipos>)objCargaE)[3].pNombre;
                    txt_equipo5.Text = ((List<Equipos>)objCargaE)[4].pNombre;
                    txt_equipo6.Text = ((List<Equipos>)objCargaE)[5].pNombre;
                    txt_equipo7.Text = ((List<Equipos>)objCargaE)[6].pNombre;
                    break;
                case 8:
                    txt_equipo1.Text = ((List<Equipos>)objCargaE)[0].pNombre;
                    txt_equipo2.Text = ((List<Equipos>)objCargaE)[1].pNombre;
                    txt_equipo3.Text = ((List<Equipos>)objCargaE)[2].pNombre;
                    txt_equipo4.Text = ((List<Equipos>)objCargaE)[3].pNombre;
                    txt_equipo5.Text = ((List<Equipos>)objCargaE)[4].pNombre;
                    txt_equipo6.Text = ((List<Equipos>)objCargaE)[5].pNombre;
                    txt_equipo7.Text = ((List<Equipos>)objCargaE)[6].pNombre;
                    txt_equipo8.Text = ((List<Equipos>)objCargaE)[7].pNombre;
                    break;
                default:
                    MessageBox.Show("NO hay equpos para mostrar");
                    break;

            }


        }

        private void Contar()
        {
            int busqueda = -1;
            busqueda = objCargaEquipo.abmEquipos("Contar", objEquipoNew);
            if (busqueda != 8)
            {
                MessageBox.Show("Debe haber 8 equipos anotados para poder realizar el sorteo");
                btn_sortear.Enabled = false;
                //cmb_fechas.Enabled = false;
                btn_sortear.Visible = false;
                btn_ver_fecha.Enabled = false;
                dtp_comienzo.Visible = false;
                dtp_comienzo.Enabled = false;
                btn_salir.Focus();
            }
            else
            {
                btn_sortear.Enabled = true;
                //cmb_fechas.Enabled = false;
                btn_sortear.Visible = true;
                //btn_ver_fecha.Enabled = false;
                dtp_comienzo.Visible = true;
                dtp_comienzo.Enabled = true;
            }


        }


       
        private void btn_sortear_Click(object sender, EventArgs e)
        {
            int rondas = 0;
            ClaseFecha objCargaFecha = new ClaseFecha();
            DateTime comienzo = new DateTime();
            comienzo = dtp_comienzo.Value.Date;

            if (MessageBox.Show("Esta seguro de comenzar el campeonato el día " + comienzo.ToShortDateString(), "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                for (int x = 1; x < 8; x++)
                {
                    int nGrabados = -1;
                    Fechas objFechas1 = new Fechas();
                    objFechas1.pNum_fecha = "Fecha N° " + Convert.ToString(x);
                    objFechas1.pDia_fecha = comienzo;
                    nGrabados = objCargaFecha.abmFechas("Agregar", objFechas1);
                    comienzo = comienzo.AddDays(7);
                }
                CargarCmbE();
                cmb_fechas.SelectedIndex = 0;
                rondas = Convert.ToInt32(cmb_fechas.SelectedValue);
                for (int x = 1; x < 8; x++)
                {
                    switch (x)
                    {
                        case 1:
                            //inserta 4 partidos
                            int ngrabados = -1;
                            objpartido.pID_fecha = rondas;
                            objpartido.pEquipo1 = ((List<Equipos>)objCargaE)[0].pID;
                            objpartido.pEquipo2 = ((List<Equipos>)objCargaE)[1].pID;
                            objpartido.pCancha = 1;
                            objpartido.pGoles1 = 0;
                            objpartido.pGoles1 = 0;
                            ngrabados = objCargapartido.abmPartidos("Agregar", objpartido);

                            ngrabados = -1;
                            objpartido.pID_fecha = rondas;
                            objpartido.pEquipo1 = ((List<Equipos>)objCargaE)[2].pID;
                            objpartido.pEquipo2 = ((List<Equipos>)objCargaE)[3].pID;
                            objpartido.pCancha = 2;
                            objpartido.pGoles1 = 0;
                            objpartido.pGoles1 = 0;
                            ngrabados = objCargapartido.abmPartidos("Agregar", objpartido);

                            ngrabados = -1;
                            objpartido.pID_fecha = rondas;
                            objpartido.pEquipo1 = ((List<Equipos>)objCargaE)[4].pID;
                            objpartido.pEquipo2 = ((List<Equipos>)objCargaE)[5].pID;
                            objpartido.pCancha = 3;
                            objpartido.pGoles1 = 0;
                            objpartido.pGoles1 = 0;
                            ngrabados = objCargapartido.abmPartidos("Agregar", objpartido);

                            ngrabados = -1;
                            objpartido.pID_fecha = rondas;
                            objpartido.pEquipo1 = ((List<Equipos>)objCargaE)[6].pID;
                            objpartido.pEquipo2 = ((List<Equipos>)objCargaE)[7].pID;
                            objpartido.pCancha = 4;
                            objpartido.pGoles1 = 0;
                            objpartido.pGoles1 = 0;
                            ngrabados = objCargapartido.abmPartidos("Agregar", objpartido);
                            break;

                        case 2:
                            //inserta 4 partidos
                            ngrabados = -1;
                            objpartido.pID_fecha = rondas + 1;
                            objpartido.pEquipo1 = ((List<Equipos>)objCargaE)[1].pID;
                            objpartido.pEquipo2 = ((List<Equipos>)objCargaE)[3].pID;
                            objpartido.pCancha = 1;
                            objpartido.pGoles1 = 0;
                            objpartido.pGoles1 = 0;
                            ngrabados = objCargapartido.abmPartidos("Agregar", objpartido);

                            ngrabados = -1;
                            objpartido.pID_fecha = rondas + 1;
                            objpartido.pEquipo1 = ((List<Equipos>)objCargaE)[0].pID;
                            objpartido.pEquipo2 = ((List<Equipos>)objCargaE)[2].pID;
                            objpartido.pCancha = 2;
                            objpartido.pGoles1 = 0;
                            objpartido.pGoles1 = 0;
                            ngrabados = objCargapartido.abmPartidos("Agregar", objpartido);

                            ngrabados = -1;
                            objpartido.pID_fecha = rondas + 1;
                            objpartido.pEquipo1 = ((List<Equipos>)objCargaE)[5].pID;
                            objpartido.pEquipo2 = ((List<Equipos>)objCargaE)[7].pID;
                            objpartido.pCancha = 3;
                            objpartido.pGoles1 = 0;
                            objpartido.pGoles1 = 0;
                            ngrabados = objCargapartido.abmPartidos("Agregar", objpartido);

                            ngrabados = -1;
                            objpartido.pID_fecha = rondas + 1;
                            objpartido.pEquipo1 = ((List<Equipos>)objCargaE)[4].pID;
                            objpartido.pEquipo2 = ((List<Equipos>)objCargaE)[6].pID;
                            objpartido.pCancha = 4;
                            objpartido.pGoles1 = 0;
                            objpartido.pGoles1 = 0;
                            ngrabados = objCargapartido.abmPartidos("Agregar", objpartido);
                            break;
                        case 3:
                            //inserta 4 partidos
                            ngrabados = -1;
                            objpartido.pID_fecha = rondas + 2;
                            objpartido.pEquipo1 = ((List<Equipos>)objCargaE)[6].pID;
                            objpartido.pEquipo2 = ((List<Equipos>)objCargaE)[5].pID;
                            objpartido.pCancha = 1;
                            objpartido.pGoles1 = 0;
                            objpartido.pGoles1 = 0;
                            ngrabados = objCargapartido.abmPartidos("Agregar", objpartido);

                            ngrabados = -1;
                            objpartido.pID_fecha = rondas + 2;
                            objpartido.pEquipo1 = ((List<Equipos>)objCargaE)[4].pID;
                            objpartido.pEquipo2 = ((List<Equipos>)objCargaE)[7].pID;
                            objpartido.pCancha = 2;
                            objpartido.pGoles1 = 0;
                            objpartido.pGoles1 = 0;
                            ngrabados = objCargapartido.abmPartidos("Agregar", objpartido);

                            ngrabados = -1;
                            objpartido.pID_fecha = rondas + 2;
                            objpartido.pEquipo1 = ((List<Equipos>)objCargaE)[0].pID;
                            objpartido.pEquipo2 = ((List<Equipos>)objCargaE)[3].pID;
                            objpartido.pCancha = 3;
                            objpartido.pGoles1 = 0;
                            objpartido.pGoles1 = 0;
                            ngrabados = objCargapartido.abmPartidos("Agregar", objpartido);

                            ngrabados = -1;
                            objpartido.pID_fecha = rondas + 2;
                            objpartido.pEquipo1 = ((List<Equipos>)objCargaE)[1].pID;
                            objpartido.pEquipo2 = ((List<Equipos>)objCargaE)[2].pID;
                            objpartido.pCancha = 4;
                            objpartido.pGoles1 = 0;
                            objpartido.pGoles1 = 0;
                            ngrabados = objCargapartido.abmPartidos("Agregar", objpartido);
                            break;
                        case 4:
                            //inserta 4 partidos
                            ngrabados = -1;
                            objpartido.pID_fecha = rondas + 3;
                            objpartido.pEquipo1 = ((List<Equipos>)objCargaE)[3].pID;
                            objpartido.pEquipo2 = ((List<Equipos>)objCargaE)[7].pID;
                            objpartido.pCancha = 1;
                            objpartido.pGoles1 = 0;
                            objpartido.pGoles1 = 0;
                            ngrabados = objCargapartido.abmPartidos("Agregar", objpartido);

                            ngrabados = -1;
                            objpartido.pID_fecha = rondas + 3;
                            objpartido.pEquipo1 = ((List<Equipos>)objCargaE)[1].pID;
                            objpartido.pEquipo2 = ((List<Equipos>)objCargaE)[6].pID;
                            objpartido.pCancha = 2;
                            objpartido.pGoles1 = 0;
                            objpartido.pGoles1 = 0;
                            ngrabados = objCargapartido.abmPartidos("Agregar", objpartido);

                            ngrabados = -1;
                            objpartido.pID_fecha = rondas + 3;
                            objpartido.pEquipo1 = ((List<Equipos>)objCargaE)[2].pID;
                            objpartido.pEquipo2 = ((List<Equipos>)objCargaE)[5].pID;
                            objpartido.pCancha = 3;
                            objpartido.pGoles1 = 0;
                            objpartido.pGoles1 = 0;
                            ngrabados = objCargapartido.abmPartidos("Agregar", objpartido);

                            ngrabados = -1;
                            objpartido.pID_fecha = rondas + 3;
                            objpartido.pEquipo1 = ((List<Equipos>)objCargaE)[0].pID;
                            objpartido.pEquipo2 = ((List<Equipos>)objCargaE)[4].pID;
                            objpartido.pCancha = 4;
                            objpartido.pGoles1 = 0;
                            objpartido.pGoles1 = 0;
                            ngrabados = objCargapartido.abmPartidos("Agregar", objpartido);
                            break;
                        case 5:
                            //inserta 4 partidos
                            ngrabados = -1;
                            objpartido.pID_fecha = rondas + 4;
                            objpartido.pEquipo1 = ((List<Equipos>)objCargaE)[1].pID;
                            objpartido.pEquipo2 = ((List<Equipos>)objCargaE)[4].pID;
                            objpartido.pCancha = 1;
                            objpartido.pGoles1 = 0;
                            objpartido.pGoles1 = 0;
                            ngrabados = objCargapartido.abmPartidos("Agregar", objpartido);

                            ngrabados = -1;
                            objpartido.pID_fecha = rondas + 4;
                            objpartido.pEquipo1 = ((List<Equipos>)objCargaE)[2].pID;
                            objpartido.pEquipo2 = ((List<Equipos>)objCargaE)[7].pID;
                            objpartido.pCancha = 2;
                            objpartido.pGoles1 = 0;
                            objpartido.pGoles1 = 0;
                            ngrabados = objCargapartido.abmPartidos("Agregar", objpartido);

                            ngrabados = -1;
                            objpartido.pID_fecha = rondas + 4;
                            objpartido.pEquipo1 = ((List<Equipos>)objCargaE)[0].pID;
                            objpartido.pEquipo2 = ((List<Equipos>)objCargaE)[5].pID;
                            objpartido.pCancha = 3;
                            objpartido.pGoles1 = 0;
                            objpartido.pGoles1 = 0;
                            ngrabados = objCargapartido.abmPartidos("Agregar", objpartido);

                            ngrabados = -1;
                            objpartido.pID_fecha = rondas + 4;
                            objpartido.pEquipo1 = ((List<Equipos>)objCargaE)[3].pID;
                            objpartido.pEquipo2 = ((List<Equipos>)objCargaE)[6].pID;
                            objpartido.pCancha = 4;
                            objpartido.pGoles1 = 0;
                            objpartido.pGoles1 = 0;
                            ngrabados = objCargapartido.abmPartidos("Agregar", objpartido);
                            break;
                        case 6:
                            //inserta 4 partidos
                            ngrabados = -1;
                            objpartido.pID_fecha = rondas + 5;
                            objpartido.pEquipo1 = ((List<Equipos>)objCargaE)[2].pID;
                            objpartido.pEquipo2 = ((List<Equipos>)objCargaE)[4].pID;
                            objpartido.pCancha = 1;
                            objpartido.pGoles1 = 0;
                            objpartido.pGoles1 = 0;
                            ngrabados = objCargapartido.abmPartidos("Agregar", objpartido);

                            ngrabados = -1;
                            objpartido.pID_fecha = rondas + 5;
                            objpartido.pEquipo1 = ((List<Equipos>)objCargaE)[0].pID;
                            objpartido.pEquipo2 = ((List<Equipos>)objCargaE)[6].pID;
                            objpartido.pCancha = 2;
                            objpartido.pGoles1 = 0;
                            objpartido.pGoles1 = 0;
                            ngrabados = objCargapartido.abmPartidos("Agregar", objpartido);

                            ngrabados = -1;
                            objpartido.pID_fecha = rondas + 5;
                            objpartido.pEquipo1 = ((List<Equipos>)objCargaE)[1].pID;
                            objpartido.pEquipo2 = ((List<Equipos>)objCargaE)[7].pID;
                            objpartido.pCancha = 3;
                            objpartido.pGoles1 = 0;
                            objpartido.pGoles1 = 0;
                            ngrabados = objCargapartido.abmPartidos("Agregar", objpartido);

                            ngrabados = -1;
                            objpartido.pID_fecha = rondas + 5;
                            objpartido.pEquipo1 = ((List<Equipos>)objCargaE)[3].pID;
                            objpartido.pEquipo2 = ((List<Equipos>)objCargaE)[5].pID;
                            objpartido.pCancha = 4;
                            objpartido.pGoles1 = 0;
                            objpartido.pGoles1 = 0;
                            ngrabados = objCargapartido.abmPartidos("Agregar", objpartido);
                            break;
                        case 7:
                            //inserta 4 partidos
                            ngrabados = -1;
                            objpartido.pID_fecha = rondas + 6;
                            objpartido.pEquipo1 = ((List<Equipos>)objCargaE)[0].pID;
                            objpartido.pEquipo2 = ((List<Equipos>)objCargaE)[7].pID;
                            objpartido.pCancha = 1;
                            objpartido.pGoles1 = 0;
                            objpartido.pGoles1 = 0;
                            ngrabados = objCargapartido.abmPartidos("Agregar", objpartido);

                            ngrabados = -1;
                            objpartido.pID_fecha = rondas + 6;
                            objpartido.pEquipo1 = ((List<Equipos>)objCargaE)[3].pID;
                            objpartido.pEquipo2 = ((List<Equipos>)objCargaE)[4].pID;
                            objpartido.pCancha = 2;
                            objpartido.pGoles1 = 0;
                            objpartido.pGoles1 = 0;
                            ngrabados = objCargapartido.abmPartidos("Agregar", objpartido);

                            ngrabados = -1;
                            objpartido.pID_fecha = rondas + 6;
                            objpartido.pEquipo1 = ((List<Equipos>)objCargaE)[1].pID;
                            objpartido.pEquipo2 = ((List<Equipos>)objCargaE)[5].pID;
                            objpartido.pCancha = 3;
                            objpartido.pGoles1 = 0;
                            objpartido.pGoles1 = 0;
                            ngrabados = objCargapartido.abmPartidos("Agregar", objpartido);

                            ngrabados = -1;
                            objpartido.pID_fecha = rondas + 6;
                            objpartido.pEquipo1 = ((List<Equipos>)objCargaE)[2].pID;
                            objpartido.pEquipo2 = ((List<Equipos>)objCargaE)[6].pID;
                            objpartido.pCancha = 4;
                            objpartido.pGoles1 = 0;
                            objpartido.pGoles1 = 0;
                            ngrabados = objCargapartido.abmPartidos("Agregar", objpartido);
                            break;

                    }
                }

                for (int x = 0; x < 8; x++)
            {
                int nGrabados = -1;
                Posiciones objPosicion = new Posiciones();
                objPosicion.pID_Equi = ((List<Equipos>)objCargaE)[x].pID;
                nGrabados = objEquipoPos.abmPosicion("AgregarNuevo", objPosicion);

            }


                // Create a DataTable to hold the data
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Fecha", typeof(string));
                dataTable.Columns.Add("Equipo 1", typeof(string));
                dataTable.Columns.Add("Equipo 2", typeof(string));
                dataTable.Columns.Add("Cancha", typeof(int));
                dataTable.Columns.Add("Goles 1", typeof(int));
                dataTable.Columns.Add("Goles 2", typeof(int));

                // Add the matches to the corresponding dates
                for (int x = 1; x < 8; x++)
                {
                    string fecha = "Fecha N° " + x;
                    DataRow[] rows = dataTable.Select("Fecha = '" + fecha + "'");
                    DataTable filteredTable = dataTable.Clone();
                    foreach (DataRow row in rows)
                    {
                        filteredTable.ImportRow(row);
                    }
                    dgv_datos1.DataSource = filteredTable;
                    dgv_datos1.Refresh();
                    System.Threading.Thread.Sleep(1000); // Wait 1 second before showing the next date
                }

                cmb_fechas.Enabled = true;
            btn_ver_fecha.Enabled = true;
            btn_sortear.Enabled = false;
            dtp_comienzo.Enabled = false;
            MessageBox.Show("Se realizo el sorteo con exito");

        }
            else
            {
                MessageBox.Show("Elija nuevamente el dia del comienzo del campeonato");
            }



}
            private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_ver_fecha_Click(object sender, EventArgs e)
        {
            
            int busqueda = 1;
            string dato = cmb_fechas.SelectedValue.ToString();
            dgv_datos1.Columns.Clear();
            dgv_datos1.DataSource = null;
            DataTable dt = new DataTable();
            dt = objCargapartido.listadoPartidos(dato, busqueda);
            dgv_datos1.DataSource = dt;
            dgv_datos1.Columns[0].Width = 70;
            dgv_datos1.Columns[1].Width = 140;
            dgv_datos1.Columns[2].Width = 40;
            dgv_datos1.Columns[3].Width = 140;
            dgv_datos1.Columns[4].Width = 40;
            dgv_datos1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void frm_sorteo_Load(object sender, EventArgs e)
        {

        }
    }
}
