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
    public partial class WFAgregarMarca : Form
    {
        public WFAgregarMarca()
        {
            InitializeComponent();
        }

        public WFAgregarMarca(Marca modifMarca)
        {
            InitializeComponent();
            this.marca = modifMarca;
            Text = "Modificar";
            TBMarcaNueva.Text = modifMarca.Nombre.ToString();
        }

        private Marca marca;

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            MarcasDB marcasDB = new MarcasDB();

            try
            {
                if (marca == null) { marca = new Marca(); }
                marca.Nombre = TBMarcaNueva.Text.Trim();
                marca.Nombre = marca.Nombre.ToUpper();


                if (Text != "Modificar")
                {
                    marcasDB.Agregar(marca);
                    MessageBox.Show("Agregado con éxito");
                }
                else
                {
                    marcasDB.Modificar(marca);
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
