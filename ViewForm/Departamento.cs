using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ViewForm
{
    public class Departamento
    {
        private string _domicilio;

        public string Domicilio
        {
            get
            {
                return _domicilio;
            }
            set
            {
                _domicilio = value;
            }
        }

        private int _piso;

        public int Piso
        {
            get
            {
                return _piso;
            }
            set
            {
                _piso = value;
            }
        }

        private int _numero;

        public int Numero
        {
            get
            {
                return _numero;
            }
            set
            {
                _numero = value;
            }
        }

        private int _habitaciones;

        public int Habitaciones
        {
            get
            {
                return _habitaciones;
            }
            set
            {
                _habitaciones = value;
            }
        }

        private int _superficie;

        public int Superficie
        {
            get
            {
                return _superficie;
            }
            set
            {
                _superficie = value;
            }
        }

        public bool _cochera;

        public bool Cochera
        {
            get
            {
                return _cochera;
            }
            set
            {
                _cochera = value;
            }
        }

        public void ValorAlquiler(int valorM2, int valorCochera)
        {
            throw new System.NotImplementedException();
        }
    }
}
