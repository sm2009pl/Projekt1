using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJEKT1_WinForms.FormsFixed
{
    public partial class AddSuppliersForm : Form
    {
        public AddSuppliersForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxSuppName.Text))
            {
                MessageBox.Show("Insert supplier name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (NorthwindContext db = new NorthwindContext())
                {
                    Suppliers cat = new Suppliers();
                    cat.CompanyName = textBoxSuppName.Text;
                    cat.ContactName = textBoxSuppContactName.Text;
                    cat.ContactTitle = textBoxSuppContactTitle.Text;
                    cat.Address = textBoxSuppAddress.Text;
                    cat.City = textBoxSuppCity.Text;
                    cat.Region = textBoxSuppRegion.Text;
                    cat.PostalCode = textBoxSuppPostalCode.Text;
                    cat.Country = textBoxSuppCountry.Text;
                    cat.Phone = textBoxSuppPhone.Text;
                    cat.Fax = textBoxSuppFax.Text;
                    cat.HomePage = textBoxSuppHomePage.Text;
                    db.Suppliers.Add(cat);
                    db.SaveChanges();
                    this.Close();
                }
            }
        }
    }
}
