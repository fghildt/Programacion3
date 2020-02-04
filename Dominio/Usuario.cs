using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Usuario : Ente
    {
        public int IdUser { get; set; }
        public String User { get; set; }
        public String Pswd { get; set; }
    }
}
