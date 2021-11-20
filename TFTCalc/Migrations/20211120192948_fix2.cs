using Microsoft.EntityFrameworkCore.Migrations;

namespace TFTCalc.Migrations
{
    public partial class fix2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Combo_Combo_ComboId",
                table: "Combo");

            migrationBuilder.DropIndex(
                name: "IX_Combo_ComboId",
                table: "Combo");

            migrationBuilder.DropColumn(
                name: "ComboId",
                table: "Combo");

            migrationBuilder.AddColumn<int>(
                name: "ComboId",
                table: "ComboItem",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ComboItem_ComboId",
                table: "ComboItem",
                column: "ComboId");

            migrationBuilder.AddForeignKey(
                name: "FK_ComboItem_Combo_ComboId",
                table: "ComboItem",
                column: "ComboId",
                principalTable: "Combo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComboItem_Combo_ComboId",
                table: "ComboItem");

            migrationBuilder.DropIndex(
                name: "IX_ComboItem_ComboId",
                table: "ComboItem");

            migrationBuilder.DropColumn(
                name: "ComboId",
                table: "ComboItem");

            migrationBuilder.AddColumn<int>(
                name: "ComboId",
                table: "Combo",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Combo_ComboId",
                table: "Combo",
                column: "ComboId");

            migrationBuilder.AddForeignKey(
                name: "FK_Combo_Combo_ComboId",
                table: "Combo",
                column: "ComboId",
                principalTable: "Combo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
