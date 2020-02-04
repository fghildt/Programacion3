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
    public partial class WFProveedores : Form
    {
        public WFProveedores()
        {
            InitializeComponent();
        }

        private void WFProveedores_Load(object sender, EventArgs e)
        {
            ProveedoresDB proveedoresDB = new ProveedoresDB();
            try
            {
                dgvProveedores.DataSource = proveedoresDB.Listar();
                dgvProveedores.Columns[0].Visible = false;
                dgvProveedores.Columns[5].DisplayIndex = 0;
                dgvProveedores.Columns[4].Width = 120;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregarClie_Click(object sender, EventArgs e)
        {
            WFAgregarProveedor wFAgregarProveedor = new WFAgregarProveedor();
            wFAgregarProveedor.ShowDialog();
            WFProveedores_Load(sender, e);
        }

        private void btnEliminarClie_Click(object sender, EventArgs e)
        {
            ProveedoresDB proveedoresDB = new ProveedoresDB();
            try
            {
                if (dgvProveedores.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("Está seguro que desea eliminar el registro?", "No apto para inseguros", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Proveedor aux = (Proveedor)dgvProveedores.CurrentRow.DataBoundItem;
                        proveedoresDB.Eliminar(aux.Id);
                        WFProveedores_Load(sender, e);
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
            Proveedor modifProv = (Proveedor)dgvProveedores.CurrentRow.DataBoundItem;
            WFAgregarProveedor wFAgregarProveedor = new WFAgregarProveedor(modifProv);
            wFAgregarProveedor.ShowDialog();
            WFProveedores_Load(sender, e);
        }

    }
}
