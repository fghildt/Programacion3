using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            WFMarcas wFMarcas = new WFMarcas();
            wFMarcas.ShowDialog();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            WFCategorias wFCategorias = new WFCategorias();
            wFCategorias.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            WFClientes wFClientes = new WFClientes();
            wFClientes.ShowDialog();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            WFProveedores wFProveedores = new WFProveedores();
            wFProveedores.ShowDialog();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            WFProductos wFProductos = new WFProductos();
            wFProductos.ShowDialog();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            WFComprar wFComprar = new WFComprar();
            wFComprar.ShowDialog();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            WFVender wFVender = new WFVender();
            wFVender.ShowDialog();
        }
    }
}
