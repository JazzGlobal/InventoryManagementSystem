using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    public class EventManager
    {
        public delegate void AddPartAction(Part part);
        public delegate void ModifyPartAction(Part part, int editIndex);
        public delegate void AddProductAction(Product product);
        public delegate void ModifyProductAction(Product product, int editIndex);
        public static event AddPartAction OnAddPart;
        public static event ModifyPartAction OnModifyPart;
        public static event AddProductAction OnAddProduct;
        public static event ModifyProductAction OnModifyProduct;
        
        
        public static void FireAddPart(Part part)
        {
            OnAddPart(part);
        }
        public static void FireModifyPart(Part part, int editIndex)
        {
            OnModifyPart(part, editIndex);
        }
        public static void FireAddProduct(Product product)
        {
            OnAddProduct(product);
        }
        public static void FireModifyProduct(Product product, int editIndex)
        {
            OnModifyProduct(product, editIndex);
        }
    }
}
