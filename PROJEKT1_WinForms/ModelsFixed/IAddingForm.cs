using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJEKT1_WinForms.ModelsFixed
{
    interface IAddingForm
    {
        void AddForm();
        void Delete(DataGridView DGV);
        void Load(DataGridView DGV);
    }
}
