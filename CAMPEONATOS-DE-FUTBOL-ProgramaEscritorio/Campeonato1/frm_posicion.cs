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
    public partial class frm_posicion : Form
    {
        public ClasePosiciones objTabla = new ClasePosiciones();
        public frm_posicion()
        {
            InitializeComponent();
            Mostrar();
        }

        private void Mostrar()
        {
            int busqueda = 1;
            dgv_posicion.Columns.Clear();
            dgv_posicion.DataSource = null;
            DataTable dt = new DataTable();
            dt = objTabla.listadoPosiciones("", busqueda);
            dgv_posicion.DataSource = dt;
            dgv_posicion.Columns[0].Width = 140;
            dgv_posicion.Columns[1].Width = 40;
            dgv_posicion.Columns[2].Width = 40;
            dgv_posicion.Columns[3].Width = 40;
            dgv_posicion.Columns[4].Width = 40;
            dgv_posicion.Columns[5].Width = 40;
            dgv_posicion.Columns[6].Width = 40;
            dgv_posicion.Columns[7].Width = 40;
            dgv_posicion.Columns[8].Width = 60;
            dgv_posicion.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
