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
    public partial class WFAgregarProducto : Form
    {
        public WFAgregarProducto()
        {
            InitializeComponent();
        }

        public WFAgregarProducto(Producto prod)
        {
            InitializeComponent();
            this.producto = prod;
            Text = "Modificar";
            TBNombreProd.Text = prod.Nombre.ToString();
            TBPrecCompraProd.Text = prod.PrecioCompra.ToString();
            TBPorcentajeGanProd.Text = prod.PorcentajeGanancia.ToString();

        }

        private void btnCancelarCliente_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Perderá todos los datos, está seguro?", "Cerrar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private Producto producto;

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            ProductosDB productosDB = new ProductosDB();

            try
            {
                if (producto == null) { producto = new Producto(); }

                producto.Nombre = TBNombreProd.Text.Trim();
                producto.Nombre = producto.Nombre.ToUpper();
                producto.PrecioCompra = Double.Parse(TBPrecCompraProd.Text.Trim().Replace(".",","));
                producto.PorcentajeGanancia = Convert.ToDouble(TBPorcentajeGanProd.Text.Trim());
                producto.Marca = (Marca)CBMarcaProd.SelectedItem;
                producto.Tipo = (Tipo)CBCategoriaProd.SelectedItem;

                if (Text != "Modificar")
                {
                    productosDB.Agregar(producto);
                    MessageBox.Show("Agregado con éxito");
                }
                else
                {
                    productosDB.Modificar(producto);
                    MessageBox.Show("Modificado con éxito");
                }
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void WFAgregarProducto_Load(object sender, EventArgs e)
        {
            CategoriasDB categoriasDB = new CategoriasDB();
            CBCategoriaProd.DataSource = categoriasDB.Listar();
            MarcasDB marcasDB = new MarcasDB();
            CBMarcaProd.DataSource = marcasDB.Listar();

            CBMarcaProd.ValueMember = "Id";
            CBMarcaProd.DisplayMember = "Nombre";

            CBCategoriaProd.ValueMember = "Id";
            CBCategoriaProd.DisplayMember = "Nombre";
            if (Text == "Modificar")
            {
                CBMarcaProd.SelectedValue = producto.Marca.Id;
                CBCategoriaProd.SelectedValue = producto.Tipo.Id;
            }
        }
    }
}
