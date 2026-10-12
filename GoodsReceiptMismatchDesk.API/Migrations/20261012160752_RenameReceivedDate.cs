using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoodsReceiptMismatchDesk.API.Migrations
{
    /// <inheritdoc />
    public partial class RenameReceivedDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReveivedDate",
                table: "GoodsReceipts",
                newName: "ReceivedDate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReceivedDate",
                table: "GoodsReceipts",
                newName: "ReveivedDate");
        }
    }
}
