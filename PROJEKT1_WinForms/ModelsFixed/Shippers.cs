namespace PROJEKT1_WinForms
{
    using PROJEKT1_WinForms.FormsFixed;
    using PROJEKT1_WinForms.ModelsFixed;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Data.Entity.Spatial;
    using System.Linq;
    using System.Windows.Forms;

    public class Shippers : IAddingForm
    {
        public Shippers()
        {
            Orders = new HashSet<Orders>();
        }

        [Key]
        public int ShipperID { get; set; }

        [Required]
        [StringLength(40)]
        public string CompanyName { get; set; }

        [StringLength(24)]
        public string Phone { get; set; }
        [Browsable(false)]
        public virtual ICollection<Orders> Orders { get; set; }
        public void AddForm()
        {
            var form = new AddShippersForm();
            form.ShowDialog();
        }
        public void Delete(DataGridView DGV)
        {
            using (var db = new NorthwindContext())
            {
                bool success;
                int delId;
                success = int.TryParse(DGV.SelectedRows[0].Cells[0].Value.ToString(), out delId);
                if (success)
                {
                    var orders = db.Orders.Where(b => b.ShipVia== delId);
                    foreach (var item in orders)
                    {
                        db.Orders.Remove(item);
                    }
                    Shippers deleteRecord = db.Shippers.First(b => b.ShipperID == delId);
                    db.Shippers.Remove(deleteRecord);
                    db.SaveChanges();
                }
            }
        }
        public void Load(DataGridView DGV)
        {
            using (var db = new NorthwindContext())
            {
                db.Shippers.Load();
                DGV.DataSource = db.Shippers.Local.ToList();
            }
        }
    }
}
