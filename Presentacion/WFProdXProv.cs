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
    public partial class WFProdXProv : Form
    {
        Proveedor Proveedor;
        public WFProdXProv(Proveedor IdProveedor)
        {
            Proveedor = IdProveedor;
            InitializeComponent();
        }

        public WFProdXProv()
        {
            InitializeComponent();
        }

        IList<Producto> listaprodActual = new List<Producto>();
        IList<Producto> listaprodPendientes = new List<Producto>();
        IList<Producto> listaprodAgregar = new List<Producto>();

        private void WFProdXProv_Load(object sender, EventArgs e)
        {
            ProductosDB productosDB = new ProductosDB();

            try
            {
                TextNombreProv.Text = "Proveedor: " + Proveedor.NombreApellido;

                listaprodActual = productosDB.Listar(Proveedor.Id);
                listaprodPendientes = productosDB.ListarNegado(Proveedor.Id);

                dgvProductosActivos.DataSource = listaprodActual;
                CBProductos.DataSource = listaprodPendientes;

                dgvProductosActivos.Columns[0].Visible = false;
                dgvProductosActivos.Columns[2].Visible = false;
                dgvProductosActivos.Columns[3].Visible = false;
                dgvProductosActivos.Columns[4].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            listaprodAgregar.Add((Producto)CBProductos.SelectedItem);
            listaprodActual.Add((Producto)CBProductos.SelectedItem);
            listaprodPendientes.Remove((Producto)CBProductos.SelectedItem);

            dgvProductosActivos.DataSource = null;
            dgvProductosActivos.DataSource = listaprodActual;
            CBProductos.DataSource = null;
            CBProductos.DataSource = listaprodPendientes;

            dgvProductosActivos.Columns[0].Visible = false;
            dgvProductosActivos.Columns[2].Visible = false;
            dgvProductosActivos.Columns[3].Visible = false;
            dgvProductosActivos.Columns[4].Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ProdXProvDB prodXProvDB = new ProdXProvDB();

            try
            {
                if(listaprodAgregar.Count>0)
                {
                    for (int i = 0; i < listaprodAgregar.Count; i++)
                    {
                        prodXProvDB.Agregar(Proveedor.Id, listaprodAgregar[i].IdProducto);
                    }
                }

                MessageBox.Show("Transacción exitosa", "Productos agregados con éxito al proveedor!");
                this.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
