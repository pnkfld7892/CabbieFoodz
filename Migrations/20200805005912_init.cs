using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CabbieFoodz.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cabbies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    Description = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cabbies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Foodz",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    Description = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foodz", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FoodInCabbies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Qty = table.Column<int>(nullable: false),
                    FoodzId = table.Column<int>(nullable: false),
                    FoodId = table.Column<int>(nullable: true),
                    CabbieId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodInCabbies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FoodInCabbies_Cabbies_CabbieId",
                        column: x => x.CabbieId,
                        principalTable: "Cabbies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodInCabbies_Foodz_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Foodz",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FoodInCabbies_CabbieId",
                table: "FoodInCabbies",
                column: "CabbieId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodInCabbies_FoodId",
                table: "FoodInCabbies",
                column: "FoodId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodInCabbies");

            migrationBuilder.DropTable(
                name: "Cabbies");

            migrationBuilder.DropTable(
                name: "Foodz");
        }
    }
}
