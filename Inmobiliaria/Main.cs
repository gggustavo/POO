using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inmobiliaria
{
    public partial class Main : Form
    {
        private Inmobiliaria _inmobiliaria = new Inmobiliaria();

        public Main()
        {
            InitializeComponent();
            LoadData();
        }

        private void localidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var localidades = new Localidades(_inmobiliaria);
            localidades.ShowDialog();
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var departamentos = new Departamentos(_inmobiliaria);
            departamentos.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadData() 
        {
            var localidad = new Localidad
            {
                CP = 2000,
                Nombre = "Rosario"
            };

            _inmobiliaria.AgregarLocalidad(localidad);

            localidad = new Localidad
            {
                CP = 2126,
                Nombre = "Pueblo Esther"
            };
            
            _inmobiliaria.AgregarLocalidad(localidad);


            localidad = new Localidad
            {
                CP = 2216,
                Nombre = "Serodino"
            };

            _inmobiliaria.AgregarLocalidad(localidad);


            var departamento = new Departamento
            {
                Cochera = true,
                Domicilio = "Paraguay 1456",
                Habitaciones = 2,
                Numero = 222,
                Piso = 1,
                Superficie = 50,                
            };

            _inmobiliaria.AgregarDepartamento(departamento);

            departamento = new Departamento
            {
                Cochera = false,
                Domicilio = "Paraguay 2800",
                Habitaciones = 2,
                Numero = 222,
                Piso = 1,
                Superficie = 96,
            };

            _inmobiliaria.AgregarDepartamento(departamento);


            departamento = new Departamento
            {
                Cochera = false,
                Domicilio = "Paraguay 800",
                Habitaciones = 2,
                Numero = 222,
                Piso = 1,
                Superficie = 96,
            };

            _inmobiliaria.AgregarDepartamento(departamento);

        }
    }
}
