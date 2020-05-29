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

    [Table("Order Details")]
    public class Order_Details : IAddingForm
    {

        [Key]
        [Column(Order = 0)]
        public int OrderID { get; set; }

        [Key]
        [Column(Order = 1)]
        public int ProductID { get; set; }

        [Column(TypeName = "money")]
        public decimal UnitPrice { get; set; }

        public short Quantity { get; set; }

        public float Discount { get; set; }
        [Browsable(false)]
        public virtual Orders Orders { get; set; }
        [Browsable(false)]
        public virtual Products Products { get; set; }
        public void AddForm()
        {
            var form = new AddOrderDetailsForm();
            form.ShowDialog();
        }
        public void Delete(DataGridView DGV)
        {
            using (var db = new NorthwindContext())
            {
                bool success1, success2;
                int delId, delId2;
                success1 = int.TryParse(DGV.SelectedRows[0].Cells[0].Value.ToString(), out delId);
                success2 = int.TryParse(DGV.SelectedRows[0].Cells[1].Value.ToString(), out delId2);
                if (success1 && success2)
                {
                    Order_Details deleteRecord = db.Order_Details.First(b => b.OrderID == delId && b.ProductID == delId2);
                    db.Order_Details.Remove(deleteRecord);
                    db.SaveChanges();
                }
            }
        }
        public void Load(DataGridView DGV)
        {
            using (var db = new NorthwindContext())
            {
                db.Order_Details.Load();
                DGV.DataSource = db.Order_Details.Local.ToList();
            }
        }
    }
}
