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

            listProducts.Add(2, "Mother AsRock");
            listPrice.Add(2, 800);

            listProducts.Add(3, "Mother Asus");
            listPrice.Add(3, 1200);

            listProducts.Add(4, "Mother MSI");
            listPrice.Add(4, 1400);

            listProducts.Add(5, "Mother AsRock");
            listPrice.Add(5, 800);

            listProducts.Add(6, "Mother Asus");
            listPrice.Add(6, 1200);
 
            listProducts.Add(7, "Mother Gycabytes");
            listPrice.Add(7, 1100);

            listProducts.Add(8, "RAM 2GB");
            listPrice.Add(8, 700);

            listProducts.Add(9, "RAM 4GB");
            listPrice.Add(9, 1050);

            listProducts.Add(10, "Microprocesador Intel");
            listPrice.Add(10, 2400);

            listProducts.Add(11, "Microprocesador AMD");
            listPrice.Add(11, 1800);

            listProducts.Add(12, "HDD 500GB");
            listPrice.Add(12, 900);

            listProducts.Add(13, "HDD 1TB");
            listPrice.Add(13, 1200);

            listProducts.Add(14, "Gabinete Económico");
            listPrice.Add(14, 700);

            listProducts.Add(15, "Gabinete Pro");
            listPrice.Add(15, 2500);

            listProducts.Add(16, "Fuente");
            listPrice.Add(16, 500);

            listProducts.Add(17, "KIT Mouse + Teclado + Parlantes");
            listPrice.Add(17, 300);

            listProducts.Add(18, "Monitor 19”");
            listPrice.Add(18, 2900);

            listProducts.Add(19, "Monitor 22”");
            listPrice.Add(19, 3500);


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
