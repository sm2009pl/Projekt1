namespace PROJEKT1_WinForms
{
    using PROJEKT1_WinForms.FormsFixed;
    using PROJEKT1_WinForms.ModelsFixed;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Configuration;
    using System.Data.Entity;
    using System.Data.Entity.Spatial;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Windows.Forms;

    public class Categories : IAddingForm
    {
        public Categories()
        {
            Products = new HashSet<Products>();
        }

        [Key]
        public int CategoryID { get; set; }

        [Required]
        [StringLength(15)]
        public string CategoryName { get; set; }

        [Column(TypeName = "ntext")]
        public string Description { get; set; }
        [Browsable(false)]
        public virtual ICollection<Products> Products { get; set; }
        public void AddForm()
        {
            var form = new AddCategoriesForm();
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
                    var products = db.Products.Where(b => b.CategoryID == delId);
                    foreach(var item in products)
                    {
                        db.Products.Remove(item);
                    }
                    Categories deleteRecord = db.Categories.First(b => b.CategoryID == delId);
                    db.Categories.Remove(deleteRecord);
                    db.SaveChanges();
                }
            }
        }
        public void Load(DataGridView DGV)
        {
            using (var db = new NorthwindContext())
            {
                db.Categories.Load();
                DGV.DataSource = db.Categories.Local.ToList();
            }
        }
    }
}
