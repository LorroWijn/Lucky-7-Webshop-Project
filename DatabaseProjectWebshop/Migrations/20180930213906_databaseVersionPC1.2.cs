using Microsoft.EntityFrameworkCore.Migrations;

namespace DatabaseProjectWebshop.Migrations
{
    public partial class databaseVersionPC12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "ProductPrice",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ProductPrice",
                table: "Products",
                nullable: false,
                oldClrType: typeof(float));
        }
    }
}
