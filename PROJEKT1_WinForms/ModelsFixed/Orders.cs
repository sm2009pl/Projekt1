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

    public class Orders : IAddingForm
    {
        public Orders()
        {
            Order_Details = new HashSet<Order_Details>();
        }

        [Key]
        public int OrderID { get; set; }

        [StringLength(5)]
        public string CustomerID { get; set; }

        public int? EmployeeID { get; set; }

        public DateTime? OrderDate { get; set; }

        public DateTime? RequiredDate { get; set; }

        public DateTime? ShippedDate { get; set; }

        public int? ShipVia { get; set; }

        [Column(TypeName = "money")]
        public decimal? Freight { get; set; }

        [StringLength(40)]
        public string ShipName { get; set; }

        [StringLength(60)]
        public string ShipAddress { get; set; }

        [StringLength(15)]
        public string ShipCity { get; set; }

        [StringLength(15)]
        public string ShipRegion { get; set; }

        [StringLength(10)]
        public string ShipPostalCode { get; set; }

        [StringLength(15)]
        public string ShipCountry { get; set; }
        [Browsable(false)]
        public virtual Customers Customers { get; set; }
        [Browsable(false)]
        public virtual Employees Employees { get; set; }
        [Browsable(false)]
        public virtual ICollection<Order_Details> Order_Details { get; set; }
        [Browsable(false)]
        public virtual Shippers Shippers { get; set; }
        public void AddForm()
        {
            var form = new AddOrdersForm();
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
                    var orderDetails = db.Order_Details.Where(b => b.OrderID == delId);
                    foreach (var item in orderDetails)
                    {
                        db.Order_Details.Remove(item);
                    }
                    Orders deleteRecord = db.Orders.First(b => b.OrderID == delId);
                    db.Orders.Remove(deleteRecord);
                    db.SaveChanges();
                }
            }
        }
        public void Load(DataGridView DGV)
        {
            using (var db = new NorthwindContext())
            {
                db.Orders.Load();
                DGV.DataSource = db.Orders.Local.ToList();
            }
        }
    }
}
