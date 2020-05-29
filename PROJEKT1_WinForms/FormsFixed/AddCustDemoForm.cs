using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJEKT1_WinForms
{
    public partial class AddCustDemoForm : Form
    {
        public AddCustDemoForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (NorthwindContext db = new NorthwindContext())
            {
                if (String.IsNullOrEmpty(textBoxCustTypeID.Text))
                {
                    MessageBox.Show("Insert Customer type ID", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    CustomerDemographics cat = new CustomerDemographics();
                    cat.CustomerTypeID = textBoxCustTypeID.Text;
                    cat.CustomerDesc = textBoxCustTypeDesc.Text;
                    db.CustomerDemographics.Add(cat);
                    db.SaveChanges();
                    this.Close();
                }
            }

        }
    }
}
