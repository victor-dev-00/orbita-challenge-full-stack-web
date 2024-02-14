using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace grupoaApi.Migrations
{
    /// <inheritdoc />
    public partial class fist : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Ra", "Cpf", "Email", "Name" },
                values: new object[] { 1, "12345678910", "qBc3w@example.com", "Victor" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Ra",
                keyValue: 1);
        }
    }
}
