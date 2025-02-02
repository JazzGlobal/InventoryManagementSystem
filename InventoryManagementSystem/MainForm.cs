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
            EventManager.OnModifyPart += ModifyPart;
            EventManager.OnAddProduct += AddProduct;
            EventManager.OnModifyProduct += ModifyProduct;
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
            var rows = productDataGridView.SelectedRows;
            if(rows.Count > 0)
            {
                modifyProductForm = new ModifyProduct((Product)rows[0].DataBoundItem, rows[0].Index);
                modifyProductForm.ShowDialog();
            }
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

        private void AddProduct(Product product)
        {
            inventory.AddProduct(product);
        }

        private void ModifyProduct(Product product, int editIndex)
        {
            inventory.updateProduct(editIndex, product);
        }

        private void partsDeleteButton_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = partDataGridView.SelectedRows;
            if(rows.Count > 0)
            {
                if(deleteConfirm())
                {
                    inventory.deletePart((Part)rows[0].DataBoundItem);
                }
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
            DataGridViewSelectedRowCollection rows = productDataGridView.SelectedRows;
            if (rows.Count > 0)
            {
                Product selected = inventory.Products[rows[0].Index];
                if(selected.AssociatedParts.Count == 0)
                {
                    if (deleteConfirm())
                    {
                        inventory.removeProduct(rows[0].Index);
                    }
                } else
                {
                    createErrorWindow($"Could not delete product {selected.ProductID} because it has associated parts.");
                }
            }
        }
        public static void createErrorWindow(string error_message)
        {            
            MessageBox.Show(error_message, "Error");
        }
        private bool deleteConfirm()
        {
            return MessageBox.Show("Yes or No", "Delete Item?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            EventManager.OnAddPart -= AddPart;
            EventManager.OnModifyPart -= ModifyPart;
            EventManager.OnAddProduct -= AddProduct;
            EventManager.OnModifyProduct -= ModifyProduct;
        }
    }
}
