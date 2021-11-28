using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    postal_code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    city = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.postal_code);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    user_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    postal_code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Citypostal_code = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    lastname = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    username = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    email = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    address = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    password = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.user_id);
                    table.ForeignKey(
                        name: "FK_User_City_Citypostal_code",
                        column: x => x.Citypostal_code,
                        principalTable: "City",
                        principalColumn: "postal_code");
                });

            migrationBuilder.CreateIndex(
                name: "IX_User_Citypostal_code",
                table: "User",
                column: "Citypostal_code");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "City");
        }
    }
}
