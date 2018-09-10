using Microsoft.EntityFrameworkCore.Migrations;

namespace EFNew.Migrations
{
    public partial class Color : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Fruits",
                nullable: true);
        }

       
    }
}
