using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotel_App.Migrations
{
    public partial class AddRentRoom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "RentRooms",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RentRooms_UserId",
                table: "RentRooms",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_RentRooms_AspNetUsers_UserId",
                table: "RentRooms",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RentRooms_AspNetUsers_UserId",
                table: "RentRooms");

            migrationBuilder.DropIndex(
                name: "IX_RentRooms_UserId",
                table: "RentRooms");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "RentRooms");
        }
    }
}
