namespace GoodsReceiptMismatchDesk.API.Entities
{
    public class PurchaseOrder
    {
        public int Id { get; set; }
        public string PONumber { get; set; } = string.Empty;
        public string SupplierName { get; set; } = string.Empty;
        public DateTime OrderDate { get; set; }
        public string Status { get; set; } = "Open";

        public ICollection<PurchaseOrderLine> Lines { get; set; }
            = new List<PurchaseOrderLine>();
    }
}
