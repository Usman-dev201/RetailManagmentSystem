using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RMS.Migrations
{
    /// <inheritdoc />
    public partial class rms4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TransactionId",
                table: "SalesCommissionAgents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "SalesCommissionAgents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SalesCommissionAgents_TransactionId",
                table: "SalesCommissionAgents",
                column: "TransactionId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesCommissionAgents_UserId",
                table: "SalesCommissionAgents",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesCommissionAgents_SalesTransactions_TransactionId",
                table: "SalesCommissionAgents",
                column: "TransactionId",
                principalTable: "SalesTransactions",
                principalColumn: "TransactionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SalesCommissionAgents_Users_UserId",
                table: "SalesCommissionAgents",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesCommissionAgents_SalesTransactions_TransactionId",
                table: "SalesCommissionAgents");

            migrationBuilder.DropForeignKey(
                name: "FK_SalesCommissionAgents_Users_UserId",
                table: "SalesCommissionAgents");

            migrationBuilder.DropIndex(
                name: "IX_SalesCommissionAgents_TransactionId",
                table: "SalesCommissionAgents");

            migrationBuilder.DropIndex(
                name: "IX_SalesCommissionAgents_UserId",
                table: "SalesCommissionAgents");

            migrationBuilder.DropColumn(
                name: "TransactionId",
                table: "SalesCommissionAgents");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "SalesCommissionAgents");
        }
    }
}
