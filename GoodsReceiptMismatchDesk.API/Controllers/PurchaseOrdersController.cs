using GoodsReceiptMismatchDesk.API.Data;
using GoodsReceiptMismatchDesk.API.DTOs;
using GoodsReceiptMismatchDesk.API.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GoodsReceiptMismatchDesk.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseOrdersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PurchaseOrdersController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreatePurchaseOrderDto dto)
        {
            var purchaseOrder = new PurchaseOrder
            {
                PONumber = dto.PONumber,
                SupplierName = dto.SupplierName,
                OrderDate = dto.OrderDate
            };

            _context.PurchaseOrders.Add(purchaseOrder);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
                nameof(GetById),
                new { Id = purchaseOrder.Id },
                purchaseOrder
                );
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var purchaseOrder = await _context.PurchaseOrders.Include(x => x.Lines)
                                .FirstOrDefaultAsync(x => x.Id == id);

            if(purchaseOrder == null) 
                return NotFound();

            return Ok(purchaseOrder);
        }


    }
}
