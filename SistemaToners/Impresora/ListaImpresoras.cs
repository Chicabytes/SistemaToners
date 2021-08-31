using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaToners.Impresora
{
    public partial class ListaImpresoras : Form
    {
        public ListaImpresoras()
        {
            InitializeComponent();
        }

        private void ListaImpresoras_Load(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Exoprtar_Click(object sender, EventArgs e)
        {
            saveFile = new SaveFileDialog();
            saveFile.ShowDialog();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
