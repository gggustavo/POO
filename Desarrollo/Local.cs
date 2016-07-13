using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desarrollo
{
    public class Local : Proyecto
    {
        public override void CalcularCosto()
        {
            base.CostoProyecto = base.Desarrollador.CostoHora * base.CantidadHoras;
        }
        
    }
}
