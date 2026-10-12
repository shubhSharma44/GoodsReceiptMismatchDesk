using GoodsReceiptMismatchDesk.API.Data;
using GoodsReceiptMismatchDesk.API.DTOs;
using GoodsReceiptMismatchDesk.API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GoodsReceiptMismatchDesk.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GoodsReceiptsController : ControllerBase
{
    private readonly AppDbContext _context;

    public GoodsReceiptsController(AppDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateGoodsReceiptDto dto)
    {
        var line = await _context.PurchaseOrderLines
            .FirstOrDefaultAsync(x =>
                x.Id == dto.PurchaseOrderLineId &&
                x.PurchaseOrderId == dto.PurchaseOrderId);

        if (line is null)
            return NotFound("Purchase order line not found.");

        var receipt = new GoodsReceipt
        {
            PurchaseOrderId = dto.PurchaseOrderId,
            PurchaseOrderLineId = dto.PurchaseOrderLineId,
            ReceiptNumber = dto.ReceiptNumber,
            ReceivedQuantity = dto.ReceivedQuantity,
            ReceivedDate = dto.ReceivedDate,
            Remarks = dto.Remarks
        };

        _context.GoodsReceipts.Add(receipt);
        await _context.SaveChangesAsync();

        return Ok(receipt);
    }
}