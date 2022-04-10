using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dffoo.Server.Migrations
{
    public partial class typo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Champions",
                keyColumn: "Id",
                keyValue: 40,
                column: "ChampName",
                value: "Ramza");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Champions",
                keyColumn: "Id",
                keyValue: 40,
                column: "ChampName",
                value: "Razma");
        }
    }
}
