using Microsoft.EntityFrameworkCore.Migrations;

namespace EchoposCRUD.Migrations
{
    public partial class mg_v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "updatedData",
                table: "Products",
                newName: "updatedDate");

            migrationBuilder.RenameColumn(
                name: "createdData",
                table: "Products",
                newName: "createdDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "updatedDate",
                table: "Products",
                newName: "updatedData");

            migrationBuilder.RenameColumn(
                name: "createdDate",
                table: "Products",
                newName: "createdData");
        }
    }
}
