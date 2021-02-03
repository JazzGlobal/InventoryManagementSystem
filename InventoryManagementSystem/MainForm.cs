using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class MainForm : Form
    {
        static AddPart addPartForm;
        static ModifyPart modifyPartForm;

        static AddProduct addProductForm;
        static ModifyProduct modifyProductForm;

        public static Inventory inventory; 

        public MainForm()
        {
            InitializeComponent();
            Inventory.debug = true;
            inventory = new Inventory();
            EventManager.OnAddPart += AddPart;
        }
        private void partsAddButton_Click(object sender, EventArgs e)
        {
            addPartForm = new AddPart();
            addPartForm.ShowDialog();
        }

        private void partsModifyButton_Click(object sender, EventArgs e)
        {
            modifyPartForm = new ModifyPart();
            modifyPartForm.ShowDialog();
        }

        private void productsAddButton_Click(object sender, EventArgs e)
        {
            addProductForm = new AddProduct();
            addProductForm.ShowDialog();
        }

        private void productsModifyButton_Click(object sender, EventArgs e)
        {
            modifyProductForm = new ModifyProduct();
            modifyProductForm.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            partDataGridView.DataSource = inventory.AllParts;
        }
        private void AddPart(Part part, bool outsourced)
        {
           if(outsourced)
            {
                inventory.addPart((Outsourced)part);
            } else
            {
                inventory.addPart((InHouse)part);
            }
        }

        private void partsDeleteButton_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = partDataGridView.SelectedRows;
            if(rows.Count > 0)
            {
                inventory.deletePart((Part)rows[0].DataBoundItem);
            }
        }
    }
}
