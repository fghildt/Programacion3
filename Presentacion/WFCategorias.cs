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
    public partial class WFCategorias : Form
    {
        public WFCategorias()
        {
            InitializeComponent();
        }

        private void WFCategorias_Load(object sender, EventArgs e)
        {
            CategoriasDB categoriasDB = new CategoriasDB();

            try
            {
                dgvCategorias.DataSource = categoriasDB.Listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregarCat_Click(object sender, EventArgs e)
        {
            WFAgregarCategoria wFAgregarCategoria = new WFAgregarCategoria();
            wFAgregarCategoria.ShowDialog();
            WFCategorias_Load(sender, e);
        }

        private void btnEliminarCat_Click(object sender, EventArgs e)
        {
            CategoriasDB categoriasDB = new CategoriasDB();
            try
            {
                if (dgvCategorias.SelectedRows.Count>0)
                {
                    if (MessageBox.Show("Está seguro que desea eliminar el registro?","No apto para inseguros",MessageBoxButtons.YesNo)==DialogResult.Yes)
                    {
                        Tipo aux = (Tipo)dgvCategorias.CurrentRow.DataBoundItem;
                        categoriasDB.Eliminar(aux.Id);
                        WFCategorias_Load(sender, e);
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

        private void btnModificarCat_Click(object sender, EventArgs e)
        {
            Tipo modifCat = (Tipo)dgvCategorias.CurrentRow.DataBoundItem;
            WFAgregarCategoria wFAgregarCategoria = new WFAgregarCategoria(modifCat);
            wFAgregarCategoria.ShowDialog();
            WFCategorias_Load(sender, e);
        }
    }
}
