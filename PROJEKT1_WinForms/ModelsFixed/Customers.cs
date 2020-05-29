namespace PROJEKT1_WinForms
{
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

    public class Customers : IAddingForm
    {
        public Customers()
        {
            Orders = new HashSet<Orders>();
            CustomerDemographics = new HashSet<CustomerDemographics>();
        }

        [Key]
        [StringLength(5)]
        public string CustomerID { get; set; }

        [Required]
        [StringLength(50)]
        public string CompanyName { get; set; }

        [StringLength(40)]
        public string ContactName { get; set; }

        [StringLength(30)]
        public string ContactTitle { get; set; }

        [StringLength(60)]
        public string Address { get; set; }

        [StringLength(15)]
        public string City { get; set; }

        [StringLength(15)]
        public string Region { get; set; }

        [StringLength(10)]
        public string PostalCode { get; set; }

        [StringLength(15)]
        public string Country { get; set; }

        [StringLength(24)]
        public string Phone { get; set; }

        [StringLength(24)]
        public string Fax { get; set; }
        [Browsable(false)]
        public virtual ICollection<Orders> Orders { get; set; }
        [Browsable(false)]
        public virtual ICollection<CustomerDemographics> CustomerDemographics { get; set; }

        public void AddForm()
        {
            var form = new AddCustomersForm();
            form.ShowDialog();
        }
        public void Delete(DataGridView DGV)
        {
            using (var db = new NorthwindContext())
            {
                string delId = DGV.SelectedRows[0].Cells[0].Value.ToString();
                var orders = db.Orders.Where(b => b.CustomerID == delId);
                foreach (var item in orders)
                {
                    db.Orders.Remove(item);
                }
                Customers deleteRecord = db.Customers.First(b => b.CustomerID == delId);
                db.Customers.Remove(deleteRecord);
                db.SaveChanges();
            }
        }
        public void Load(DataGridView DGV)
        {
            using (var db = new NorthwindContext())
            {
                db.Customers.Load();
                DGV.DataSource = db.Customers.Local.ToList();
            }
        }
    }
}
