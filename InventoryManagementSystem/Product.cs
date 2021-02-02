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
        public BindingList<Part> AssociatedParts;
        public int ProductID;
        public string Name;
        public decimal Price;
        public int InStock;
        public int Min;
        public int Max;

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
