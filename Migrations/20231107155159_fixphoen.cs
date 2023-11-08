using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel_Managements_System.Migrations
{
    /// <inheritdoc />
    public partial class fixphoen : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "phoone",
                table: "hotel",
                newName: "phone");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "phone",
                table: "hotel",
                newName: "phoone");
        }
    }
}
