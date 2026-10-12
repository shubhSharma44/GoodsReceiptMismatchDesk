using GoodsReceiptMismatchDesk.API.Data.Configurations;
using GoodsReceiptMismatchDesk.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace GoodsReceiptMismatchDesk.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
            
        }
        public DbSet<PurchaseOrder> PurchaseOrders => Set<PurchaseOrder>();
        public DbSet<PurchaseOrderLine> PurchaseOrderLines => Set<PurchaseOrderLine>();
        public DbSet<GoodsReceipt> GoodsReceipts => Set<GoodsReceipt>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }

    }
}
