using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dffoo.Server.Migrations
{
    public partial class initial : Migration
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
                name: "Sphere",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Letter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChampionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sphere", x => x.Id);
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
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    ManikinWeapon = table.Column<bool>(type: "bit", nullable: false),
                    UltimaWeapon = table.Column<bool>(type: "bit", nullable: false),
                    HP = table.Column<int>(type: "int", nullable: false),
                    IBRV = table.Column<int>(type: "int", nullable: false),
                    MBRV = table.Column<int>(type: "int", nullable: false),
                    ATK = table.Column<int>(type: "int", nullable: false),
                    DEF = table.Column<int>(type: "int", nullable: false),
                    MaxCP = table.Column<int>(type: "int", nullable: true),
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

            migrationBuilder.CreateTable(
                name: "Ability",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DmgPercentage = table.Column<int>(type: "int", nullable: false),
                    CPCost = table.Column<int>(type: "int", nullable: false),
                    SkillID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChampionId = table.Column<int>(type: "int", nullable: true),
                    ChampId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ability", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ability_Champions_ChampionId",
                        column: x => x.ChampionId,
                        principalTable: "Champions",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Ability",
                columns: new[] { "Id", "CPCost", "ChampId", "ChampionId", "Description", "DmgPercentage", "Name", "SkillID" },
                values: new object[,]
                {
                    { 1, 0, null, null, "Attacks the targets BRV", 100, "Brv Attack", "" },
                    { 2, 0, null, null, "Attacks the targets HP", 100, "HP Attack", "" },
                    { 3, 0, 34, null, "3-hit Melee BRV attack. High turn rate", 105, "Quick Hit", "S1" },
                    { 4, 0, 34, null, "2-Hit Melee BRV attack. Target: Fair chance 5 turns SPD Down I", 120, "Slash", "S2" },
                    { 5, 0, 34, null, "2-hit Melee BRV attack + HP attack. Extends own buffs 2 turns", 150, "Buff Longer Slash", "AA" },
                    { 6, 0, 34, null, "6-hit group ranged BRV attack + group HP attack. BRV attacks distributed based on number of enemies. Deals total HP damage to each target. Self: 5 turns ATK Up II, SPD Up I", 390, "Energy Rain", "EX" }
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
                table: "Sphere",
                columns: new[] { "Id", "ChampionId", "Description", "Letter", "Name" },
                values: new object[,]
                {
                    { 1, 34, "When inflicting Break or attacking target afflicted with Break while own HP at MAX: Inflicts 6 turns SPD Down 20% on selected target", "E", "Full HP Break Hit Speed Down" },
                    { 2, 16, "Raises own Atk by 20% for 3 turns when inflicting Break. Does not stack with same Sphere", "A", "Break Attack Up Shorter" },
                    { 3, 65, "When inflicting Break or attacking target afflicted with Break: Raises own PHY ATK by 15% for 6 Turns", "A", "Break Hit Physical Attack Up Longer" },
                    { 4, 42, "When inflicting debuff on target: Raises own ATK by 3% up to 5 times, once per turn", "E", "Debuff Success Raging Attack" }
                });

            migrationBuilder.InsertData(
                table: "Champions",
                columns: new[] { "Id", "ATK", "BT", "BTplus", "ChampClevel", "ChampCrystal", "ChampName", "ChampSphere1", "ChampSphere2", "ChampSphere3", "ChampType", "DEF", "EX", "EXplus", "GameId", "HG35", "HG7star", "HG7starPlus", "HG90", "HG90plus", "HP", "IBRV", "LD", "MBRV", "ManikinWeapon", "MaxCP", "UltimaWeapon", "W15cp", "W35cp" },
                values: new object[,]
                {
                    { 1, 3517, true, false, 80, "White", "Warrior Of Light", "A", "B", "C", "Sword", 6024, true, false, 1, true, true, true, true, true, 13955, 5081, true, 10262, false, null, false, true, true },
                    { 2, 3517, true, false, 90, "Black", "Vivi", "A", "B", "C", "Staff", 6024, true, false, 9, true, true, true, true, true, 13955, 5081, true, 10262, false, null, false, true, true },
                    { 3, 3517, true, false, 90, "Green", "Rem", "A", "B", "C", "Dagger", 6024, true, false, 17, true, true, true, true, true, 13955, 5081, true, 10262, false, null, false, true, true },
                    { 4, 3517, false, false, 80, "Red", "Sazh", "A", "B", "C", "Gun", 6024, true, false, 13, true, true, true, true, true, 13955, 5081, true, 10262, false, null, false, true, true },
                    { 5, 3532, false, false, 90, "Yellow", "Tifa", "A", "B", "C", "fist", 5116, true, false, 7, true, true, true, true, true, 12508, 4339, true, 11475, false, null, false, true, true },
                    { 6, 3759, true, true, 90, "Blue", "Cloud", "A", "B", "C", "Greatsword", 5029, true, false, 7, true, true, true, true, true, 13171, 4355, true, 11314, false, null, false, true, true },
                    { 7, 3497, false, false, 80, "White", "Hope", "B", "C", "D", "shuriken", 5029, true, false, 13, true, true, true, true, true, 13259, 4810, true, 11133, false, null, false, true, true },
                    { 8, 3482, true, true, 80, "Yellow", "Yshtola", "A", "B", "C", "staff", 5340, true, false, 14, true, true, true, true, true, 14018, 5136, true, 10276, false, null, false, true, true },
                    { 9, 3533, true, true, 80, "blue", "Zidane", "A", "A", "E", "dagger", 5029, true, false, 9, true, true, true, true, true, 13243, 4147, true, 11237, false, null, false, true, true },
                    { 10, 3592, false, false, 90, "Black", "Cecil (Dark Knight)", "A", "C", "E", "Greatsword", 5029, true, false, 4, true, true, true, true, true, 15644, 3850, true, 10449, false, null, false, true, true },
                    { 11, 3568, false, false, 80, "Green", "Yda", "A", "A", "E", "fist", 5037, true, false, 14, true, true, true, true, true, 13180, 4037, true, 11372, false, null, false, true, true },
                    { 12, 3590, true, false, 80, "Red", "Vaan", "A", "A", "E", "Sword", 5113, true, false, 12, true, true, true, true, true, 12483, 4663, true, 12266, false, null, false, true, true },
                    { 13, 3466, false, false, 80, "Red", "Yuffie", "D", "E", "E", "shuriken", 5029, true, false, 7, true, true, true, true, true, 13252, 4339, true, 12081, false, null, false, true, true },
                    { 14, 3394, false, false, 80, "White", "Yuna", "C", "C", "D", "Staff", 5650, true, false, 10, true, true, true, true, true, 15074, 5063, true, 9558, false, null, false, true, true },
                    { 15, 3461, false, false, 80, "Blue", "Edge", "A", "B", "D", "Dagger", 4533, true, false, 4, true, true, false, true, true, 13202, 4810, false, 11152, false, null, false, true, true },
                    { 16, 3640, false, false, 80, "Black", "King", "A", "A", "D", "Gun", 4616, true, true, 17, true, true, false, true, true, 13255, 4339, false, 10474, false, null, false, true, true },
                    { 17, 3640, true, true, 80, "Yellow", "Bartz", "A", "C", "D", "Sword", 4616, true, true, 5, true, true, false, true, true, 13255, 4339, true, 10474, true, null, false, true, true },
                    { 18, 3640, false, false, 80, "White", "Penelo", "C", "C", "D", "Dagger", 4616, true, true, 12, true, true, false, true, true, 13255, 4339, true, 10474, false, null, false, true, true },
                    { 19, 3640, true, false, 80, "Black", "Terra", "A", "B", "C", "Sword", 4616, true, true, 6, true, true, false, true, true, 13255, 4339, true, 10474, true, null, false, true, true },
                    { 20, 3640, false, false, 80, "Yellow", "Yang", "A", "B", "C", "Fist", 4616, true, true, 4, true, true, false, true, true, 13255, 4339, true, 10474, false, null, false, true, true },
                    { 21, 3640, true, true, 90, "Red", "Onion Knight", "A", "B", "C", "Sword", 4616, true, true, 3, true, true, false, true, true, 13255, 4339, true, 10474, true, null, false, true, true },
                    { 22, 3640, true, true, 90, "Red", "Firion", "A", "B", "C", "Sword", 4616, true, true, 2, true, true, false, true, true, 13255, 4339, true, 10474, true, null, false, true, true },
                    { 23, 3640, false, false, 80, "Blue", "Laguna", "A", "B", "C", "Gun", 4616, true, true, 8, true, true, false, true, true, 13255, 4339, false, 10474, false, null, false, true, true },
                    { 24, 3640, false, false, 90, "Green", "Steiner", "A", "B", "C", "Greatsword", 4616, true, true, 9, true, true, false, true, true, 13255, 4339, true, 10474, false, null, false, true, true },
                    { 25, 3640, false, false, 80, "Black", "Shadow", "A", "B", "C", "Shuriken", 4616, true, true, 6, true, true, false, true, true, 13255, 4339, true, 10474, false, null, false, true, true },
                    { 26, 3640, true, true, 90, "Black", "Squall", "A", "B", "C", "Greatsword", 4616, true, true, 8, true, true, false, true, true, 13255, 4339, true, 10474, true, null, false, true, true },
                    { 27, 3640, false, false, 90, "Red", "Vanille", "A", "B", "C", "Staff", 4616, true, true, 13, true, true, false, true, true, 13255, 4339, true, 10474, false, null, false, true, true },
                    { 28, 3640, false, false, 80, "Black", "Setzer", "A", "B", "C", "Shuriken", 4616, true, true, 6, true, true, true, true, true, 13255, 4339, true, 10474, false, null, false, true, true },
                    { 29, 3640, false, false, 80, "Blue", "Wakka", "A", "B", "C", "Shuriken", 4616, true, true, 6, true, true, true, true, true, 13255, 4339, true, 10474, false, null, false, true, true },
                    { 30, 3640, false, false, 80, "Breen", "Galuf", "A", "B", "C", "Greatsword", 4616, true, true, 5, true, true, false, true, true, 13255, 4339, true, 10474, false, null, false, true, true },
                    { 31, 3640, true, true, 80, "Black", "Shantotto", "A", "B", "C", "Staff", 4616, true, true, 11, true, true, true, true, true, 13255, 4339, true, 10474, true, null, false, true, true },
                    { 32, 3640, false, false, 80, "Yellow", "Balthier", "A", "B", "C", "Gun", 4616, true, true, 12, true, true, true, true, true, 13255, 4339, true, 10474, false, null, false, true, true },
                    { 33, 3640, false, false, 90, "White", "Eiko", "A", "B", "C", "Staff", 4616, true, true, 9, true, true, true, true, true, 13255, 4339, true, 10474, false, null, false, true, true },
                    { 34, 4151, true, true, 90, "Blue", "Tidus", "A", "B", "C", "Sword", 4722, true, false, 10, true, true, true, true, true, 16179, 5530, true, 12147, true, 775, false, true, true },
                    { 35, 3640, false, false, 90, "Red", "Zell", "A", "B", "C", "Fist", 4616, true, true, 8, true, true, true, true, true, 13255, 4339, true, 10474, false, null, false, true, true },
                    { 36, 3640, true, false, 80, "Yellow", "Layle", "A", "B", "C", "Shuriken", 4616, true, true, 16, true, true, true, true, true, 13255, 4339, true, 10474, false, null, false, true, true },
                    { 37, 3640, false, false, 80, "White", "Vincent", "A", "B", "C", "Gun", 4616, true, true, 7, true, true, true, true, true, 13255, 4339, true, 10474, false, null, false, true, true },
                    { 38, 3640, false, false, 80, "Black", "Prishe", "A", "B", "C", "Fist", 4616, true, true, 11, true, true, false, true, true, 13255, 4339, false, 10474, false, null, false, true, true },
                    { 39, 3640, false, false, 80, "Blue", "Faris", "A", "B", "C", "Dagger", 4616, true, true, 5, true, true, true, true, true, 13255, 4339, true, 10474, false, null, false, true, true },
                    { 40, 3640, true, true, 90, "Yellow", "Razma", "A", "B", "C", "Sword", 4616, true, true, 19, true, true, true, true, true, 13255, 4339, true, 10474, false, null, false, true, true },
                    { 41, 3640, true, true, 80, "Yellow", "Ace", "A", "B", "C", "Shuriken", 4616, true, true, 17, true, true, true, true, true, 13255, 4339, true, 10474, false, null, false, true, true },
                    { 42, 3640, false, false, 80, "White", "Seymour", "A", "B", "C", "Staff", 4616, true, true, 10, true, true, true, true, true, 13255, 4339, false, 10474, false, null, false, true, true }
                });

            migrationBuilder.InsertData(
                table: "Champions",
                columns: new[] { "Id", "ATK", "BT", "BTplus", "ChampClevel", "ChampCrystal", "ChampName", "ChampSphere1", "ChampSphere2", "ChampSphere3", "ChampType", "DEF", "EX", "EXplus", "GameId", "HG35", "HG7star", "HG7starPlus", "HG90", "HG90plus", "HP", "IBRV", "LD", "MBRV", "ManikinWeapon", "MaxCP", "UltimaWeapon", "W15cp", "W35cp" },
                values: new object[,]
                {
                    { 43, 3640, false, false, 80, "Black", "Sabin", "A", "B", "C", "Fist", 4616, true, true, 6, true, true, true, true, true, 13255, 4339, true, 10474, false, null, false, true, true },
                    { 44, 3640, false, false, 80, "Blue", "Krile", "A", "B", "C", "Staff", 4616, true, true, 5, true, true, true, true, true, 13255, 4339, true, 10474, false, null, false, true, true },
                    { 45, 3640, false, false, 90, "Blue", "Cyan", "A", "B", "C", "Greatsword", 4616, true, true, 6, true, true, true, true, true, 13255, 4339, true, 10474, false, null, false, true, true },
                    { 46, 3640, false, false, 90, "Red", "Papalymo", "A", "B", "C", "Staff", 4616, true, true, 14, true, true, true, true, true, 13255, 4339, true, 10474, false, null, false, true, true },
                    { 47, 3640, true, true, 90, "Yellow", "Lightning", "A", "B", "C", "Sword", 4616, true, true, 13, true, true, true, true, true, 13255, 4339, true, 10474, true, null, false, true, true },
                    { 48, 3640, false, false, 80, "White", "Thancred", "A", "B", "C", "Dagger", 4616, true, true, 11, true, true, false, true, true, 13255, 4339, false, 10474, false, null, false, true, true },
                    { 49, 3640, false, false, 80, "Green", "Snow", "A", "B", "C", "Fist", 4616, true, true, 13, true, true, true, true, true, 13255, 4339, true, 10474, false, null, false, true, true },
                    { 50, 3640, false, false, 90, "Yellow", "Cater", "A", "A", "E", "Gun", 4616, true, true, 17, true, true, true, true, true, 13255, 4339, true, 10474, false, null, false, true, true },
                    { 58, 3517, true, false, 90, "Black", "Garnet", "A", "B", "C", "Staff", 6024, true, false, 9, true, true, true, true, true, 13955, 5081, true, 10262, false, null, false, true, true }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ability_ChampionId",
                table: "Ability",
                column: "ChampionId");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_GameId",
                table: "Champions",
                column: "GameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ability");

            migrationBuilder.DropTable(
                name: "Sphere");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Champions");

            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
