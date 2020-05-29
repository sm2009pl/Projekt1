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
    public partial class AddOrderDetailsForm : Form
    {
        public AddOrderDetailsForm()
        {
            InitializeComponent();
            using (NorthwindContext db = new NorthwindContext())
            {
                db.Orders.Load();
                var listOfOrderId = db.Orders.Select(r => r.OrderID);
                foreach (var item in listOfOrderId)
                    comboBoxOrderID.Items.Add(item.ToString());

                db.Products.Load();
                var listOfProductId = db.Products.Select(r => r.ProductID);
                foreach (var item in listOfProductId)
                    comboBoxProductID.Items.Add(item.ToString());
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxOrdDetUnitPrice.Text) || String.IsNullOrEmpty(comboBoxOrderID.Text)
                || String.IsNullOrEmpty(comboBoxProductID.Text) || String.IsNullOrEmpty(textBoxOrdDetQuantity.Text)
                || String.IsNullOrEmpty(textBoxOrdDetDiscount.Text))
            {
                MessageBox.Show("Insert all data", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (NorthwindContext db = new NorthwindContext())
                {
                    Order_Details cat = new Order_Details();
                    int x;
                    decimal y;
                    short z;
                    float fl;
                    bool success = Int32.TryParse(comboBoxOrderID.Text, out x);
                    if (success)
                        cat.OrderID = x;
                    success = Int32.TryParse(comboBoxProductID.Text, out x);
                    if (success)
                        cat.ProductID = x;
                    success = decimal.TryParse(textBoxOrdDetUnitPrice.Text, out y);
                    if (success)
                        cat.UnitPrice = y;
                    success = short.TryParse(textBoxOrdDetQuantity.Text, out z);
                    if (success)
                        cat.Quantity = z;
                    success = float.TryParse(textBoxOrdDetDiscount.Text, out fl);
                    if (success)
                        cat.Discount = fl;
                    db.Order_Details.Add(cat);
                    db.SaveChanges();
                    this.Close();
                }
            }
        }
        private void textBoxOrdPrice_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
