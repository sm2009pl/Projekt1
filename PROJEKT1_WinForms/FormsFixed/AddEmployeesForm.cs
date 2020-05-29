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
    public partial class AddEmployeesForm : Form
    {
        public AddEmployeesForm()
        {
            InitializeComponent();
            using (NorthwindContext db = new NorthwindContext())
            {
                db.Employees.Load();
                var listOfEmployeesId = db.Employees.Select(r => r.EmployeeID);
                foreach(var item in listOfEmployeesId)
                    comboBoxReportsTo.Items.Add(item.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxEmplFirstName.Text == "" || textBoxEmplLastName.Text == "")
            {
                MessageBox.Show("Insert First Name and Last Name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (NorthwindContext db = new NorthwindContext())
                {
                    Employees cat = new Employees();
                    int x;
                    bool success;
                    cat.LastName = textBoxEmplLastName.Text;
                    cat.FirstName = textBoxEmplFirstName.Text;
                    cat.Title = textBoxEmplTitle.Text;
                    cat.TitleOfCourtesy = textBoxEmplTitleOfCourtesy.Text;
                    cat.BirthDate = dateTimePickerBirth.Value;
                    cat.HireDate = dateTimePickerHire.Value;
                    cat.Address = textBoxEmplAddress.Text;
                    cat.City = textBoxEmplCity.Text;
                    cat.Region = textBoxEmplRegion.Text;
                    cat.PostalCode = textBoxEmplPostalCode.Text;
                    cat.Country = textBoxEmplCountry.Text;
                    cat.HomePhone = textBoxEmplPhone.Text;
                    cat.Extension = textBoxEmplExtension.Text;
                    cat.Notes = textBoxEmplNotes.Text;
                    success = Int32.TryParse(comboBoxReportsTo.Text, out x);
                    if (success)
                        cat.ReportsTo = x;
                    db.Employees.Add(cat);
                    db.SaveChanges();
                    this.Close();
                }
            }

        }
    }
}
