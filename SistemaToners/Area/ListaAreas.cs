using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaToners.Area
{
    public partial class ListaAreas : Form
    {
        public ListaAreas()
        {
            InitializeComponent();
        }

        private void AgreArea_Click(object sender, EventArgs e)
        {
            AgregArea nagregar = new AgregArea();
            nagregar.Show();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
