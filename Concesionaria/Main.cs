using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Concesionaria
{
    public partial class Main : Form
    {

        private readonly Concesionaria _concesionaria;

        public Main()
        {
            InitializeComponent();

            _concesionaria = new Concesionaria();
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(marca.Text))
            {
                MessageBox.Show(@"Debe ingresar la marca");
                return;
            }
            if (string.IsNullOrWhiteSpace(modelo.Text))
            {
                MessageBox.Show(@"Debe ingresar un modelo");
                return;
            }
            if (string.IsNullOrWhiteSpace(patente.Text))
            {
                MessageBox.Show(@"Debe ingresar una patente");
                return;
            }
            int _capacidadTanque;
            if (!int.TryParse(capacidadTanque.Text, out _capacidadTanque))
            {
                MessageBox.Show(@"Debe ingresar una capacidad");
                return;
            }

            int _rendimiento;
            if (!int.TryParse(rendimiento.Text, out _rendimiento))
            {
                MessageBox.Show(@"Debe ingresar un rendimiento");
                return;
            }

            int _combustible;
            if (!int.TryParse(combustibleActual.Text, out _combustible))
            {
                MessageBox.Show(@"Debe ingresar un combustible Actual");
                return;
            }

            var auto = new Auto()
            {
                Marca = marca.Text,
                Modelo = modelo.Text,
                Patente = patente.Text,
                CapacidadTanque = _capacidadTanque,
                RendimientoLitro = _rendimiento,
                CantCombActual = _combustible
            };

            _concesionaria.AgregarAuto(auto);

            CargarAutos();

        }

        private void CargarAutos()
        {
            autoBindingSource.DataSource = null;
            autoBindingSource.DataSource = _concesionaria.ListarAutos();
        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            int value;
            if (!int.TryParse(ingresoValor.Text, out value))
            {
                MessageBox.Show(@"Debe ingresar un valor");
                return;
            }

            if (rbdescontar.Checked)
            {
                value = value *-1;
            }

            foreach (var autos in _concesionaria.ListarAutos())
            {
                autos.ActualizarNivelCombustible(value);
            }

            CargarAutos();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            CargarDatosPrueba();
            CargarAutos();
        }

        private void CargarDatosPrueba()
        {
            var auto = new Auto()
            {
                Marca = "VW",
                Modelo = "Gol Trend",
                Patente = "LLT-851",
                CapacidadTanque = 50,
                RendimientoLitro = 12,
                CantCombActual = 50
            };
            _concesionaria.AgregarAuto(auto);
        }
    }
}
