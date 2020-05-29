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

    public class Employees : IAddingForm
    {

        public Employees()
        {
            Employees1 = new HashSet<Employees>();
            Orders = new HashSet<Orders>();
            Territories = new HashSet<Territories>();
        }

        [Key]
        public int EmployeeID { get; set; }

        [Required]
        [StringLength(30)]
        public string LastName { get; set; }

        [Required]
        [StringLength(20)]
        public string FirstName { get; set; }

        [StringLength(30)]
        public string Title { get; set; }

        [StringLength(25)]
        public string TitleOfCourtesy { get; set; }

        public DateTime? BirthDate { get; set; }

        public DateTime? HireDate { get; set; }

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
        public string HomePhone { get; set; }

        [StringLength(4)]
        public string Extension { get; set; }

        [Column(TypeName = "ntext")]
        public string Notes { get; set; }

        public int? ReportsTo { get; set; }
        [Browsable(false)]
        public virtual ICollection<Employees> Employees1 { get; set; }
        [Browsable(false)]
        public virtual Employees Employees2 { get; set; }
        [Browsable(false)]
        public virtual ICollection<Orders> Orders { get; set; }
        [Browsable(false)]
        public virtual ICollection<Territories> Territories { get; set; }
        public void AddForm()
        {
            var form = new AddEmployeesForm();
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
                    var orders = db.Orders.Where(b => b.EmployeeID == delId);
                    foreach (var item in orders)
                    {
                        db.Orders.Remove(item);
                    }
                    var employees = db.Employees.Where(b => b.ReportsTo == delId);
                    foreach (var item in employees)
                    {
                        item.ReportsTo = null;
                    }
                    Employees deleteRecord = db.Employees.First(b => b.EmployeeID == delId);
                    db.Employees.Remove(deleteRecord);
                    db.SaveChanges();
                }
            }
        }
        public void Load(DataGridView DGV)
        {
            using (var db = new NorthwindContext())
            {
                db.Employees.Load();
                DGV.DataSource = db.Employees.Local.ToList();
            }
        }
    }
}
