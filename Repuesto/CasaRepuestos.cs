using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repuesto
{
    public class CasaRepuestos
    {
        public List<Articulo> Articulos { get; set; }

        public CasaRepuestos()
        {
            Articulos = new List<Articulo>();
        }

        public void AgregarArticulo(Articulo articulo) 
        {
            Articulos.Add(articulo);
        }

        public void EliminarArticulo(int nroSerie)
        {
            var articulo = Articulos.FirstOrDefault(_ => _.NumeroSerie == nroSerie);            
            Articulos.Remove(articulo);
        }

        public void EliminarArticulo(Articulo articulo)
        {
            Articulos.Remove(articulo);
        }

        public List<Articulo> ListarArticulos()
        {
            return Articulos.ToList();
        }

    }
}
