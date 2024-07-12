using Microsoft.EntityFrameworkCore;
using SupplierManagementSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplierManagementSystem.Data.Data
{
    public class SupplierManagementContext : DbContext
    {
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<SupplierCategory> SupplierCategories { get; set; }
        public DbSet<SupplierTransaction> SupplierTransactions { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<PurchaseOrderLine> PurchaseOrderLines { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("your_connection_string");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Supplier and SupplierCategory relationship
            modelBuilder.Entity<Supplier>()
                .HasOne(s => s.SupplierCategory)
                .WithMany(sc => sc.Suppliers)
                .HasForeignKey(s => s.SupplierCategoryID);

            // SupplierTransaction and Supplier relationship
            modelBuilder.Entity<SupplierTransaction>()
                .HasOne(st => st.Supplier)
                .WithMany(s => s.SupplierTransactions)
                .HasForeignKey(st => st.SupplierID);

            // SupplierTransaction and PurchaseOrder relationship
            modelBuilder.Entity<SupplierTransaction>()
                .HasOne(st => st.PurchaseOrder)
                .WithMany(po => po.SupplierTransactions)
                .HasForeignKey(st => st.PurchaseOrderID);

            // PurchaseOrder and Supplier relationship
            modelBuilder.Entity<PurchaseOrder>()
                .HasOne(po => po.Supplier)
                .WithMany(s => s.PurchaseOrders)
                .HasForeignKey(po => po.SupplierID);

            // Product and Supplier relationship
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Supplier)
                .WithMany(s => s.Products)
                .HasForeignKey(p => p.SupplierID);

            // PurchaseOrderLine and PurchaseOrder relationship
            modelBuilder.Entity<PurchaseOrderLine>()
                .HasOne(pol => pol.PurchaseOrder)
                .WithMany(po => po.PurchaseOrderLines)
                .HasForeignKey(pol => pol.PurchaseOrderID);

            // PurchaseOrderLine and Product relationship
            modelBuilder.Entity<PurchaseOrderLine>()
                .HasOne(pol => pol.Product)
                .WithMany(p => p.PurchaseOrderLines)
                .HasForeignKey(pol => pol.ProductID);
        }
    }
}
