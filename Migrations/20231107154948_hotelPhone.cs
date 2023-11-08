using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel_Managements_System.Migrations
{
    /// <inheritdoc />
    public partial class hotelPhone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "phoone",
                table: "hotel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "phoone",
                table: "hotel");
        }
    }
}
