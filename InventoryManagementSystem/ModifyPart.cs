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
            } else
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

            EventManager.FireModifyPart(newPart,editIndex);
            Close();
        }
    }
}
