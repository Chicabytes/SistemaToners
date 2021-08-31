using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaToners.Impresora;
using SistemaToners.Area;

namespace SistemaToners
{
    public partial class Sistoners : Form
    {
        public Sistoners()
        {
            InitializeComponent();
        }
        private void tonerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListaToners lista = new ListaToners();
            lista.ShowDialog();
        }
        private void CambioToner_Click(object sender, EventArgs e)
        {
            CambiarToner cambiarToner = new CambiarToner();
            cambiarToner.Show();
        }

        private void nuevaImpresoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gestion.Visible = false;
            NuevaImpresora.Visible = true;
        }

        private void gestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gestion.Visible = true;
            NuevaImpresora.Visible = false;
        }

        private void nuevoTonerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoToner ntoner = new NuevoToner();
            ntoner.Show();
        }

        private void listaImpresorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaImpresoras impresoras = new ListaImpresoras();
            impresoras.Show();
        }
        private void nuevonuevoTonerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoToner nuevoToner = new NuevoToner();
            nuevoToner.Show();
        }

        private void editarTonerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Necesito sobrecargar el objeto para que se envie con la informacion existente del toner para su upgrade
            NuevoToner nuevoToner = new NuevoToner();
            nuevoToner.Show();
        }

        private void areaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AgregArea agregArea = new AgregArea();
            agregArea.Show();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Gestion.Visible = true;
            NuevaImpresora.Visible = false;
        }
    }
}
