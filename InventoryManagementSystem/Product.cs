using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    public class Product
    {
        private BindingList<Part> associatedParts;
        private int productId;
        private string name;
        private decimal price;
        private int instock;
        private int min;
        private int max;

        public BindingList<Part> AssociatedParts
        {
            get { return associatedParts; }
            set { associatedParts = value; }
        }
        public int ProductID
        {
            get { return productId; }
            set { productId = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        public int InStock
        {
            get { return instock; }
            set { instock = value; }
        }
        public int Min
        {
            get { return min; }
            set { min = value; }
        }
        public int Max
        {
            get { return max; }
            set { max = value; }
        }

        public void addAssociatedPart(Part part)
        {
            throw new NotImplementedException();
        }
        public bool removeAssociatedPart(int index)
        {
            throw new NotImplementedException(); 
        }
        public Part lookupAssociatedPart(int index)
        {
            throw new NotImplementedException();
        }
    }
}
