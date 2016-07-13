using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desarrollo
{
    public abstract class Proyecto
    {
        public string Nombre { get; set; }
        public int CantidadHoras { get; set; }
        public Desarrollador Desarrollador { get; set; }
        public double CostoProyecto { get; set; }

        public string Tipo {
            get
            {
                return GetType().Name;
            }            
        }

        public abstract void CalcularCosto();
    }
}
