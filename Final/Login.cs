using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class Login : Form
    {
        private const string valueUser = "POO";
        private const string valuePassword = "POO";

        public Login()
        {
            InitializeComponent();
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            if (usuario.Text == valueUser && password.Text == valuePassword)
            {
                var form = new Software();
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
            else 
            {
                MessageBox.Show("Ingres un usario y/o contraseña válida", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
