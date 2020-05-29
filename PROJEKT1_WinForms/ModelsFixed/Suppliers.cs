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

    public class Suppliers : IAddingForm
    {
        public Suppliers()
        {
            Products = new HashSet<Products>();
        }

        [Key]
        public int SupplierID { get; set; }

        [Required]
        [StringLength(40)]
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

        [Column(TypeName = "ntext")]
        public string HomePage { get; set; }
        [Browsable(false)]
        public virtual ICollection<Products> Products { get; set; }
        public void AddForm()
        {
            var form = new AddSuppliersForm();
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
                    var products = db.Products.Where(b => b.SupplierID == delId);
                    foreach (var item in products)
                    {
                        db.Products.Remove(item);
                    }
                    Suppliers deleteRecord = db.Suppliers.First(b => b.SupplierID == delId);
                    db.Suppliers.Remove(deleteRecord);
                    db.SaveChanges();
                }
            }
        }
        public void Load(DataGridView DGV)
        {
            using (var db = new NorthwindContext())
            {
                db.Suppliers.Load();
                DGV.DataSource = db.Suppliers.Local.ToList();
            }
        }
    }
}
