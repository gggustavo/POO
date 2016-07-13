using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desarrollo
{
    public class Desarrollador
    {
        public string Documento { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public int CostoHora { get; set; }

        public override string ToString()
        {
            return Nombre;
        }

    }
}
