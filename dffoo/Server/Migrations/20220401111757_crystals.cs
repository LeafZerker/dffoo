﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dffoo.Server.Migrations
{
    public partial class crystals : Migration
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
                name: "Champions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChampName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChampType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChampCrystal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HP = table.Column<int>(type: "int", nullable: false),
                    iBRV = table.Column<int>(type: "int", nullable: false),
                    mBRV = table.Column<int>(type: "int", nullable: false),
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
                columns: new[] { "Id", "ATK", "ChampCrystal", "ChampName", "ChampType", "DEF", "GameId", "HP", "iBRV", "mBRV" },
                values: new object[] { 1, 3517, "White", "Warrior Of Light", "Sword", 6024, 1, 13955, 5081, 10262 });

            migrationBuilder.InsertData(
                table: "Champions",
                columns: new[] { "Id", "ATK", "ChampCrystal", "ChampName", "ChampType", "DEF", "GameId", "HP", "iBRV", "mBRV" },
                values: new object[] { 2, 3517, "Black", "Vivi", "Staff", 6024, 9, 13955, 5081, 10262 });

            migrationBuilder.InsertData(
                table: "Champions",
                columns: new[] { "Id", "ATK", "ChampCrystal", "ChampName", "ChampType", "DEF", "GameId", "HP", "iBRV", "mBRV" },
                values: new object[] { 3, 3517, "Green", "Rem", "Dagger", 6024, 17, 13955, 5081, 10262 });

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
                name: "Games");
        }
    }
}