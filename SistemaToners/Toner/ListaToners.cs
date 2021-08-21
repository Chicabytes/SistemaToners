using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaToners
{
    public partial class ListaToners : Form
    {
        public ListaToners()
        {
            InitializeComponent();
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
