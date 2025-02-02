﻿using System;
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
    public partial class ModifyProduct : Form
    {
        BindingList<Part> temp_inventory;

        Product product;
        int editIndex;

        public ModifyProduct(Product product, int editIndex)
        {
            InitializeComponent();
            this.product = product;
            this.editIndex = editIndex;
            temp_inventory = new BindingList<Part>(MainForm.inventory.AllParts.ToList());
        }

        private void ModifyProduct_Shown(object sender, EventArgs e)
        {
            foreach(Part p in product.AssociatedParts)
            {
                if (temp_inventory.Contains(p))
                {
                    temp_inventory.Remove(p);
                }
            }
            refreshCandidatePartList();
            refreshAssociatedPartList();
            modifyProductIDTextBox.Text = product.ProductID.ToString(); ;
            modifyProductNameTextBox.Text = product.Name;
            modifyProductInventoryTextBox.Text = product.InStock.ToString();
            modifyProductPriceCostTextBox.Text = product.Price.ToString();
            modifyProductMaxTextBox.Text = product.Max.ToString();
            modifyProductMinTextBox.Text = product.Min.ToString(); 
            
        }
        private void refreshCandidatePartList()
        {
            candidatePartDataGridView.DataSource = temp_inventory;
        }
        private void refreshAssociatedPartList()
        {
            associatedPartsDataGridView.DataSource =product.AssociatedParts;
        }

        private void productsAddButton_Click(object sender, EventArgs e)
        {
            Part part;
            var rows = candidatePartDataGridView.SelectedRows;
            if (rows.Count > 0)
            {
                part = (Part)rows[0].DataBoundItem;
                temp_inventory.Remove(part);
                product.AssociatedParts.Add(part);
            }
            refreshAssociatedPartList();
        }

        private void modifyProductDeleteButton_Click(object sender, EventArgs e)
        {
            Part part;
            var rows = associatedPartsDataGridView.SelectedRows;
            if (rows.Count > 0)
            {
                part = (Part)rows[0].DataBoundItem;
                product.AssociatedParts.Remove(part);
                temp_inventory.Add(part);
                refreshCandidatePartList();
            }
            refreshAssociatedPartList();
        }

        private void modifyProductSaveButton_Click(object sender, EventArgs e)
        {
            Product newProduct = new Product();
            newProduct.AssociatedParts = product.AssociatedParts;
            newProduct.Name = modifyProductNameTextBox.Text;
            newProduct.InStock = int.Parse(modifyProductInventoryTextBox.Text);
            newProduct.Max = int.Parse(modifyProductMaxTextBox.Text);
            newProduct.Min = int.Parse(modifyProductMinTextBox.Text);
            newProduct.ProductID = int.Parse(modifyProductIDTextBox.Text);
            newProduct.Price = decimal.Parse(modifyProductPriceCostTextBox.Text);

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
                EventManager.FireModifyProduct(newProduct, editIndex);
                Close();
            }
        }

        private void modifyProductCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void productsSearchButton_Click(object sender, EventArgs e)
        {
            IEnumerable<Part> partQuery =
                from part in temp_inventory
                where part.Name.ToLower().Contains(productsSearchTextbox.Text.ToLower())
                select part;
            candidatePartDataGridView.DataSource = partQuery.ToList();
        }
        private bool errorCheck()
        {
            // Checks to ensure every parsed field can successfully be parsed.
            return int.TryParse(modifyProductIDTextBox.Text, out int idResult)
                    && decimal.TryParse(modifyProductPriceCostTextBox.Text, out decimal priceResult) && int.TryParse(modifyProductInventoryTextBox.Text, out int inventoryResult)
                    && int.TryParse(modifyProductMinTextBox.Text, out int minResult) && int.TryParse(modifyProductMaxTextBox.Text, out int maxResult);
        }

        private void modifyProductIDTextBox_TextChanged(object sender, EventArgs e)
        {
            modifyProductSaveButton.Enabled = errorCheck();
        }

        private void modifyProductInventoryTextBox_TextChanged(object sender, EventArgs e)
        {
            modifyProductSaveButton.Enabled = errorCheck();
        }

        private void modifyProductPriceCostTextBox_TextChanged(object sender, EventArgs e)
        {
            modifyProductSaveButton.Enabled = errorCheck();
        }

        private void modifyProductMaxTextBox_TextChanged(object sender, EventArgs e)
        {
            modifyProductSaveButton.Enabled = errorCheck();
        }

        private void modifyProductMinTextBox_TextChanged(object sender, EventArgs e)
        {            
            modifyProductSaveButton.Enabled = errorCheck();
        }

        private void productsSearchTextbox_TextChanged(object sender, EventArgs e)
        {
            if (productsSearchTextbox.Text == "")
            {
                resetCandidatePartDataGridView();
            }
        }
        private void resetCandidatePartDataGridView()
        {
            candidatePartDataGridView.DataSource = temp_inventory;
        }
    }
}
