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
    public partial class Products : Form
    {
        private Dictionary<int, string> listProducts = new Dictionary<int, string>();
        private Dictionary<int, int> listPrice = new Dictionary<int, int>();

        public Products()
        {
            InitializeComponent();

            listProducts.Add(1, "Mother MSI");
            listPrice.Add(1, 1400);

            listProducts.Add(2, "Mother AsRock ");
            listPrice.Add(2, 800);

            product.DataSource = listProducts.ToList();
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            if (product.SelectedRows.Count == 0) return;

            var key = ((KeyValuePair<int, string>)(product.SelectedRows[0].DataBoundItem)).Key;
            var price = listPrice.FirstOrDefault(_ => _.Key == key);

            MessageBox.Show(string.Format("El precio del producto es: ${0}", price.Value), 
                            "Precio", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
