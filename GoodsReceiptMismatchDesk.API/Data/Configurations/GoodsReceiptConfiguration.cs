using GoodsReceiptMismatchDesk.API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GoodsReceiptMismatchDesk.API.Data.Configurations
{
    public class GoodsReceiptConfiguration : IEntityTypeConfiguration<GoodsReceipt>
    {
        public void Configure(EntityTypeBuilder<GoodsReceipt> builder) { 
        
            builder.HasKey(x => x.Id );

            builder.Property(x => x.ReceiptNumber)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(x => x.ReceivedQuantity)
                .IsRequired();

            builder.Property(x => x.ReceivedDate)
                .IsRequired();

            builder.Property(x => x.Remarks)
                .HasMaxLength(500);

            builder.HasOne(x => x.PurchaseOrderLine)
                .WithMany()
                .HasForeignKey(x => x.PurchaseOrderLineId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.PurchaseOrder)
                .WithMany()
                .HasForeignKey(x => x.PurchaseOrderId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
