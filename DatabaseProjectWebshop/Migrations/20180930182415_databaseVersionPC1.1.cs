using Microsoft.EntityFrameworkCore.Migrations;

namespace DatabaseProjectWebshop.Migrations
{
    public partial class databaseVersionPC11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MainCategory",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubCategory",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "URL",
                table: "Products",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MainCategory",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SubCategory",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "URL",
                table: "Products");
        }
    }
}
