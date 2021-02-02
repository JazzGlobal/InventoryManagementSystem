using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    public class InHouse : Part
    {
        private int machineId;
        public int MachineID
        {
            get { return machineId; }
            set { machineId = value; }
        }
    }
}
