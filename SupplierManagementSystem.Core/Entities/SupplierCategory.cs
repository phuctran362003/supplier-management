using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplierManagementSystem.Core.Entities
{
    public class SupplierCategory
    {
        public int SupplierCategoryID { get; set; }
        public string SupplierCategoryName { get; set; }

        // Navigation property
        public ICollection<Supplier> Suppliers { get; set; }
    }
}
