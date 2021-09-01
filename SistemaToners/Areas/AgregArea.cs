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
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            Area nuevaArea = new Area();
            nuevaArea.Nombre_area = nombArea.Text;
            Conexiones nuevaConexion = new Conexiones();
            nuevaConexion.AltaArea(nuevaArea);
            this.Close();
        }
    }
}
