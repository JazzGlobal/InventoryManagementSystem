using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    public class EventManager
    {
        public delegate void AddPartAction(Part part, bool outsourced);
        public static event AddPartAction OnAddPart;
    
        public static void FireAddPart(Part part, bool outsourced)
        {
            OnAddPart(part, outsourced);
        }
    }
}
