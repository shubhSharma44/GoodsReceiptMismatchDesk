namespace GoodsReceiptMismatchDesk.API.DTOs
{
    public class CreatePurchaseOrderDto
    {
        public string PONumber { get; set; } = string.Empty;
        public string SupplierName { get; set; } = string.Empty;
        public DateTime OrderDate { get; set; }
    }
}
