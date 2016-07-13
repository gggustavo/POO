using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desarrollo
{
    public partial class Desarrolladores : Form
    {
        private Empresa _empresa;

        public Desarrolladores(Empresa empresa)
        {
            InitializeComponent();

            _empresa = empresa;
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CargarDesarrolladores();
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(documento.Text)) throw new Exception("Documento vacio");
                if (string.IsNullOrEmpty(nombre.Text)) throw new Exception("Nombre vacio");
                if (string.IsNullOrEmpty(email.Text)) throw new Exception("Email vacio");
                if (string.IsNullOrEmpty(costoxhora.Text)) throw new Exception("Costo vacio");

                var desarrollador = new Desarrollador
                {
                    Documento =  documento.Text,
                    Nombre = nombre.Text,
                    Email = email.Text,
                    CostoHora = Convert.ToInt32(costoxhora.Text)
                };

                _empresa.AgregarDesarrollador(desarrollador);
                CargarDesarrolladores();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CargarDesarrolladores()
        {
            desarrolladorBindingSource.DataSource = null;
            desarrolladorBindingSource.DataSource = _empresa.ObtenerDesarrolladores();
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (desarrolladorBindingSource.Current == null)  throw new Exception("Debe seleccionar un desarrollador");

                var desarrollador = (Desarrollador)desarrolladorBindingSource.Current;

                _empresa.EliminarDesarrollador(desarrollador);

                CargarDesarrolladores();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }          

        }

        private void modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (desarrolladorBindingSource.Current == null) throw new Exception("Debe seleccionar un desarrollador");

                var desarrollador = (Desarrollador)desarrolladorBindingSource.Current;

                documento.Text = desarrollador.Documento;
                documento.Enabled = false;

                nombre.Text = desarrollador.Nombre;                
                email.Text = desarrollador.Email;
                costoxhora.Text = desarrollador.CostoHora.ToString();

                EstadoModificar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EstadoModificar()
        {
            agregar.Enabled = false;
            eliminar.Enabled = false;
            modificar.Enabled = false;
            confirmar.Enabled = true;
        }

        private void confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(nombre.Text)) throw new Exception("Nombre vacio");
                if (string.IsNullOrEmpty(email.Text)) throw new Exception("Email vacio");
                if (string.IsNullOrEmpty(costoxhora.Text)) throw new Exception("Costo vacio");

                var desarrollador = (Desarrollador)desarrolladorBindingSource.Current;

                desarrollador.Nombre = nombre.Text;
                desarrollador.CostoHora = Convert.ToInt32(costoxhora.Text);

                _empresa.ModificarDesarrollador(desarrollador);

                CargarDesarrolladores();

                EstadoConfirmar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EstadoConfirmar()
        {
            documento.Enabled = true;
            agregar.Enabled = true;
            eliminar.Enabled = true;
            modificar.Enabled = true;
            confirmar.Enabled = false;
        }
    }
}
