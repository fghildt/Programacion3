using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Venta : TipoFC
    {
        public int IdVenta { get; set; }
        public int PrefijoFc { get; set; }
        public int Factura { get; set; }
        public DateTime Fecha { get; set; }
        public int IdCliente { get; set; }
    }
}
