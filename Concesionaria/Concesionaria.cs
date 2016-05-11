using System.Collections.Generic;

namespace Concesionaria
{
    public class Concesionaria
    {

        private readonly List<Auto> _autos;

        public Concesionaria()
        {
            _autos = new List<Auto>();
        }

        public void AgregarAuto(Auto auto)
        {
            _autos.Add(auto);
        }

        public void ElimiarAuto(Auto auto)
        {
            _autos.Remove(auto);
        }

        public List<Auto> ListarAutos()
        {
            return _autos;
        }


    }
}
