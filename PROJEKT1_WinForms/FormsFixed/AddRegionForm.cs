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
    public partial class AddRegionForm : Form
    {
        public AddRegionForm()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxRegDesc.Text))
            {
                MessageBox.Show("Insert product name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (NorthwindContext db = new NorthwindContext())
                {
                    Region cat = new Region();
                    cat.RegionDescription = textBoxRegDesc.Text;
                    db.Region.Add(cat);
                    db.SaveChanges();
                    this.Close();
                }
            }
        }
    }
}
