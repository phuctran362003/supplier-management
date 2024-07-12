using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplierManagementSystem.Core.Entities
{
    public class SupplierTransaction
    {
        public int SupplierTransactionID { get; set; }
        public int SupplierID { get; set; }
        public string TransactionType { get; set; }
        public int PurchaseOrderID { get; set; }
        public string PaymentMethod { get; set; }
        public string SupplierInvoiceNumber { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal AmountExcludingTax { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal TransactionAmount { get; set; }
        public DateTime? FinalizedDate { get; set; }
        public bool IsFinalized { get; set; }

        // Navigation properties
        public Supplier Supplier { get; set; }
        public PurchaseOrder PurchaseOrder { get; set; }
    }
}
