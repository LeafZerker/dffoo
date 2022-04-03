using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dffoo.Server.Migrations
{
    public partial class champdetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Champions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.RenameColumn(
                name: "mBRV",
                table: "Champions",
                newName: "MBRV");

            migrationBuilder.RenameColumn(
                name: "iBRV",
                table: "Champions",
                newName: "IBRV");

            migrationBuilder.AddColumn<bool>(
                name: "BT",
                table: "Champions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "BTplus",
                table: "Champions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ChampClevel",
                table: "Champions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ChampSphere1",
                table: "Champions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ChampSphere2",
                table: "Champions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ChampSphere3",
                table: "Champions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "EX",
                table: "Champions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "EXplus",
                table: "Champions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HG35",
                table: "Champions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HG7star",
                table: "Champions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HG7starPlus",
                table: "Champions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HG90",
                table: "Champions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HG90plus",
                table: "Champions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LD",
                table: "Champions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "W15cp",
                table: "Champions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "W35cp",
                table: "Champions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Champions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ChampSphere1", "ChampSphere2", "ChampSphere3" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Champions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ChampSphere1", "ChampSphere2", "ChampSphere3" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Champions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ChampSphere1", "ChampSphere2", "ChampSphere3" },
                values: new object[] { "", "", "" });

            migrationBuilder.InsertData(
                table: "Champions",
                columns: new[] { "Id", "ATK", "BT", "BTplus", "ChampClevel", "ChampCrystal", "ChampName", "ChampSphere1", "ChampSphere2", "ChampSphere3", "ChampType", "DEF", "EX", "EXplus", "GameId", "HG35", "HG7star", "HG7starPlus", "HG90", "HG90plus", "HP", "IBRV", "LD", "MBRV", "W15cp", "W35cp" },
                values: new object[] { 4, 3517, false, false, 0, "Black", "Garnet", "", "", "", "Staff", 6024, false, false, 9, false, false, false, false, false, 13955, 5081, false, 10262, false, false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Champions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "BT",
                table: "Champions");

            migrationBuilder.DropColumn(
                name: "BTplus",
                table: "Champions");

            migrationBuilder.DropColumn(
                name: "ChampClevel",
                table: "Champions");

            migrationBuilder.DropColumn(
                name: "ChampSphere1",
                table: "Champions");

            migrationBuilder.DropColumn(
                name: "ChampSphere2",
                table: "Champions");

            migrationBuilder.DropColumn(
                name: "ChampSphere3",
                table: "Champions");

            migrationBuilder.DropColumn(
                name: "EX",
                table: "Champions");

            migrationBuilder.DropColumn(
                name: "EXplus",
                table: "Champions");

            migrationBuilder.DropColumn(
                name: "HG35",
                table: "Champions");

            migrationBuilder.DropColumn(
                name: "HG7star",
                table: "Champions");

            migrationBuilder.DropColumn(
                name: "HG7starPlus",
                table: "Champions");

            migrationBuilder.DropColumn(
                name: "HG90",
                table: "Champions");

            migrationBuilder.DropColumn(
                name: "HG90plus",
                table: "Champions");

            migrationBuilder.DropColumn(
                name: "LD",
                table: "Champions");

            migrationBuilder.DropColumn(
                name: "W15cp",
                table: "Champions");

            migrationBuilder.DropColumn(
                name: "W35cp",
                table: "Champions");

            migrationBuilder.RenameColumn(
                name: "MBRV",
                table: "Champions",
                newName: "mBRV");

            migrationBuilder.RenameColumn(
                name: "IBRV",
                table: "Champions",
                newName: "iBRV");

            migrationBuilder.InsertData(
                table: "Champions",
                columns: new[] { "Id", "ATK", "ChampCrystal", "ChampName", "ChampType", "DEF", "GameId", "HP", "iBRV", "mBRV" },
                values: new object[] { 5, 3517, "Black", "Garnet", "Staff", 6024, 9, 13955, 5081, 10262 });
        }
    }
}
