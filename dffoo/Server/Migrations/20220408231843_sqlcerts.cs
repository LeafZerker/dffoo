using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dffoo.Server.Migrations
{
    public partial class sqlcerts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    birthday = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Email);
                });

            migrationBuilder.CreateTable(
                name: "Champions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChampName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChampType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChampCrystal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChampClevel = table.Column<int>(type: "int", nullable: false),
                    ChampSphere1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChampSphere2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChampSphere3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    W15cp = table.Column<bool>(type: "bit", nullable: false),
                    W35cp = table.Column<bool>(type: "bit", nullable: false),
                    EX = table.Column<bool>(type: "bit", nullable: false),
                    EXplus = table.Column<bool>(type: "bit", nullable: false),
                    LD = table.Column<bool>(type: "bit", nullable: false),
                    BT = table.Column<bool>(type: "bit", nullable: false),
                    BTplus = table.Column<bool>(type: "bit", nullable: false),
                    HG35 = table.Column<bool>(type: "bit", nullable: false),
                    HG90 = table.Column<bool>(type: "bit", nullable: false),
                    HG90plus = table.Column<bool>(type: "bit", nullable: false),
                    HG7star = table.Column<bool>(type: "bit", nullable: false),
                    HG7starPlus = table.Column<bool>(type: "bit", nullable: false),
                    HP = table.Column<int>(type: "int", nullable: false),
                    IBRV = table.Column<int>(type: "int", nullable: false),
                    MBRV = table.Column<int>(type: "int", nullable: false),
                    ATK = table.Column<int>(type: "int", nullable: false),
                    DEF = table.Column<int>(type: "int", nullable: false),
                    GameId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Champions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Champions_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Final Fantasy 1" },
                    { 2, "Final Fantasy 2" },
                    { 3, "Final Fantasy 3" },
                    { 4, "Final Fantasy 4" },
                    { 5, "Final Fantasy 5" },
                    { 6, "Final Fantasy 6" },
                    { 7, "Final Fantasy 7" },
                    { 8, "Final Fantasy 8" },
                    { 9, "Final Fantasy 9" },
                    { 10, "Final Fantasy 10" },
                    { 11, "Final Fantasy 11" },
                    { 12, "Final Fantasy 12" },
                    { 13, "Final Fantasy 13" },
                    { 14, "Final Fantasy 14" },
                    { 15, "Final Fantasy 15" },
                    { 16, "Final Fantasy Crystal Chronicles" },
                    { 17, "Final Fantasy Type-0" },
                    { 18, "World Of Final Fantasy" },
                    { 19, "Final Fantasy Tactics" }
                });

            migrationBuilder.InsertData(
                table: "Champions",
                columns: new[] { "Id", "ATK", "BT", "BTplus", "ChampClevel", "ChampCrystal", "ChampName", "ChampSphere1", "ChampSphere2", "ChampSphere3", "ChampType", "DEF", "EX", "EXplus", "GameId", "HG35", "HG7star", "HG7starPlus", "HG90", "HG90plus", "HP", "IBRV", "LD", "MBRV", "W15cp", "W35cp" },
                values: new object[,]
                {
                    { 1, 3517, true, false, 80, "White", "Warrior Of Light", "A", "B", "D", "Sword", 6024, true, false, 1, true, true, true, true, true, 13955, 5081, true, 10262, true, true },
                    { 2, 3517, true, false, 80, "Black", "Vivi", "A", "B", "D", "Staff", 6024, true, false, 9, true, true, true, true, true, 13955, 5081, true, 10262, true, true },
                    { 3, 3517, true, false, 80, "Green", "Rem", "A", "B", "D", "Dagger", 6024, true, false, 17, true, true, true, true, true, 13955, 5081, true, 10262, true, true },
                    { 4, 3517, true, false, 80, "Black", "Garnet", "A", "B", "D", "Staff", 6024, true, false, 9, true, true, true, true, true, 13955, 5081, true, 10262, true, true }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Champions_GameId",
                table: "Champions",
                column: "GameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Champions");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
