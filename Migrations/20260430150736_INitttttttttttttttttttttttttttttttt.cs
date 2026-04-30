using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exam1Pronia.Migrations
{
    /// <inheritdoc />
    public partial class INitttttttttttttttttttttttttttttttt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SKU",
                table: "Review",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SKU",
                table: "Review");
        }
    }
}
