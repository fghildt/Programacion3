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
    public partial class WFClientes : Form
    {
        public WFClientes()
        {
            InitializeComponent();
        }

        private void WFClientes_Load(object sender, EventArgs e)
        {
            ClientesDB clientesDB = new ClientesDB();
            try
            {
                dgvClientes.DataSource = clientesDB.Listar();
                dgvClientes.Columns[0].Visible = false;
                dgvClientes.Columns[1].Width = 50;
                dgvClientes.Columns[5].DisplayIndex =1;
                dgvClientes.Columns[4].Width = 120;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregarClie_Click(object sender, EventArgs e)
        {
            WFAgregarCliente wFAgregarCliente = new WFAgregarCliente();
            wFAgregarCliente.ShowDialog();
            WFClientes_Load(sender, e);
        }

        private void btnEliminarClie_Click(object sender, EventArgs e)
        {
            ClientesDB clientesDB = new ClientesDB();
            try
            {
                if (dgvClientes.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("Está seguro que desea eliminar el registro?", "No apto para inseguros", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Cliente aux = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
                        clientesDB.Eliminar(aux.Id);
                        WFClientes_Load(sender, e);
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
            Cliente modifClie = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
            WFAgregarCliente wFAgregarCliente = new WFAgregarCliente(modifClie);
            wFAgregarCliente.ShowDialog();
            WFClientes_Load(sender, e);
        }

    }
}
