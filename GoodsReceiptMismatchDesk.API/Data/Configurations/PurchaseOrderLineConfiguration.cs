using GoodsReceiptMismatchDesk.API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GoodsReceiptMismatchDesk.API.Data.Configurations
{
    public class PurchaseOrderLineConfiguration : IEntityTypeConfiguration<PurchaseOrderLine>
    {
        public void Configure(EntityTypeBuilder<PurchaseOrderLine> builder) {

            builder.HasKey(x => x.Id);

            builder.Property(x => x.ItemCode)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(x => x.ItemName)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(x => x.OrderQuantity)
                .IsRequired();

            builder.Property(x => x.UnitPrice)
                .HasPrecision(18, 2)
                .IsRequired();

            builder.HasOne(x => x.PurchaseOrder)
                .WithMany(x => x.Lines)
                .HasForeignKey(x => x.PurchaseOrderId)
                .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
