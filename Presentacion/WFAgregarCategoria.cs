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
    public partial class WFAgregarCategoria : Form
    {
        public WFAgregarCategoria()
        {
            InitializeComponent();
        }

        public WFAgregarCategoria(Tipo tipo)
        {
            InitializeComponent();
            this.categoria = tipo;
            Text = "Modificar";
            TBCategoriaNueva.Text = tipo.Nombre.ToString();
        }

        private Tipo categoria;

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            CategoriasDB categoriasDB = new CategoriasDB();
            try
            {
                if (categoria == null) { categoria = new Tipo(); }
                categoria.Nombre = TBCategoriaNueva.Text.Trim();
                categoria.Nombre = categoria.Nombre.ToUpper();


                if(Text != "Modificar")
                { 
                categoriasDB.Agregar(categoria);
                MessageBox.Show("Agregado con éxito");
                }
                else
                {
                    categoriasDB.Modificar(categoria);
                    MessageBox.Show("Modificado con éxito");
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelarMarca_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Perderá todos los datos, está seguro?", "Cerrar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
