using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repuesto
{
    public partial class ArticulosForm : Form
    {

        private CasaRepuestos _casaRepuesto;

        public ArticulosForm(CasaRepuestos repuesto)
        {
            InitializeComponent();

            _casaRepuesto = repuesto;

            articuloBindingSource.DataSource = _casaRepuesto.ListarArticulos();
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            var articulo = new Articulo
            {
                NumeroSerie = Convert.ToInt32(nroSerie.Text),
                Descripcion = descripcion.Text,
                PrecioVenta = Convert.ToDouble(precioVenta.Text),
                StockDisponible = Convert.ToInt32(stockDisponible.Text)
            };
            _casaRepuesto.AgregarArticulo(articulo);
            
            articuloBindingSource.DataSource = _casaRepuesto.ListarArticulos().ToList();
            MessageBox.Show("Se agrego correctamente el articulo");
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            if (articuloBindingSource.Current != null)
            {
                var articulo = (Articulo)articuloBindingSource.Current;
                _casaRepuesto.EliminarArticulo(articulo);
                // eliminar nro serie
                //_casaRepuesto.EliminarArticulo(articulo.NumeroSerie);                
                articuloBindingSource.DataSource =
                    _casaRepuesto.ListarArticulos();
                MessageBox.Show("Se elimino correctamente el articulo");               
            }
        }
    }
}
