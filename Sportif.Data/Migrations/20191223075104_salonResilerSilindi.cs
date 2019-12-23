using Microsoft.EntityFrameworkCore.Migrations;

namespace Sportif.Data.Migrations
{
    public partial class salonResilerSilindi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SalonImages");

            migrationBuilder.DropColumn(
                name: "BranchID",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserID",
                table: "TrainerComments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Salons",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsSlider",
                table: "Salons",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserID",
                table: "SalonComments",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SalonID",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TrainerComments_ApplicationUserID",
                table: "TrainerComments",
                column: "ApplicationUserID");

            migrationBuilder.CreateIndex(
                name: "IX_SalonComments_ApplicationUserID",
                table: "SalonComments",
                column: "ApplicationUserID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_SalonID",
                table: "AspNetUsers",
                column: "SalonID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Salons_SalonID",
                table: "AspNetUsers",
                column: "SalonID",
                principalTable: "Salons",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SalonComments_AspNetUsers_ApplicationUserID",
                table: "SalonComments",
                column: "ApplicationUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainerComments_AspNetUsers_ApplicationUserID",
                table: "TrainerComments",
                column: "ApplicationUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Salons_SalonID",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_SalonComments_AspNetUsers_ApplicationUserID",
                table: "SalonComments");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainerComments_AspNetUsers_ApplicationUserID",
                table: "TrainerComments");

            migrationBuilder.DropIndex(
                name: "IX_TrainerComments_ApplicationUserID",
                table: "TrainerComments");

            migrationBuilder.DropIndex(
                name: "IX_SalonComments_ApplicationUserID",
                table: "SalonComments");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_SalonID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ApplicationUserID",
                table: "TrainerComments");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Salons");

            migrationBuilder.DropColumn(
                name: "IsSlider",
                table: "Salons");

            migrationBuilder.DropColumn(
                name: "ApplicationUserID",
                table: "SalonComments");

            migrationBuilder.DropColumn(
                name: "SalonID",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "BranchID",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SalonImages",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OnSlider = table.Column<bool>(type: "bit", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SalonID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalonImages", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SalonImages_Salons_SalonID",
                        column: x => x.SalonID,
                        principalTable: "Salons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SalonImages_SalonID",
                table: "SalonImages",
                column: "SalonID");
        }
    }
}
