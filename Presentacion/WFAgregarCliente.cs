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
    public partial class WFAgregarCliente : Form
    {
        public WFAgregarCliente()
        {
            InitializeComponent();
        }

        public WFAgregarCliente(Cliente clie)
        {
            InitializeComponent();
            this.cliente = clie;
            Text = "Modificar";
            TBCuitClie.Text = clie.Cuit.ToString();
            TBNombreClie.Text = clie.NombreApellido.ToString();
            TBTelefClie.Text = clie.Telefono.ToString();
            TBDireccClie.Text = clie.Direccion.ToString();
            TBMailClie.Text = clie.Mail.ToString();
            DTPFnac.Value = clie.Fnac;
        }

        private Cliente cliente;

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            ClientesDB clientesDB = new ClientesDB();

            try
            {
                if (cliente == null) { cliente = new Cliente(); }

                cliente.NombreApellido = TBNombreClie.Text.Trim();
                cliente.NombreApellido = cliente.NombreApellido.ToUpper();
                cliente.Cuit = TBCuitClie.Text.Trim();
                cliente.Telefono = TBTelefClie.Text.Trim();
                cliente.Direccion = TBDireccClie.Text.Trim();
                cliente.Direccion = cliente.Direccion.ToUpper();
                cliente.Mail = TBMailClie.Text.Trim();
                cliente.Fnac = DTPFnac.Value;

                if (Text != "Modificar")
                {
                    clientesDB.Agregar(cliente);
                    MessageBox.Show("Agregado con éxito");
                }
                else
                {
                    clientesDB.Modificar(cliente);
                    MessageBox.Show("Modificado con éxito");
                }
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelarCliente_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Perderá todos los datos, está seguro?", "Cerrar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
