using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Compra : TipoFC
    {
        public int IdCompra { get; set; }
        public int PrefijoFc { get; set; }
        public int Factura { get; set; }
        public DateTime Fecha { get; set; }
        public int IdProveedor { get; set; }
    }
}
