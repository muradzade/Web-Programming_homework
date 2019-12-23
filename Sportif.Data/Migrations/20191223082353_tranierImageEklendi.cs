using Microsoft.EntityFrameworkCore.Migrations;

namespace Sportif.Data.Migrations
{
    public partial class tranierImageEklendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Trainers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Trainers");
        }
    }
}
