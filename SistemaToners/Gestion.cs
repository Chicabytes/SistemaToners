using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            nuevoToner ntoner = new nuevoToner();
            ntoner.Show();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Gestion.Visible = true;
            NuevaImpresora.Visible = false;
        }

        private void areaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListaAreas nlistaarea = new ListaAreas();
            nlistaarea.Show();
        }
    }
}
