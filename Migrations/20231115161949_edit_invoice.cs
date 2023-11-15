using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel_Managements_System.Migrations
{
    /// <inheritdoc />
    public partial class edit_invoice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "password",
                table: "users");

            migrationBuilder.DropColumn(
                name: "detailid",
                table: "cart");

            migrationBuilder.RenameColumn(
                name: "userName",
                table: "users",
                newName: "phone");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "phone",
                table: "users",
                newName: "userName");

            migrationBuilder.AddColumn<string>(
                name: "password",
                table: "users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "detailid",
                table: "cart",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
