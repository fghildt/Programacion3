using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class TipoFC
    {
        public int idTipoFC { get; set; }
        public String TipoFc { get; set; }

        public override string ToString()
        {
            return TipoFc;
        }
    }
}
