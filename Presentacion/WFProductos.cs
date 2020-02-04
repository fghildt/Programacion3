using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Presentacion
{
    public partial class WFProductos : Form
    {
        public WFProductos()
        {
            InitializeComponent();
        }

        private void WFProductos_Load(object sender, EventArgs e)
        {
            ProductosDB productosDB = new ProductosDB();
            try
            {
                dgvProductos.DataSource = productosDB.Listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregarClie_Click(object sender, EventArgs e)
        {
            WFAgregarProducto wFAgregarProducto = new WFAgregarProducto();
            wFAgregarProducto.ShowDialog();
            WFProductos_Load(sender, e);
        }

        private void btnEliminarClie_Click(object sender, EventArgs e)
        {
            ProductosDB productosDB = new ProductosDB();
            try
            {
                if (dgvProductos.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("Está seguro que desea eliminar el registro?", "No apto para inseguros", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Producto aux = (Producto)dgvProductos.CurrentRow.DataBoundItem;
                        productosDB.Eliminar(aux.IdProducto);
                        WFProductos_Load(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor seleccione un registro");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnModificarClie_Click(object sender, EventArgs e)
        {
            Producto modifProd = (Producto)dgvProductos.CurrentRow.DataBoundItem;
            WFAgregarProducto wFAgregarProducto = new WFAgregarProducto(modifProd);
            wFAgregarProducto.ShowDialog();
            WFProductos_Load(sender, e);
        }
    }
}
