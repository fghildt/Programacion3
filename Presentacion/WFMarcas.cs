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
    public partial class WFMarcas : Form
    {
        public WFMarcas()
        {
            InitializeComponent();
        }

        private void WFMarcas_Load(object sender, EventArgs e)
        {
            MarcasDB marcasDB = new Negocio.MarcasDB();

            try
            {
                dgvMarcas.DataSource = marcasDB.Listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregarMarcas_Click(object sender, EventArgs e)
        {
            WFAgregarMarca wFAgregarMarca = new WFAgregarMarca();
            wFAgregarMarca.ShowDialog();
            WFMarcas_Load(sender, e);
        }

        private void btnEliminarMarcas_Click(object sender, EventArgs e)
        {
            MarcasDB marcasDB = new MarcasDB();
            try
            {
                if (dgvMarcas.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("Está seguro que desea eliminar el registro?", "No apto para inseguros", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Marca aux = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
                        marcasDB.Eliminar(aux.Id);
                        WFMarcas_Load(sender, e);
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

        private void btnModificarCMarca_Click(object sender, EventArgs e)
        {
            Marca modifMarca = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
            WFAgregarMarca wFAgregarMarca = new WFAgregarMarca(modifMarca);
            wFAgregarMarca.ShowDialog();
            WFMarcas_Load(sender, e);
        }
    }
}
