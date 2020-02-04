using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Producto
    {
        public Producto () {
            Marca = new Marca();
            Tipo = new Tipo();
        }
        public int IdProducto { get; set; }
        public String Nombre { get; set; }
        public Marca Marca { get; set; }
        public Tipo Tipo { get; set; }
        public int Stock { get; set; }
        public int StockMin { get; set; }
        public Double PrecioCompra { get; set; }
        public Double PorcentajeGanancia { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
