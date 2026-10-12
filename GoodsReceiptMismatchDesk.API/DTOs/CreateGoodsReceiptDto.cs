namespace GoodsReceiptMismatchDesk.API.DTOs
{
    public class CreateGoodsReceiptDto
    {
        public int PurchaseOrderId { get; set; }
        public int PurchaseOrderLineId { get; set; }
        public string ReceiptNumber { get; set; } = string.Empty;
        public int ReceivedQuantity { get; set; }
        public DateTime ReceivedDate { get; set; }
        public string? Remarks { get; set; }
    }
}
