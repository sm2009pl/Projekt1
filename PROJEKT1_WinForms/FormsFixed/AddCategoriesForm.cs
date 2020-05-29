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
    public partial class AddCategoriesForm : Form
    {
        public AddCategoriesForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (NorthwindContext db = new NorthwindContext())
            {
                if(String.IsNullOrEmpty(textBoxCatName.Text))
                {
                    MessageBox.Show("Insert Category Name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Categories cat = new Categories();
                    cat.CategoryName = textBoxCatName.Text;
                    cat.Description = textBoxCatDesc.Text;
                    db.Categories.Add(cat);
                    db.SaveChanges();
                    this.Close();
                }
            }
        }
    }
}
