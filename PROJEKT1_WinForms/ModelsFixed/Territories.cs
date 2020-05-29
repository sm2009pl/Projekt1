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

    public class Territories : IAddingForm
    {
        public Territories()
        {
            Employees = new HashSet<Employees>();
        }

        [Key]
        [StringLength(20)]
        public string TerritoryID { get; set; }

        [Required]
        [StringLength(50)]
        public string TerritoryDescription { get; set; }

        public int RegionID { get; set; }

        public virtual Region Region { get; set; }
        [Browsable(false)]
        public virtual ICollection<Employees> Employees { get; set; }
        public void AddForm()
        {
            var form = new AddTerritoriesForm();
            form.ShowDialog();
        }
        public void Delete(DataGridView DGV)
        {
            using (var db = new NorthwindContext())
            {
                string delId = DGV.SelectedRows[0].Cells[0].Value.ToString();
                Territories deleteRecord = db.Territories.First(b => b.TerritoryID == delId);
                db.Territories.Remove(deleteRecord);
                db.SaveChanges();
            }
        }
        public void Load(DataGridView DGV)
        {
            using (var db = new NorthwindContext())
            {
                db.Territories.Load();
                DGV.DataSource = db.Territories.Local.ToList();
                DGV.Columns["Region"].Visible = false;
            }
        }
    }
}
