using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public class Inventory
    {

        private BindingList<Product> products;
        private BindingList<Part> allParts;
        public BindingList<Product> Products
        {
            get { return products; }
            set { products = value; }
        }
        public BindingList<Part> AllParts
        {
            get { return allParts; }
            set { allParts = value; }
        }

        public void AddProduct(Product product)
        {
            throw new NotImplementedException();
        }
        public bool removeProduct(int index)
        {
            throw new NotImplementedException(); 
        }
        public Product lookupProduct(int index)
        {
            throw new NotImplementedException(); 
        }
        public void updateProduct(int index, Product product)
        {
            throw new NotImplementedException();
        }
        public void addPart(Part part)
        {
            throw new NotImplementedException(); 
        }
        public bool deletePart(Part part)
        {
            throw new NotImplementedException();
        }
        public Part lookupPart(int index)
        {
            throw new NotImplementedException();
        }
        public void updatePart(int index, Part part)
        {
            throw new NotImplementedException();
        }
    }
}
