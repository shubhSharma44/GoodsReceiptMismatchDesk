using GoodsReceiptMismatchDesk.API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GoodsReceiptMismatchDesk.API.Data.Configurations
{
    public class PurchaseOrderConfiguration : IEntityTypeConfiguration<PurchaseOrder>
    {
        public void Configure(EntityTypeBuilder<PurchaseOrder> builder) {

            builder.HasKey(x => x.Id);

            builder.Property(x => x.PONumber)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasIndex(x => x.PONumber)
                .IsUnique();

            builder.Property(x => x.SupplierName)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(x => x.Status)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(x => x.OrderDate)
                .IsRequired();
        }
    }
}
