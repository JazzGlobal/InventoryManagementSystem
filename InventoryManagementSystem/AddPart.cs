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
    public partial class AddPart : Form
    {
        public AddPart()
        {
            InitializeComponent();
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
            } else
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

            if(newPart.Max < newPart.Min)
            {
                MessageBox.Show("Max must be greater than or equal to Min");
            } else
            {
                EventManager.FireAddPart(newPart);
                Close();
            }
        }
        private void AddPart_Shown(object sender, EventArgs e)
        {
            addPartInHouseRadioButton.Checked = true;
        }

        private void addPartIDTextBox_TextChanged(object sender, EventArgs e)
        {
            addPartSaveButton.Enabled = errorCheck();
        }
        private bool errorCheck()
        {
            bool errorFree = true;
            if(addPartInHouseRadioButton.Checked)
            {
                // try parse part identity
                errorFree = int.TryParse(addPartIdentityTextBox.Text, out int identityResult) && int.TryParse(addPartIDTextBox.Text, out int idResult)
                    && decimal.TryParse(addPartPriceCostTextBox.Text, out decimal priceResult) && int.TryParse(addPartInventoryTextBox.Text, out int inventoryResult)
                    && int.TryParse(addPartMinTextBox.Text, out int minResult) && int.TryParse(addPartMaxTextBox.Text, out int maxResult);
            } else
            {
                // Identity not needed when Outsourced.
                errorFree = int.TryParse(addPartIDTextBox.Text, out int idResult)
                    && decimal.TryParse(addPartPriceCostTextBox.Text, out decimal priceResult) && int.TryParse(addPartInventoryTextBox.Text, out int inventoryResult)
                    && int.TryParse(addPartMinTextBox.Text, out int minResult) && int.TryParse(addPartMaxTextBox.Text, out int maxResult);
            }
            return errorFree;
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
            if (addPartInHouseRadioButton.Checked)
            {
                addPartSaveButton.Enabled = errorCheck();
            }
        }
        private void addPartInHouseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            addPartSaveButton.Enabled = errorCheck();
        }
    }
}
