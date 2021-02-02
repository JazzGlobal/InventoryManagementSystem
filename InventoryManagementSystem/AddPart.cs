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
            bool outsourced = false;
            Part newPart;
            if (addPartOutsourcedRadioButton.Checked)
            {
                outsourced = true;
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

            EventManager.FireAddPart(newPart, outsourced);

            Close();
        }
    }
}
