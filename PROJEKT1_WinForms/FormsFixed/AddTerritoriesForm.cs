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
    public partial class AddTerritoriesForm : Form
    {
        public AddTerritoriesForm()
        {
            InitializeComponent();
            using (NorthwindContext db = new NorthwindContext())
            {
                db.Region.Load();
                var listOfRegionId = db.Region.Select(r => r.RegionID);
                foreach (var item in listOfRegionId)
                    comboBoxRegionID.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (NorthwindContext db = new NorthwindContext())
            {
                if (String.IsNullOrEmpty(textBoxTerritoryID.Text) || String.IsNullOrEmpty(textBoxTerrDesc.Text))
            {
                    MessageBox.Show("Insert product name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (db.Territories.Any(o => o.TerritoryID == textBoxTerritoryID.Text))
                {
                    MessageBox.Show("ID is not UNIQUE", "ERROR",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                        Territories cat = new Territories();
                        int x;
                        cat.TerritoryID = textBoxTerritoryID.Text;
                        cat.TerritoryDescription = textBoxTerrDesc.Text;
                        bool success = int.TryParse(comboBoxRegionID.Text, out x);
                        if (success)
                            cat.RegionID = x;
                        db.Territories.Add(cat);
                        db.SaveChanges();
                        this.Close();
                }
            }
        }
    }
}
