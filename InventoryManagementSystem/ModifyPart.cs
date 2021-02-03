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
    public partial class ModifyPart : Form
    {
        Part part;
        int editIndex;
        public ModifyPart(Part part, int editIndex)
        {
            InitializeComponent();
            this.part = part;
            this.editIndex = editIndex;
        }

        private void ModifyPart_Shown(object sender, EventArgs e)
        {
            if(part.GetType() == typeof(Outsourced))
            {
                addPartOutsourcedRadioButton.Checked = true;
                addPartIdentityTextBox.Text = (part as Outsourced).CompanyName;
            }
            else
            {
                addPartInHouseRadioButton.Checked = true;
                addPartIdentityTextBox.Text = (part as InHouse).MachineID.ToString();
            }

            addPartNameTextBox.Text = part.Name;
            addPartIDTextBox.Text = part.PartID.ToString();
            addPartMaxTextBox.Text = part.Max.ToString();
            addPartMinTextBox.Text = part.Min.ToString();
            addPartInventoryTextBox.Text = part.InStock.ToString();
            addPartPriceCostTextBox.Text = part.Price.ToString();
        }

        private void addPartCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addPartSaveButton_Click(object sender, EventArgs e)
        {
            Part newPart;
            if (addPartOutsourcedRadioButton.Checked)
            {
                newPart = new Outsourced();
                (newPart as Outsourced).CompanyName = addPartIdentityTextBox.Text;
            }
            else
            {
                newPart = new InHouse();
                (newPart as InHouse).MachineID = int.Parse(addPartIdentityTextBox.Text);
            }
            newPart.PartID = int.Parse(addPartIDTextBox.Text);
            newPart.Name = addPartNameTextBox.Text;
            newPart.Price = decimal.Parse(addPartPriceCostTextBox.Text);
            newPart.InStock = int.Parse(addPartInventoryTextBox.Text);
            newPart.Min = int.Parse(addPartMinTextBox.Text);
            newPart.Max = int.Parse(addPartMaxTextBox.Text);

            if (newPart.Max < newPart.Min)
            {
                MessageBox.Show("Max must be greater than or equal to Min");
            }
            else if (!(newPart.InStock >= newPart.Min) || !(newPart.InStock <= newPart.Max))
            {
                MessageBox.Show("Inventory must fall with Min and Max.");
            }
            else
            {
                EventManager.FireModifyPart(newPart, editIndex);
                Close();
            }
        }
        private bool errorCheck()
        {
            bool errorFree;
            if (addPartInHouseRadioButton.Checked)
            {
                // try parse part identity
                errorFree = int.TryParse(addPartIdentityTextBox.Text, out int identityResult) && int.TryParse(addPartIDTextBox.Text, out int idResult)
                    && decimal.TryParse(addPartPriceCostTextBox.Text, out decimal priceResult) && int.TryParse(addPartInventoryTextBox.Text, out int inventoryResult)
                    && int.TryParse(addPartMinTextBox.Text, out int minResult) && int.TryParse(addPartMaxTextBox.Text, out int maxResult);
            }
            else
            {
                // Identity not needed when Outsourced.
                errorFree = int.TryParse(addPartIDTextBox.Text, out int idResult)
                    && decimal.TryParse(addPartPriceCostTextBox.Text, out decimal priceResult) && int.TryParse(addPartInventoryTextBox.Text, out int inventoryResult)
                    && int.TryParse(addPartMinTextBox.Text, out int minResult) && int.TryParse(addPartMaxTextBox.Text, out int maxResult);
            }
            return errorFree;
        }

        private void addPartIDTextBox_TextChanged(object sender, EventArgs e)
        {
            addPartSaveButton.Enabled = errorCheck();
        }

        private void addPartInventoryTextBox_TextChanged(object sender, EventArgs e)
        {
            addPartSaveButton.Enabled = errorCheck();
        }

        private void addPartPriceCostTextBox_TextChanged(object sender, EventArgs e)
        {
            addPartSaveButton.Enabled = errorCheck();
        }

        private void addPartMaxTextBox_TextChanged(object sender, EventArgs e)
        {
            addPartSaveButton.Enabled = errorCheck();
        }

        private void addPartMinTextBox_TextChanged(object sender, EventArgs e)
        {
            addPartSaveButton.Enabled = errorCheck();
        }

        private void addPartIdentityTextBox_TextChanged(object sender, EventArgs e)
        {
            addPartSaveButton.Enabled = errorCheck();
        }

        private void addPartInHouseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            addPartSaveButton.Enabled = errorCheck();
            if (addPartInHouseRadioButton.Checked)
            {
                addPartIdentityLabel.Text = "Machine ID";
            }
            else
            {
                addPartIdentityLabel.Text = "Company Name";
            }
        }
    }
}
