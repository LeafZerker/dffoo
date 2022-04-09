using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dffoo.Server.Migrations
{
    public partial class _10percentchars : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Champions",
                columns: new[] { "Id", "ATK", "BT", "BTplus", "ChampClevel", "ChampCrystal", "ChampName", "ChampSphere1", "ChampSphere2", "ChampSphere3", "ChampType", "DEF", "EX", "EXplus", "GameId", "HG35", "HG7star", "HG7starPlus", "HG90", "HG90plus", "HP", "IBRV", "LD", "MBRV", "W15cp", "W35cp" },
                values: new object[,]
                {
                    { 9, 3533, true, true, 80, "blue", "Zidane", "A", "E", "E", "dagger", 5029, true, false, 9, true, true, true, true, true, 13243, 4147, true, 11237, true, true },
                    { 10, 3592, false, false, 90, "Black", "Cecil (Dark Knight)", "A", "C", "E", "Greatsword", 5029, true, false, 4, true, true, true, true, true, 15644, 3850, true, 10449, true, true },
                    { 11, 3568, false, false, 80, "Green", "Yda", "A", "A", "E", "fist", 5037, true, false, 14, true, true, true, true, true, 13180, 4037, true, 11372, true, true },
                    { 12, 3590, true, false, 80, "Red", "Vaan", "A", "A", "E", "Sword", 5113, true, false, 12, true, true, true, true, true, 12483, 4663, true, 12266, true, true },
                    { 13, 3466, false, false, 80, "Red", "Yuffie", "D", "E", "E", "shuriken", 5029, true, false, 7, true, true, true, true, true, 13252, 4339, true, 12081, true, true },
                    { 14, 3394, false, false, 80, "White", "Yuna", "C", "C", "D", "Staff", 5650, true, false, 10, true, true, true, true, true, 15074, 5063, true, 9558, true, true },
                    { 15, 3461, false, false, 80, "Blue", "Edge", "A", "B", "D", "Dagger", 4533, true, false, 4, true, true, false, true, true, 13202, 4810, false, 11152, true, true }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Champions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Champions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Champions",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Champions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Champions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Champions",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Champions",
                keyColumn: "Id",
                keyValue: 15);
        }
    }
}
