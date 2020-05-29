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

    [Table("Region")]
    public class Region : IAddingForm
    {

        public Region()
        {
            Territories = new HashSet<Territories>();
        }

        public int RegionID { get; set; }

        [Required]
        [StringLength(50)]
        public string RegionDescription { get; set; }
        [Browsable(false)]
        public virtual ICollection<Territories> Territories { get; set; }
        public void AddForm()
        {
            var form = new AddRegionForm();
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
                    var territories = db.Territories.Where(b => b.RegionID == delId);
                    foreach (var item in territories)
                    {
                        db.Territories.Remove(item);
                    }
                    Region deleteRecord = db.Region.First(b => b.RegionID == delId);
                    db.Region.Remove(deleteRecord);
                    db.SaveChanges();
                }
            }
        }
        public void Load(DataGridView DGV)
        {
            using (var db = new NorthwindContext())
            {
                db.Region.Load();
                DGV.DataSource = db.Region.Local.ToList();
            }
        }
    }
}
