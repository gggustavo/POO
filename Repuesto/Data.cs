using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repuesto
{
    public class Data
    {        
        public static void LoadData(CasaRepuestos casaRepuesto)
        {
            casaRepuesto.AgregarArticulo(new Articulo { Descripcion = "descripcion", NumeroSerie = 1, PrecioVenta = 200, StockDisponible = 10 });
            casaRepuesto.AgregarArticulo(new Articulo { Descripcion = "descripcion2", NumeroSerie = 2, PrecioVenta = 200, StockDisponible = 10 });
            casaRepuesto.AgregarArticulo(new Articulo { Descripcion = "descripcion3", NumeroSerie = 3, PrecioVenta = 200, StockDisponible = 10 });
            casaRepuesto.AgregarArticulo(new Articulo { Descripcion = "descripcion4", NumeroSerie = 4, PrecioVenta = 200, StockDisponible = 10 });
            casaRepuesto.AgregarArticulo(new Articulo { Descripcion = "descripcion5", NumeroSerie = 5, PrecioVenta = 200, StockDisponible = 10 });
            casaRepuesto.AgregarArticulo(new Articulo { Descripcion = "descripcion6", NumeroSerie = 6, PrecioVenta = 200, StockDisponible = 10 });
            casaRepuesto.AgregarArticulo(new Articulo { Descripcion = "descripcion7", NumeroSerie = 7, PrecioVenta = 200, StockDisponible = 10 });
            casaRepuesto.AgregarArticulo(new Articulo { Descripcion = "descripcion8", NumeroSerie = 8, PrecioVenta = 200, StockDisponible = 10 });
        }
    }
}
