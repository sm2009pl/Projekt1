using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJEKT1_WinForms.FormsFixed
{
    public partial class AddProductsForm : Form
    {
        public AddProductsForm()
        {
            InitializeComponent();
            using (NorthwindContext db = new NorthwindContext())
            {
                db.Suppliers.Load();
                var listOfSupplierId = db.Suppliers.Select(r => r.SupplierID);
                foreach (var item in listOfSupplierId)
                    comboBoxSupplierID.Items.Add(item.ToString());

                db.Categories.Load();
                var listOfCategoryId = db.Categories.Select(r => r.CategoryID);
                foreach (var item in listOfCategoryId)
                    comboBoxCategoryID.Items.Add(item.ToString());

            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxProdName.Text))
            {
                MessageBox.Show("Insert product name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (NorthwindContext db = new NorthwindContext())
                {
                    Products cat = new Products();
                    int x;
                    decimal y;
                    short z;
                    bool success;
                    cat.ProductName = textBoxProdName.Text;
                    success = Int32.TryParse(comboBoxSupplierID.Text, out x);
                    if (success)
                        cat.SupplierID = x;
                    success = Int32.TryParse(comboBoxCategoryID.Text, out x);
                    if (success)
                        cat.CategoryID = x;
                    cat.QuantityPerUnit = textBoxProdQuantityPerUnit.Text;
                    success = decimal.TryParse(textBoxProdUnitPrice.Text, out y);
                    if (success)
                        cat.UnitPrice = y;
                    success = short.TryParse(textBoxProdUnitsInStock.Text, out z);
                    if (success)
                        cat.UnitsInStock = z;
                    if (checkBoxProdDiscontinued.Checked == true)
                        cat.Discontinued = true;
                    else
                        cat.Discontinued = false;
                    db.Products.Add(cat);
                    db.SaveChanges();
                    this.Close();
                }
            }
        }
        private void textBoxProdUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void textBoxProdUnitPriceForInt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

    }
}
