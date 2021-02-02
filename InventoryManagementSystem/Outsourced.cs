using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    public class Outsourced : Part
    {
        private string companyName;
        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }
    }
}
