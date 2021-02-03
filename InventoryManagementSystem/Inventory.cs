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
        public static bool debug = false; 
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

        public Inventory()
        {
            products = new BindingList<Product>();
            allParts = new BindingList<Part>();

            if(debug)
            {
                Outsourced newPart = new Outsourced();
                newPart.Name = "Test";
                newPart.InStock = 1;
                newPart.Min = 1;
                newPart.Max = 1;
                newPart.PartID = 123;
                newPart.CompanyName = "Test Company";
                newPart.Price = 10.00M;

                allParts.Add(newPart);
                Console.WriteLine(allParts.Count);
            }
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
            allParts.Add(part);
            Console.WriteLine(allParts.Count);
        }
        public bool deletePart(Part part)
        {
            return allParts.Remove(part);
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
