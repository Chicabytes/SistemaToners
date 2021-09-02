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
    public partial class AgregArea : Form
    {
        public AgregArea()
        {
            InitializeComponent();
            Conexiones nuevaConexion = new Conexiones();
            List<Area> ListaArea = nuevaConexion.ListaAreas();
            foreach (var Area in ListaArea)
            {
                nArea.Items.Add(Area.Nombre_area.ToString());
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            Conexiones nuevaConexion = new Conexiones();
            if(nombrArea.TextLength != 0)
            {
                Area nuevaArea = new Area();
                nuevaArea.Nombre_area = nombrArea.Text;
                nuevaConexion.AltaArea(nuevaArea);
                this.Close();
            }
            else
            {
                Area elemento = (Area) nArea.SelectedItem;
                AreayPuesto nAreayPuesto = new AreayPuesto(elemento, Convert.ToInt32(nuevoNPuesto.Text));
                nuevaConexion.AltaPuesto(nAreayPuesto);
                this.Close();
            }
        }
    }
}
