using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplierManagementSystem.Core.Entities
{
    public class Supplier
    {
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public int SupplierCategoryID { get; set; }
        public string DeliveryMethod { get; set; }
        public string DeliveryCity { get; set; }
        public string DeliveryAddressLine1 { get; set; }
        public string DeliveryAddressLine2 { get; set; }
        public string SupplierReference { get; set; }
        public string DeliveryPostalCode { get; set; }
        public string BankAccountName { get; set; }
        public string BankAccountBranch { get; set; }
        public string BankAccountCode { get; set; }
        public string BankAccountNumber { get; set; }
        public int PaymentDays { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string WebsiteURL { get; set; }

        // Navigation properties
        public SupplierCategory SupplierCategory { get; set; }
        public ICollection<SupplierTransaction> SupplierTransactions { get; set; }
        public ICollection<PurchaseOrder> PurchaseOrders { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
