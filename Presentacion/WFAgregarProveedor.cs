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
    public partial class WFAgregarProveedor : Form
    {
        public WFAgregarProveedor()
        {
            InitializeComponent();
        }

        public WFAgregarProveedor(Proveedor prov)
        {
            InitializeComponent();
            this.proveedor = prov;
            Text = "Modificar";
            TBCuitProv.Text = prov.Cuit.ToString();
            TBNombreProv.Text = prov.NombreApellido.ToString();
            TBTelefProv.Text = prov.Telefono.ToString();
            TBDireccProv.Text = prov.Direccion.ToString();
            TBMailPRov.Text = prov.Mail.ToString();
            btnProdXProv.Enabled = true;
        }

        private Proveedor proveedor;

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            ProveedoresDB proveedoresDB = new ProveedoresDB();

            try
            {
                if (proveedor == null) { proveedor = new Proveedor(); }
                proveedor.NombreApellido = TBNombreProv.Text.Trim();
                proveedor.NombreApellido = proveedor.NombreApellido.ToUpper();
                proveedor.Cuit = TBCuitProv.Text.Trim();
                proveedor.Telefono = TBTelefProv.Text.Trim();
                proveedor.Direccion = TBDireccProv.Text.Trim();
                proveedor.Direccion = proveedor.Direccion.ToUpper();
                proveedor.Mail = TBMailPRov.Text.Trim();


                if (Text != "Modificar")
                {
                    proveedoresDB.Agregar(proveedor);
                    if (MessageBox.Show("La operación se ha completado con éxito. Desea agregar productos al proveedor?","Transacción exitosa!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        WFProdXProv wFProdXProv = new WFProdXProv(proveedor);
                        wFProdXProv.ShowDialog();
                    }


                }
                else
                {
                    proveedoresDB.Modificar(proveedor);
                    MessageBox.Show("Modificado con éxito");
                }
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelarProveedor_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Perderá todos los datos, está seguro?", "Cerrar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnProdXProv_Click(object sender, EventArgs e)
        {
            WFProdXProv wFProdXProv = new WFProdXProv(proveedor);
            wFProdXProv.ShowDialog();
        }
    }
}
