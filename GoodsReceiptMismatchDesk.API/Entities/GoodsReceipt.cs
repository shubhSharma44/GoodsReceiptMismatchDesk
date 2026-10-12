namespace GoodsReceiptMismatchDesk.API.Entities
{
    public class GoodsReceipt
    {
        public int Id { get; set; }
        public int PurchaseOrderId { get; set; }
        public int PurchaseOrderLineId { get; set; }
        public string ReceiptNumber { get; set; } = string.Empty;
        public int ReceivedQuantity { get; set; }
        public DateTime ReceivedDate { get; set; }
        public string? Remarks { get; set; }
        public PurchaseOrder PurchaseOrder { get; set; } = null!;
        public PurchaseOrderLine PurchaseOrderLine { get; set; } = null!;
    }
}
