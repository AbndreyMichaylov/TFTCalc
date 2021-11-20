using Microsoft.EntityFrameworkCore.Migrations;

namespace TFTCalc.Migrations
{
    public partial class fix4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComboItem_HeroAttributes_AttributeId",
                table: "ComboItem");

            migrationBuilder.DropIndex(
                name: "IX_ComboItem_AttributeId",
                table: "ComboItem");

            migrationBuilder.DropColumn(
                name: "AttributeId",
                table: "ComboItem");

            migrationBuilder.CreateTable(
                name: "ComboItemHeroAttribute",
                columns: table => new
                {
                    ComboItemsId = table.Column<int>(type: "int", nullable: false),
                    HeroAttributeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComboItemHeroAttribute", x => new { x.ComboItemsId, x.HeroAttributeId });
                    table.ForeignKey(
                        name: "FK_ComboItemHeroAttribute_ComboItem_ComboItemsId",
                        column: x => x.ComboItemsId,
                        principalTable: "ComboItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComboItemHeroAttribute_HeroAttributes_HeroAttributeId",
                        column: x => x.HeroAttributeId,
                        principalTable: "HeroAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ComboItemHeroAttribute_HeroAttributeId",
                table: "ComboItemHeroAttribute",
                column: "HeroAttributeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComboItemHeroAttribute");

            migrationBuilder.AddColumn<int>(
                name: "AttributeId",
                table: "ComboItem",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ComboItem_AttributeId",
                table: "ComboItem",
                column: "AttributeId");

            migrationBuilder.AddForeignKey(
                name: "FK_ComboItem_HeroAttributes_AttributeId",
                table: "ComboItem",
                column: "AttributeId",
                principalTable: "HeroAttributes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
