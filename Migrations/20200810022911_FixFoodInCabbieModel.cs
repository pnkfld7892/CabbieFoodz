using Microsoft.EntityFrameworkCore.Migrations;

namespace CabbieFoodz.Migrations
{
    public partial class FixFoodInCabbieModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodInCabbies_Foodz_FoodId",
                table: "FoodInCabbies");

            migrationBuilder.DropColumn(
                name: "FoodzId",
                table: "FoodInCabbies");

            migrationBuilder.AlterColumn<int>(
                name: "FoodId",
                table: "FoodInCabbies",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodInCabbies_Foodz_FoodId",
                table: "FoodInCabbies",
                column: "FoodId",
                principalTable: "Foodz",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodInCabbies_Foodz_FoodId",
                table: "FoodInCabbies");

            migrationBuilder.AlterColumn<int>(
                name: "FoodId",
                table: "FoodInCabbies",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "FoodzId",
                table: "FoodInCabbies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodInCabbies_Foodz_FoodId",
                table: "FoodInCabbies",
                column: "FoodId",
                principalTable: "Foodz",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
