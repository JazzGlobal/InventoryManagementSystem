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
    public partial class AddProduct : Form
    {
        BindingList<Part> temp_associatedParts;
        BindingList<Part> temp_inventory;
        public AddProduct()
        {
            InitializeComponent();
            temp_associatedParts = new BindingList<Part>();
            temp_inventory = new BindingList<Part>(MainForm.inventory.AllParts.ToList());
        }

        private void AddProduct_Shown(object sender, EventArgs e)
        {
            refreshCandidatePartList();
        }
        private void refreshCandidatePartList()
        {
            candidatePartDataGridView.DataSource = temp_inventory;
        }
        private void refreshAssociatedPartList()
        {
            associatedPartsDataGridView.DataSource = temp_associatedParts;
        }
        private void addProductSaveButton_Click(object sender, EventArgs e)
        {
            Product newProduct = new Product();
            newProduct.AssociatedParts = temp_associatedParts;
            newProduct.Name = addProductNameTextBox.Text;
            newProduct.InStock = int.Parse(addProductInventoryTextBox.Text);
            newProduct.Max = int.Parse(addProductMaxTextBox.Text);
            newProduct.Min = int.Parse(addProductMinTextBox.Text);
            newProduct.ProductID = int.Parse(addProductIDTextBox.Text);
            newProduct.Price = decimal.Parse(addProductPriceCostTextBox.Text);

            if (newProduct.Max < newProduct.Min)
            {
                MessageBox.Show("Max must be greater than or equal to Min");
            }
            else if (!(newProduct.InStock >= newProduct.Min) || !(newProduct.InStock <= newProduct.Max))
            {
                MessageBox.Show("Inventory must fall with Min and Max.");
            }
            else
            {
                EventManager.FireAddProduct(newProduct);
                Close();
            }
        }

        private void productsAddButton_Click(object sender, EventArgs e)
        {
            Part part; 
            var rows = candidatePartDataGridView.SelectedRows;
            if(rows.Count > 0)
            {
                part = (Part) rows[0].DataBoundItem;
                temp_inventory.Remove(part);
                temp_associatedParts.Add(part);
            }
            refreshAssociatedPartList();
        }

        private void addProductCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addProductDeleteButton_Click(object sender, EventArgs e)
        {
            Part part;
            var rows = associatedPartsDataGridView.SelectedRows;
            if(rows.Count > 0)
            {
                part = (Part)rows[0].DataBoundItem;
                temp_associatedParts.Remove(part);
                temp_inventory.Add(part);
                refreshCandidatePartList();
            }
            refreshAssociatedPartList();
        }

        private void productsSearchButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private bool errorCheck()
        {
                // Checks to ensure every parsed field can successfully be parsed.
            return int.TryParse(addProductIDTextBox.Text, out int idResult)
                    && decimal.TryParse(addProductPriceCostTextBox.Text, out decimal priceResult) && int.TryParse(addProductInventoryTextBox.Text, out int inventoryResult)
                    && int.TryParse(addProductMinTextBox.Text, out int minResult) && int.TryParse(addProductMaxTextBox.Text, out int maxResult);   
        }

        private void addProductIDTextBox_TextChanged(object sender, EventArgs e)
        {
            addProductSaveButton.Enabled = errorCheck();
        }

        private void addProductInventoryTextBox_TextChanged(object sender, EventArgs e)
        {
            addProductSaveButton.Enabled = errorCheck();
        }

        private void addProductPriceCostTextBox_TextChanged(object sender, EventArgs e)
        {
            addProductSaveButton.Enabled = errorCheck();
        }

        private void addProductMaxTextBox_TextChanged(object sender, EventArgs e)
        {
            addProductSaveButton.Enabled = errorCheck();
        }

        private void addProductMinTextBox_TextChanged(object sender, EventArgs e)
        {
            addProductSaveButton.Enabled = errorCheck();
        }
    }
}
