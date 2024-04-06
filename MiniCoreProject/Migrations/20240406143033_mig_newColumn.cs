using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiniCoreProject.Migrations
{
    public partial class mig_newColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Header",
                table: "Experiences",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Header",
                table: "Experiences");
        }
    }
}
