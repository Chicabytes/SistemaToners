using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void Cancelar_Click(object sender, EventArgs e)
        {
            gestionToolStripMenuItem_Click(sender, e);
        }
    }
}
