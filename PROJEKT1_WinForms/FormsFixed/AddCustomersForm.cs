using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJEKT1_WinForms.ModelsFixed
{
    public partial class AddCustomersForm : Form
    {
        public AddCustomersForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (NorthwindContext db = new NorthwindContext())
            {
                if (String.IsNullOrEmpty(textBoxCustID.Text) || String.IsNullOrEmpty(textBoxCustName.Text))
                {
                    MessageBox.Show("Insert Customer ID and Customer Name", "ERROR", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (db.Customers.Any(o => o.CustomerID == textBoxCustID.Text))
                {
                    MessageBox.Show("ID is not UNIQUE", "ERROR",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    Customers cat = new Customers();
                    cat.CustomerID = textBoxCustID.Text;
                    cat.CompanyName = textBoxCustName.Text;
                    cat.ContactName = textBoxCustContName.Text;
                    cat.ContactTitle = textBoxCustContTitle.Text;
                    cat.Address = textBoxCustAddress.Text;
                    cat.City = textBoxCustCity.Text;
                    cat.Region = textBoxCustRegion.Text;
                    cat.PostalCode = textBoxCustPostalCode.Text;
                    cat.Country = textBoxCustCountry.Text;
                    cat.Phone = textBoxCustPhone.Text;
                    cat.Fax = textBoxCustFax.Text;
                    db.Customers.Add(cat);
                    db.SaveChanges();
                    this.Close();
                
                }
            }
        }
    }
}
