using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RMS.Migrations
{
    /// <inheritdoc />
    public partial class rms3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesCommissionAgents_SalesTransactions_TransactionId",
                table: "SalesCommissionAgents");

            migrationBuilder.RenameColumn(
                name: "TransactionId",
                table: "SalesCommissionAgents",
                newName: "TransactionDetailId");

            migrationBuilder.RenameIndex(
                name: "IX_SalesCommissionAgents_TransactionId",
                table: "SalesCommissionAgents",
                newName: "IX_SalesCommissionAgents_TransactionDetailId");

            migrationBuilder.AddColumn<int>(
                name: "SalesTransactionTransactionId",
                table: "SalesCommissionAgents",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SalesCommissionAgents_SalesTransactionTransactionId",
                table: "SalesCommissionAgents",
                column: "SalesTransactionTransactionId");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesCommissionAgents_SalesTransactionDetails_TransactionDetailId",
                table: "SalesCommissionAgents",
                column: "TransactionDetailId",
                principalTable: "SalesTransactionDetails",
                principalColumn: "TransactionDetailId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SalesCommissionAgents_SalesTransactions_SalesTransactionTransactionId",
                table: "SalesCommissionAgents",
                column: "SalesTransactionTransactionId",
                principalTable: "SalesTransactions",
                principalColumn: "TransactionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesCommissionAgents_SalesTransactionDetails_TransactionDetailId",
                table: "SalesCommissionAgents");

            migrationBuilder.DropForeignKey(
                name: "FK_SalesCommissionAgents_SalesTransactions_SalesTransactionTransactionId",
                table: "SalesCommissionAgents");

            migrationBuilder.DropIndex(
                name: "IX_SalesCommissionAgents_SalesTransactionTransactionId",
                table: "SalesCommissionAgents");

            migrationBuilder.DropColumn(
                name: "SalesTransactionTransactionId",
                table: "SalesCommissionAgents");

            migrationBuilder.RenameColumn(
                name: "TransactionDetailId",
                table: "SalesCommissionAgents",
                newName: "TransactionId");

            migrationBuilder.RenameIndex(
                name: "IX_SalesCommissionAgents_TransactionDetailId",
                table: "SalesCommissionAgents",
                newName: "IX_SalesCommissionAgents_TransactionId");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesCommissionAgents_SalesTransactions_TransactionId",
                table: "SalesCommissionAgents",
                column: "TransactionId",
                principalTable: "SalesTransactions",
                principalColumn: "TransactionId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
