using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    public abstract class Part
    {
        public int PartID;
        public string Name;
        public decimal Price;
        public int InStock;
        public int Min;
        public int Max;
    }
}
