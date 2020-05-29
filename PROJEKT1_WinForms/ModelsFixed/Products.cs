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

    public class Products : IAddingForm
    {
        public Products()
        {
            Order_Details = new HashSet<Order_Details>();
        }

        [Key]
        public int ProductID { get; set; }

        [Required]
        [StringLength(40)]
        public string ProductName { get; set; }

        public int? SupplierID { get; set; }

        public int? CategoryID { get; set; }

        [StringLength(20)]
        public string QuantityPerUnit { get; set; }

        [Column(TypeName = "money")]
        public decimal? UnitPrice { get; set; }

        public short? UnitsInStock { get; set; }

        public bool Discontinued { get; set; }
        [Browsable(false)]
        public virtual Categories Categories { get; set; }
        [Browsable(false)]
        public virtual ICollection<Order_Details> Order_Details { get; set; }
        [Browsable(false)]
        public virtual Suppliers Suppliers { get; set; }
        public void AddForm()
        {
            var form = new AddProductsForm();
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
                    var orderDetails = db.Order_Details.Where(b => b.ProductID == delId);
                    foreach (var item in orderDetails)
                    {
                        db.Order_Details.Remove(item);
                    }
                    Products deleteRecord = db.Products.First(b => b.ProductID == delId);
                    db.Products.Remove(deleteRecord);
                    db.SaveChanges();
                }
            }
        }
        public void Load(DataGridView DGV)
        {
            using (var db = new NorthwindContext())
            {
                db.Products.Load();
                DGV.DataSource = db.Products.Local.ToList();
            }
        }
    }
}
