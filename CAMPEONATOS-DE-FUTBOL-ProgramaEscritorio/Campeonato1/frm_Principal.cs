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
    public partial class frm_Principal : Form
    {
        public frm_Principal()
        {
            InitializeComponent();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void agregarEquipoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_equipos form_equipos = new frm_equipos();
            form_equipos.ShowDialog();
        }

        private void agregarJugadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_jugadores form_jugadores = new frm_jugadores();
            form_jugadores.ShowDialog();
        }

        private void sorteoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_sorteo form_sorteo = new frm_sorteo();
            form_sorteo.ShowDialog();
        }

        private void tablaDePosicionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_posicion form_tabla = new frm_posicion();
            form_tabla.ShowDialog();
        }

        
    }
}
