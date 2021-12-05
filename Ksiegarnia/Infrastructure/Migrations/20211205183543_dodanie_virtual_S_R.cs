using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class dodanie_virtual_S_R : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Subscribers_user_id",
                table: "Subscribers",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_book_id",
                table: "Reviews",
                column: "book_id");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_user_id",
                table: "Reviews",
                column: "user_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Book_book_id",
                table: "Reviews",
                column: "book_id",
                principalTable: "Book",
                principalColumn: "book_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Users_user_id",
                table: "Reviews",
                column: "user_id",
                principalTable: "Users",
                principalColumn: "user_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subscribers_Users_user_id",
                table: "Subscribers",
                column: "user_id",
                principalTable: "Users",
                principalColumn: "user_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Book_book_id",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Users_user_id",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Subscribers_Users_user_id",
                table: "Subscribers");

            migrationBuilder.DropIndex(
                name: "IX_Subscribers_user_id",
                table: "Subscribers");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_book_id",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_user_id",
                table: "Reviews");
        }
    }
}
