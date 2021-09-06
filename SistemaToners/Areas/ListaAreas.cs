using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SistemaToners.Entidades;
using SistemaToners.Conexion;

namespace SistemaToners.Areas
{
    public partial class ListaAreas : Form
    {
        public ListaAreas()
        {
            InitializeComponent();
            Conexiones nuevaConexion = new Conexiones();
            List<AreayPuesto> ListaPuestos = nuevaConexion.ListaPuesto();
            foreach (var Puesto in ListaPuestos)
            {
                ListArea.Items.Add(Puesto.Area_puesto.Nombre_area.ToString());
            }
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

        private void Buscar_Click(object sender, EventArgs e)
        {
        }
    }
}
