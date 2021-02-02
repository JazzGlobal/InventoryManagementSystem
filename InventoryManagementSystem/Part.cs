using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    public abstract class Part
    {

        protected int partId;
        protected string name;
        protected decimal price;
        protected int inStock;
        protected int min;
        protected int max;

        public int PartID
        {
            get { return partId; }
            set { partId = value; }
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
            get { return inStock; }
            set { inStock = value; }
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
    }
}
