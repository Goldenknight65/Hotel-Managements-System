using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel_Managements_System.Migrations
{
    /// <inheritdoc />
    public partial class removetableRoomDetail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "roomDetails");

            migrationBuilder.AddColumn<string>(
                name: "feature",
                table: "rooms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "food",
                table: "rooms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "feature",
                table: "rooms");

            migrationBuilder.DropColumn(
                name: "food",
                table: "rooms");

            migrationBuilder.CreateTable(
                name: "roomDetails",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    feature = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    food = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    roomid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roomDetails", x => x.id);
                });
        }
    }
}
