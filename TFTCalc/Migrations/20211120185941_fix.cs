using Microsoft.EntityFrameworkCore.Migrations;

namespace TFTCalc.Migrations
{
    public partial class fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HeroAttributes_Hero_HeroId",
                table: "HeroAttributes");

            migrationBuilder.DropIndex(
                name: "IX_HeroAttributes_HeroId",
                table: "HeroAttributes");

            migrationBuilder.DropColumn(
                name: "HeroId",
                table: "HeroAttributes");

            migrationBuilder.CreateTable(
                name: "HeroHeroAttribute",
                columns: table => new
                {
                    AttributesId = table.Column<int>(type: "int", nullable: false),
                    HeroId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeroHeroAttribute", x => new { x.AttributesId, x.HeroId });
                    table.ForeignKey(
                        name: "FK_HeroHeroAttribute_Hero_HeroId",
                        column: x => x.HeroId,
                        principalTable: "Hero",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HeroHeroAttribute_HeroAttributes_AttributesId",
                        column: x => x.AttributesId,
                        principalTable: "HeroAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HeroHeroAttribute_HeroId",
                table: "HeroHeroAttribute",
                column: "HeroId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HeroHeroAttribute");

            migrationBuilder.AddColumn<int>(
                name: "HeroId",
                table: "HeroAttributes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_HeroAttributes_HeroId",
                table: "HeroAttributes",
                column: "HeroId");

            migrationBuilder.AddForeignKey(
                name: "FK_HeroAttributes_Hero_HeroId",
                table: "HeroAttributes",
                column: "HeroId",
                principalTable: "Hero",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
