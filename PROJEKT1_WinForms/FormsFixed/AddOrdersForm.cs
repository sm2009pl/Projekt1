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
    public partial class AddOrdersForm : Form
    {
        public AddOrdersForm()
        {
            InitializeComponent();
            using (NorthwindContext db = new NorthwindContext())
            {
                db.Customers.Load();
                var listOfCustomerId = db.Customers.Select(r => r.CustomerID);
                foreach (var item in listOfCustomerId)
                    comboBoxCustomerID.Items.Add(item);

                db.Employees.Load();
                var listOfEmployeeId = db.Employees.Select(r => r.EmployeeID);
                foreach (var item in listOfEmployeeId)
                    comboBoxEmployeeID.Items.Add(item.ToString());

                db.Shippers.Load();
                var listOfShipperId = db.Shippers.Select(r => r.ShipperID);
                foreach (var item in listOfShipperId)
                    comboBoxShipperID.Items.Add(item.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (NorthwindContext db = new NorthwindContext())
            {
                Orders cat = new Orders();
                int x;
                decimal y;
                bool success;
                if (String.IsNullOrEmpty(comboBoxCustomerID.Text))
                    cat.CustomerID = null;
                else
                    cat.CustomerID = comboBoxCustomerID.Text;
                success = Int32.TryParse(comboBoxEmployeeID.Text, out x);
                if (success)
                    cat.EmployeeID = x;
                cat.OrderDate = dateTimePickerOrder.Value;
                cat.RequiredDate = dateTimePickerRequired.Value;
                cat.ShippedDate = dateTimePickerRequired.Value;
                success = decimal.TryParse(textBoxOrdFreight.Text, out y);
                if (success)
                    cat.Freight = y;
                success = Int32.TryParse(comboBoxShipperID.Text, out x);
                if (success)
                    cat.ShipVia = x;
                cat.ShipName = textBoxOrdShipTo.Text;
                cat.ShipAddress = textBoxOrdShipAddress.Text;
                cat.ShipCity = textBoxOrdShipCity.Text;
                cat.ShipRegion = textBoxOrdShipRegion.Text;
                cat.ShipPostalCode = textBoxOrdShipPostalCode.Text;
                cat.ShipCountry = textBoxOrdShipCountry.Text;
                db.Orders.Add(cat);
                db.SaveChanges();
                this.Close();
            }
        }
        private void textBoxOrderPrice_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
