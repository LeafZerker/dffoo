using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dffoo.Server.Migrations
{
    public partial class champdetails2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Champions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BT", "ChampClevel", "ChampSphere1", "ChampSphere2", "ChampSphere3", "EX", "HG35", "HG7star", "HG7starPlus", "HG90", "HG90plus", "LD", "W15cp", "W35cp" },
                values: new object[] { true, 80, "A", "B", "D", true, true, true, true, true, true, true, true, true });

            migrationBuilder.UpdateData(
                table: "Champions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BT", "ChampClevel", "ChampSphere1", "ChampSphere2", "ChampSphere3", "EX", "HG35", "HG7star", "HG7starPlus", "HG90", "HG90plus", "LD", "W15cp", "W35cp" },
                values: new object[] { true, 80, "A", "B", "D", true, true, true, true, true, true, true, true, true });

            migrationBuilder.UpdateData(
                table: "Champions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BT", "ChampClevel", "ChampSphere1", "ChampSphere2", "ChampSphere3", "EX", "HG35", "HG7star", "HG7starPlus", "HG90", "HG90plus", "LD", "W15cp", "W35cp" },
                values: new object[] { true, 80, "A", "B", "D", true, true, true, true, true, true, true, true, true });

            migrationBuilder.UpdateData(
                table: "Champions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BT", "ChampClevel", "ChampSphere1", "ChampSphere2", "ChampSphere3", "EX", "HG35", "HG7star", "HG7starPlus", "HG90", "HG90plus", "LD", "W15cp", "W35cp" },
                values: new object[] { true, 80, "A", "B", "D", true, true, true, true, true, true, true, true, true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Champions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BT", "ChampClevel", "ChampSphere1", "ChampSphere2", "ChampSphere3", "EX", "HG35", "HG7star", "HG7starPlus", "HG90", "HG90plus", "LD", "W15cp", "W35cp" },
                values: new object[] { false, 0, "", "", "", false, false, false, false, false, false, false, false, false });

            migrationBuilder.UpdateData(
                table: "Champions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BT", "ChampClevel", "ChampSphere1", "ChampSphere2", "ChampSphere3", "EX", "HG35", "HG7star", "HG7starPlus", "HG90", "HG90plus", "LD", "W15cp", "W35cp" },
                values: new object[] { false, 0, "", "", "", false, false, false, false, false, false, false, false, false });

            migrationBuilder.UpdateData(
                table: "Champions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BT", "ChampClevel", "ChampSphere1", "ChampSphere2", "ChampSphere3", "EX", "HG35", "HG7star", "HG7starPlus", "HG90", "HG90plus", "LD", "W15cp", "W35cp" },
                values: new object[] { false, 0, "", "", "", false, false, false, false, false, false, false, false, false });

            migrationBuilder.UpdateData(
                table: "Champions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BT", "ChampClevel", "ChampSphere1", "ChampSphere2", "ChampSphere3", "EX", "HG35", "HG7star", "HG7starPlus", "HG90", "HG90plus", "LD", "W15cp", "W35cp" },
                values: new object[] { false, 0, "", "", "", false, false, false, false, false, false, false, false, false });
        }
    }
}
