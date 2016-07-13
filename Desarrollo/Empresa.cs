using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desarrollo
{
    public class Empresa
    {
        private ICollection<Desarrollador> _desarrolladores;
        private ICollection<Proyecto> _proyectos;

        public Empresa()
        {
            _desarrolladores = new List<Desarrollador>();
            _proyectos = new List<Proyecto>();
        }

        public void AgregarDesarrollador(Desarrollador desarrollador)
        {
            _desarrolladores.Add(desarrollador);
        }

        public void EliminarDesarrollador(Desarrollador desarrollador)
        {
            _desarrolladores.Remove(desarrollador);
        }

        public void ModificarDesarrollador(Desarrollador desarrollador)
        {            
            _desarrolladores.Where(_ => _.Documento == desarrollador.Documento)
                    .FirstOrDefault().CostoHora = desarrollador.CostoHora;

            _desarrolladores.Where(_ => _.Documento == desarrollador.Documento)
                    .FirstOrDefault().Nombre = desarrollador.Nombre;

            _desarrolladores.Where(_ => _.Documento == desarrollador.Documento)
                    .FirstOrDefault().Email = desarrollador.Email;
            
        }

        public ICollection<Desarrollador> ObtenerDesarrolladores()
        {
            return _desarrolladores;
        }

        public void AgregarProyecto(Proyecto proyecto)
        {
            _proyectos.Add(proyecto);
        }

        public void EliminarProyecto(Proyecto proyecto)
        {
            _proyectos.Remove(proyecto);
        }

        public void ModificarProyecto(Proyecto proyecto)
        {
            _proyectos.Where(_ => _.Nombre == proyecto.Nombre)
                    .FirstOrDefault().CantidadHoras = proyecto.CantidadHoras;
        }

        public ICollection<Proyecto> ObtenerProyectos()
        {
            return _proyectos; 
        }

    }
}
