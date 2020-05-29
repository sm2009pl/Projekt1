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

    public class CustomerDemographics : IAddingForm
    {
        public CustomerDemographics()
        {
            Customers = new HashSet<Customers>();
        }

        [Key]
        [StringLength(10)]
        public string CustomerTypeID { get; set; }

        [Column(TypeName = "ntext")]
        public string CustomerDesc { get; set; }
        [Browsable(false)]
        public virtual ICollection<Customers> Customers { get; set; }
        public void AddForm()
        {
            var form = new AddCustDemoForm();
            form.ShowDialog();
        }
        public void Delete(DataGridView DGV)
        {
            using (var db = new NorthwindContext())
            {
                string delId = DGV.SelectedRows[0].Cells[0].Value.ToString();
                CustomerDemographics deleteRecord = db.CustomerDemographics.First(b => b.CustomerTypeID == delId);
                db.CustomerDemographics.Remove(deleteRecord);
                db.SaveChanges();
            }
        }
        public void Load(DataGridView DGV)
        {
            using (var db = new NorthwindContext())
            {
                db.CustomerDemographics.Load();
                DGV.DataSource = db.CustomerDemographics.Local.ToList();
            }
        }
    }
}
