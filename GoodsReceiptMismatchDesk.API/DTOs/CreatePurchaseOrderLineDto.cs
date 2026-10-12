namespace GoodsReceiptMismatchDesk.API.DTOs
{
    public class CreatePurchaseOrderLineDto
    {
        public int PurchaseOrderId { get; set; }
        public string ItemCode { get; set; } = string.Empty;
        public string ItemName { get; set; } = string.Empty;
        public int OrderQuantity { get; set; }
        public decimal UnitPrice { get; set; }

    }
}
