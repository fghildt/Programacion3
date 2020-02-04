using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public abstract class Ente
    {
        public String Cuit { get; set; }
        public String Direccion { get; set; }
        public String Mail { get; set; }
        public String NombreApellido { get; set; }
        public String Telefono { get; set; }
        public DateTime Fnac { get; set; }
    }
}
