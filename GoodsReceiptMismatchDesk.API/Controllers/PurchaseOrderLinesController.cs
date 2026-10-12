using GoodsReceiptMismatchDesk.API.Data;
using GoodsReceiptMismatchDesk.API.DTOs;
using GoodsReceiptMismatchDesk.API.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GoodsReceiptMismatchDesk.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseOrderLinesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PurchaseOrderLinesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreatePurchaseOrderLineDto dto)
        {
            var purchaseOrder = await _context.PurchaseOrders.FindAsync(dto.PurchaseOrderId);

            if(purchaseOrder is null)
                return NotFound("Purchase Order Not Found.");

            var line = new PurchaseOrderLine
            {
                PurchaseOrderId = dto.PurchaseOrderId,
                ItemCode = dto.ItemCode,
                ItemName = dto.ItemName,
                OrderQuantity = dto.OrderQuantity,
                UnitPrice = dto.UnitPrice
            };

            _context.PurchaseOrderLines.Add(line);
            await _context.SaveChangesAsync();

            return Ok(line);
        }
    }
}
