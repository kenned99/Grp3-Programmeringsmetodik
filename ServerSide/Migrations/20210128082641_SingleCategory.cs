using Microsoft.EntityFrameworkCore.Migrations;

namespace ServerSide.Migrations
{
    public partial class SingleCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_Drinks_DrinkId",
                table: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Category_DrinkId",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "DrinkId",
                table: "Category");

            migrationBuilder.AddColumn<string>(
                name: "CategoryId",
                table: "Drinks",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Drinks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Drinks_CategoryId",
                table: "Drinks",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Drinks_Category_CategoryId",
                table: "Drinks",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Drinks_Category_CategoryId",
                table: "Drinks");

            migrationBuilder.DropIndex(
                name: "IX_Drinks_CategoryId",
                table: "Drinks");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Drinks");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Drinks");

            migrationBuilder.AddColumn<string>(
                name: "DrinkId",
                table: "Category",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Category_DrinkId",
                table: "Category",
                column: "DrinkId");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Drinks_DrinkId",
                table: "Category",
                column: "DrinkId",
                principalTable: "Drinks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
