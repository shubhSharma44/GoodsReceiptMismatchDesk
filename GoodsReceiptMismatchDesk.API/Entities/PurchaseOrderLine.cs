namespace GoodsReceiptMismatchDesk.API.Entities
{
    public class PurchaseOrderLine
    {
        public int Id { get; set; }
        public int PurchaseOrderId { get; set; }
        public string ItemCode { get; set; } = string.Empty;
        public string ItemName { get; set; } = string.Empty;
        public int OrderQuantity { get; set; }
        public decimal UnitPrice { get; set; }
        public PurchaseOrder PurchaseOrder { get; set; } = null!;
    }
}
