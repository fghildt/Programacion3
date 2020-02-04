using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class DetalleCompras
    {
        public int IdDetalle { get; set; }
        public int IdCompra { get; set; }
        public string Nombre { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public Double Precio { get; set; }
    }
}
