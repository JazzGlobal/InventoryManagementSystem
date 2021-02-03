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

        private Inventory inventory; 

        public MainForm()
        {
            InitializeComponent();
            Inventory.debug = true;
            inventory = new Inventory();
            EventManager.OnAddPart += AddPart;
            EventManager.OnModifyPart += ModifyPart;
        }
        private void partsAddButton_Click(object sender, EventArgs e)
        {
            addPartForm = new AddPart();
            addPartForm.ShowDialog();
        }

        private void partsModifyButton_Click(object sender, EventArgs e)
        {
            var rows = partDataGridView.SelectedRows;
            if(rows.Count > 0)
            {
                modifyPartForm = new ModifyPart((Part)rows[0].DataBoundItem, rows[0].Index);
                modifyPartForm.ShowDialog();
            }
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
            resetPartDataGridView();
            resetProductDataGridView();
        }
        private void AddPart(Part part)
        {
           if(part.GetType() == typeof(Outsourced))
            {
                inventory.addPart((Outsourced)part);
            } else
            {
                inventory.addPart((InHouse)part);
            }
        }
        private void ModifyPart(Part part, int editIndex)
        {
            inventory.updatePart(editIndex, part);
        }
        private void partsDeleteButton_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = partDataGridView.SelectedRows;
            if(rows.Count > 0)
            {
                inventory.deletePart((Part)rows[0].DataBoundItem);
            }
        }

        private void resetPartDataGridView()
        {
            partDataGridView.DataSource = inventory.AllParts;
        }
        private void resetProductDataGridView()
        {
            productDataGridView.DataSource = inventory.Products;
        }

        private void partsSearchButton_Click(object sender, EventArgs e)
        {
            IEnumerable<Part> partQuery =
                from part in inventory.AllParts
                where part.Name.ToLower().Contains(partsSearchTextBox.Text.ToLower())
                select part;
            partDataGridView.DataSource = partQuery.ToList();
        }

        private void partsSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if(partsSearchTextBox.Text == "")
            {
                resetPartDataGridView();
            }
        }

        private void productsSearchButton_Click(object sender, EventArgs e)
        {
            IEnumerable<Product> productQuery =
                from product in inventory.Products
                where product.Name.ToLower().Contains(productsSearchTextbox.Text.ToLower())
                select product;
            productDataGridView.DataSource = productQuery.ToList();
        }

        private void productsSearchTextbox_TextChanged(object sender, EventArgs e)
        {
            if(productsSearchTextbox.Text == "")
            {
                resetProductDataGridView();
            }
        }

        private void productsDeleteButton_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = partDataGridView.SelectedRows;
            if (rows.Count > 0)
            {
                inventory.removeProduct(rows[0].Index);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            EventManager.OnAddPart -= AddPart;
            EventManager.OnModifyPart -= ModifyPart;
        }
    }
}
