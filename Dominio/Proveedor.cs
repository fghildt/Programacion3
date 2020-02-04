using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Proveedor : Ente
    {
        public String Cond_pago { get; set; }
        public int Id { get; set; }

        public override string ToString()
        {
            return Cuit.ToString() + " - " + NombreApellido;
        }
    }
}
