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
    public partial class WFVender : Form
    {
        public WFVender()
        {
            InitializeComponent();
        }

        IList<DetalleVentas> listaventas = new List<DetalleVentas>();
        IList<Producto> listaproductos = new List<Producto>();

        private void WFVender_Load(object sender, EventArgs e)
        {
            ClientesDB clientesDB = new ClientesDB();
            ProductosDB productosDB = new ProductosDB();
            TipoFcDB tipoFcDB = new TipoFcDB();
            try
            {
                
                listaproductos = productosDB.Listar();
                CBCliente.DataSource = clientesDB.Listar();
                CBTipoFc.DataSource = tipoFcDB.Listar();
                CBProductos.DataSource = listaproductos;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Producto producto = new Producto();
                DetalleVentas detalleVentas = new DetalleVentas();

                if (!string.IsNullOrEmpty(TBCant.Text))
                {
                    detalleVentas.Cantidad = Int32.Parse(TBCant.Text.Trim());
                    producto = (Producto)CBProductos.SelectedItem;

                    if (producto.Stock >= detalleVentas.Cantidad)
                    {
                        producto.Stock = producto.Stock - detalleVentas.Cantidad;
                        listaproductos.Remove((Producto)CBProductos.SelectedItem);
                        listaproductos.Add(producto);

                        detalleVentas.IdProducto = producto.IdProducto;
                        detalleVentas.Nombre = producto.Nombre;

                        listaventas.Add(detalleVentas);

                        dgvVentas.DataSource = null;
                        dgvVentas.DataSource = listaventas;
                        dgvVentas.Columns[0].Visible = false;
                        dgvVentas.Columns[2].Visible = false;
                        dgvVentas.Columns[3].Visible = false;

                        TBCant.Text = "";
                        dgvVentas.Focus();

                        TextAlertaCant.Text = "";

                        CBProductos.DataSource = null;
                        CBProductos.DataSource = listaproductos;
                    }
                    else
                    {
                        TextAlertaCant.Text = "Stock insuficiente. Stock actual "+ producto.Stock.ToString() + " un.";
                    }

                }
                else
                {
                    TextAlertaCant.Text = "!";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void BTNEliminar_Click(object sender, EventArgs e)
        {
            DetalleVentas detalleeliminar = new DetalleVentas();
            try
            {
                if (dgvVentas.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("No apto para inseguros", "Está seguro que desea eliminar el registro?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        detalleeliminar = (DetalleVentas)dgvVentas.CurrentRow.DataBoundItem;

                        listaventas.Remove(detalleeliminar);
                        dgvVentas.DataSource = null;
                        dgvVentas.DataSource = listaventas;
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

        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {
            VentasDB ventasDB = new VentasDB();
            DetalleVentasDB detalleVentasDB = new DetalleVentasDB();
            ProductosDB productosDB = new ProductosDB();

            try
            {
                if (dgvVentas.Rows.Count > 0)
                {
                    Cliente cliente = new Cliente();
                    TipoFC tipoFC = new TipoFC();
                    Venta ventaNueva = new Venta();

                    tipoFC = (TipoFC)CBTipoFc.SelectedItem;
                    cliente = (Cliente)CBCliente.SelectedItem;

                    ventaNueva.Fecha = DateTime.Today;
                    ventaNueva.IdCliente = cliente.Id;
                    ventaNueva.idTipoFC = tipoFC.idTipoFC;
                    ventaNueva.Factura = ventasDB.UltimaVenta(ventaNueva.idTipoFC) + 1;

                    ventasDB.Agregar(ventaNueva);
                    ventasDB.ActualizarUltimaVenta(ventaNueva);

                    ventaNueva.IdVenta = ventasDB.UltimoIdVenta();

                    for (int i = 0; i < listaventas.Count; i++)
                    {
                        listaventas[i].IdVenta = ventaNueva.IdVenta;
                        detalleVentasDB.Agregar(listaventas[i]);
                        productosDB.LevantarStock(listaventas[i].IdProducto, listaventas[i].Cantidad*-1);
                    }


                    MessageBox.Show("Venta agregada con éxito", "Venta exitosa");
                    this.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void TBCant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
