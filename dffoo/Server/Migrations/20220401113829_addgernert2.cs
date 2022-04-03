using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dffoo.Server.Migrations
{
    public partial class addgernert2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Champions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.InsertData(
                table: "Champions",
                columns: new[] { "Id", "ATK", "ChampCrystal", "ChampName", "ChampType", "DEF", "GameId", "HP", "iBRV", "mBRV" },
                values: new object[] { 5, 3517, "Black", "Garnet", "Staff", 6024, 9, 13955, 5081, 10262 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Champions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.InsertData(
                table: "Champions",
                columns: new[] { "Id", "ATK", "ChampCrystal", "ChampName", "ChampType", "DEF", "GameId", "HP", "iBRV", "mBRV" },
                values: new object[] { 4, 3517, "Black", "Garnet", "Staff", 6024, 9, 13955, 5081, 10262 });
        }
    }
}
