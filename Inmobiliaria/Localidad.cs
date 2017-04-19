using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inmobiliaria
{
    public class Localidad
    {
        private int _cp;

        public int CP
        {
            get
            {
                return _cp;
            }
            set
            {
                _cp = value;
            }
        }

        private string _nombre;

        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
            }
        }
    }
}
