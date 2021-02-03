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

            EventManager.FireModifyProduct(newProduct, editIndex);
            Close();
        }

        private void modifyProductCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void productsSearchButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
