using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.Entity;
using System.Data.Linq;
using System.Windows.Documents;
using System.Reflection;
using PROJEKT1_WinForms.ModelsFixed;
using PROJEKT1_WinForms.FormsFixed;

namespace PROJEKT1_WinForms
{
    public partial class Form1 : Form
    {
        Dictionary<string,IAddingForm> tableList = new Dictionary<string,IAddingForm>();
        IAddingForm actualObj;
        public Form1()
        {
            InitializeComponent();
            comboBoxChooseTable.DropDownStyle = ComboBoxStyle.DropDownList;
            buttonCreate.Enabled = true;
            buttonDelete.Enabled = true;
            dataGridViewTable.DataSource = null;
            using (var db = new NorthwindContext())
            {
                tableList.Add("Categories", new Categories());
                tableList.Add("CustomerDemographics", new CustomerDemographics());
                tableList.Add("Customers", new Customers());
                tableList.Add("Employees", new Employees());
                tableList.Add("Order Details", new Order_Details());
                tableList.Add("Orders", new Orders());
                tableList.Add("Products", new Products());
                tableList.Add("Region", new Region());
                tableList.Add("Shippers", new Shippers());
                tableList.Add("Suppliers", new Suppliers());
                tableList.Add("Territories", new Territories());
                foreach(var item in tableList)
                {
                    comboBoxChooseTable.Items.Add(item.Key);
                }
                comboBoxChooseTable.SelectedIndex = 0;
                actualObj = tableList[comboBoxChooseTable.Text];
                actualObj.Load(dataGridViewTable);
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            actualObj.AddForm();
            actualObj.Load(dataGridViewTable);
        }

        private void buttonShowTable_Click(object sender, EventArgs e)
        {
            dataGridViewTable.DataSource = null;
            actualObj = tableList[comboBoxChooseTable.Text];
            actualObj.Load(dataGridViewTable);
        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewTable == null || dataGridViewTable.Rows.Count == 0)
            {
                MessageBox.Show("Table is empty", "ERROR"
                    ,MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                actualObj.Delete(dataGridViewTable);
                actualObj.Load(dataGridViewTable);
            }

        }
    }
}
