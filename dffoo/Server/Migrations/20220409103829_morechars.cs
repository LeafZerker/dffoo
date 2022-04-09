using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dffoo.Server.Migrations
{
    public partial class morechars : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Champions",
                keyColumn: "Id",
                keyValue: 2,
                column: "ChampClevel",
                value: 90);

            migrationBuilder.UpdateData(
                table: "Champions",
                keyColumn: "Id",
                keyValue: 3,
                column: "ChampClevel",
                value: 90);

            migrationBuilder.UpdateData(
                table: "Champions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BT", "ChampCrystal", "ChampName", "ChampType", "GameId" },
                values: new object[] { false, "Red", "Sazh", "Gun", 13 });

            migrationBuilder.InsertData(
                table: "Champions",
                columns: new[] { "Id", "ATK", "BT", "BTplus", "ChampClevel", "ChampCrystal", "ChampName", "ChampSphere1", "ChampSphere2", "ChampSphere3", "ChampType", "DEF", "EX", "EXplus", "GameId", "HG35", "HG7star", "HG7starPlus", "HG90", "HG90plus", "HP", "IBRV", "LD", "MBRV", "W15cp", "W35cp" },
                values: new object[,]
                {
                    { 5, 3532, false, false, 90, "Yellow", "Tifa", "A", "A", "D", "fist", 5116, true, false, 7, true, true, true, true, true, 12508, 4339, true, 11475, true, true },
                    { 6, 3759, true, true, 90, "Blue", "Cloud", "A", "D", "E", "Greatsword", 5029, true, false, 7, true, true, true, true, true, 13171, 4355, true, 11314, true, true },
                    { 7, 3497, false, false, 80, "White", "Hope", "B", "c", "D", "shuriken", 5029, true, false, 13, true, true, true, true, true, 13259, 4810, true, 11133, true, true },
                    { 8, 3482, true, true, 80, "Yellow", "Yshtola", "C", "C", "E", "staff", 5340, true, false, 14, true, true, true, true, true, 14018, 5136, true, 10276, true, true },
                    { 58, 3517, true, false, 90, "Black", "Garnet", "A", "B", "D", "Staff", 6024, true, false, 9, true, true, true, true, true, 13955, 5081, true, 10262, true, true }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Champions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Champions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Champions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Champions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Champions",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.UpdateData(
                table: "Champions",
                keyColumn: "Id",
                keyValue: 2,
                column: "ChampClevel",
                value: 80);

            migrationBuilder.UpdateData(
                table: "Champions",
                keyColumn: "Id",
                keyValue: 3,
                column: "ChampClevel",
                value: 80);

            migrationBuilder.UpdateData(
                table: "Champions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BT", "ChampCrystal", "ChampName", "ChampType", "GameId" },
                values: new object[] { true, "Black", "Garnet", "Staff", 9 });
        }
    }
}
