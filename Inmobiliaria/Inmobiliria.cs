using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inmobiliaria
{
    public class Inmobiliaria
    {
        private List<Departamento> _departamentos; 
        private List<Localidad> _localidades;

        public Inmobiliaria()
        {
            _departamentos = new List<Departamento>();
            _localidades = new List<Localidad>();
        }

        private int _valorM2;

        public int ValorM2
        {
            get
            {
                return _valorM2;
            }
            set
            {
                _valorM2 = value;
            }
        }

        private int _valorCochera;

        public int ValorCochera
        {
            get
            {
                return _valorCochera;
            }
            set
            {
                _valorCochera = value;
            }
        }        

        public void AgregarDepartamento(Departamento departamento)
        {
            _departamentos.Add(departamento);
        }

        public void ModificarDepartamento(Departamento departamento)
        {
            throw new NotImplementedException();
        }

        public void EliminarDepartamento(Departamento departamento)
        {
            _departamentos.Remove(departamento);
        }

        public List<Departamento> ListarDepartamentos()
        {
            return _departamentos;
        }

        public void AgregarLocalidad(Localidad localidad)
        {
            _localidades.Add(localidad);
        }

        public void EliminarLocalidad(Localidad localidad)
        {
            _localidades.Remove(localidad);
        }

        public void ModificarLocalidad(Localidad localidad)
        {
            throw new System.NotImplementedException();
        }

        public List<Localidad> ListarLocalidades()
        {
            return _localidades;
        }
    }
}
