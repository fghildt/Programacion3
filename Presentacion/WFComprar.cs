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
    public partial class WFComprar : Form
    {
        public WFComprar()
        {
            InitializeComponent();
        }

        IList<DetalleCompras> listacompras = new List<DetalleCompras>();
        Compra compranueva = new Compra();

        private void WFComprar_Load(object sender, EventArgs e)
        {
            ProveedoresDB proveedoresDB = new ProveedoresDB();
            ProductosDB productosDB = new ProductosDB();
            TipoFcDB tipoFcDB = new TipoFcDB();
            try
            {


                Proveedor proveedor = new Proveedor();
                CBProveedor.DataSource = proveedoresDB.Listar();
                proveedor = (Proveedor)CBProveedor.SelectedItem;
                CBProductos.DataSource = productosDB.Listar(proveedor.Id);
                CBTipoFc.DataSource = tipoFcDB.Listar();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            DetalleCompras detallenuevo = new DetalleCompras();
            
            try
            {
                if (!string.IsNullOrEmpty(TBCant.Text))
                {
                    if (!string.IsNullOrEmpty(TBPrecio.Text))
                    {
                        if (DateTime.Compare(DTPFechaFC.Value, DateTime.Today) <= 0)
                        {
                            TBFactura.Enabled = false;
                            TBPrefijoFC.Enabled = false;
                            CBTipoFc.Enabled = false;
                            DTPFechaFC.Enabled = false;
                            CBProveedor.Enabled = false;

                            detallenuevo.Cantidad = Int32.Parse(TBCant.Text.Trim());
                            detallenuevo.Precio = Double.Parse(TBPrecio.Text.Trim());

                            producto = (Producto)CBProductos.SelectedItem;
                            detallenuevo.IdProducto = producto.IdProducto;
                            detallenuevo.Nombre = producto.Nombre;

                            listacompras.Add(detallenuevo);

                            dgvCompras.DataSource = null;
                            dgvCompras.DataSource = listacompras;
                            dgvCompras.Columns[0].Visible = false;
                            dgvCompras.Columns[1].Visible = false;
                            dgvCompras.Columns[3].Visible = false;

                            TBPrecio.Text = "";
                            TBCant.Text = "";
                            dgvCompras.Focus();

                            TextAlerta.Text = "";
                        }
                        else
                        {
                            TextAlerta.Text = "Ingrese una fecha válida";

                        }
                    }
                    else
                    {
                        TextAlerta.Text = "Ingrese un precio";
                    }

                }

                else
                {
                    TextAlerta.Text = "Ingrese una cantidad";
                }

            }
            catch (Exception ex)
            {

               MessageBox.Show(ex.ToString());
            }
        }

        private void BTNEliminar_Click(object sender, EventArgs e)
        {
            DetalleCompras detalleeliminar = new DetalleCompras();
            try
            {
                if (dgvCompras.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("Está seguro que desea eliminar el registro?", "No apto para inseguros", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        detalleeliminar = (DetalleCompras)dgvCompras.CurrentRow.DataBoundItem;
                       
                        listacompras.Remove(detalleeliminar);
                        dgvCompras.DataSource = null;
                        dgvCompras.DataSource = listacompras;
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

        private void btnAgregarCompra_Click(object sender, EventArgs e)
        {
            ComprasDB comprasDB = new ComprasDB();
            DetalleComprasDB detalleComprasDB = new DetalleComprasDB();
            ProductosDB productosDB = new ProductosDB();
            try
            {
                if (dgvCompras.Rows.Count > 0)
                {
                    Proveedor proveedor = new Proveedor();
                    TipoFC tipoFC = new TipoFC();

                    tipoFC = (TipoFC)CBTipoFc.SelectedItem;

                    proveedor = (Proveedor)CBProveedor.SelectedItem;
                    compranueva.IdProveedor = proveedor.Id;
                    compranueva.PrefijoFc = Int32.Parse(TBPrefijoFC.Text.Trim());
                    compranueva.Factura = Int32.Parse(TBFactura.Text.Trim());
                    compranueva.idTipoFC = tipoFC.idTipoFC;
                    compranueva.Fecha = DTPFechaFC.Value;

                    comprasDB.Agregar(compranueva);
                    int ultimacompra = comprasDB.UltimaCompra();

                    for (int i = 0; i < listacompras.Count; i++)
                    {
                        listacompras[i].IdCompra = ultimacompra;
                        detalleComprasDB.Agregar(listacompras[i]);
                        productosDB.LevantarStock(listacompras[i].IdProducto, listacompras[i].Cantidad);
                    }

                    MessageBox.Show("Compra agregada con éxito", "Compra exitosa!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void CBProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductosDB productosDB = new ProductosDB();
            try
            {
                Proveedor proveedor = new Proveedor();
                proveedor = (Proveedor)CBProveedor.SelectedItem;
                if (productosDB.Listar(proveedor.Id).Count != 0)
                {
                    CBProductos.Enabled = true;
                    CBProductos.DataSource = productosDB.Listar(proveedor.Id);
                }
                else
                {
                    CBProductos.DataSource = null;
                    CBProductos.Enabled = false;
                    btnAgregar.Enabled = false;
                }

                dgvCompras.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //VALIDACIONES SOLO NUMEROS TEXTBOX DE CANBTIDAD, PRECIO, ETC.
        
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

        private void TBPrecio_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TBFactura_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TBPrefijoFC_KeyPress(object sender, KeyPressEventArgs e)
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
