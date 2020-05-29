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
    public partial class AddShippersForm : Form
    {
        public AddShippersForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxShipName.Text))
            {
                MessageBox.Show("Insert shipper name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (NorthwindContext db = new NorthwindContext())
                {
                    Shippers cat = new Shippers();
                    cat.CompanyName = textBoxShipName.Text;
                    cat.Phone = textBoxShipPhone.Text;
                    db.Shippers.Add(cat);
                    db.SaveChanges();
                    this.Close();
                }
            }
        }
    }
}
