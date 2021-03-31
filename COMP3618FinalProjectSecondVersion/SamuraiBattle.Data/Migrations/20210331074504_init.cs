using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SamuraiBattle.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "SamuraiBattle");

            migrationBuilder.CreateTable(
                name: "Battle",
                schema: "SamuraiBattle",
                columns: table => new
                {
                    BattleID = table.Column<int>(nullable: false, comment: "Primary key for Customer records.")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FightDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())", comment: "Date"),
                    Name = table.Column<string>(maxLength: 255, nullable: true, comment: "Name"),
                    Town = table.Column<string>(maxLength: 255, nullable: true),
                    BattleID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Battle", x => x.BattleID);
                    table.ForeignKey(
                        name: "FK_Battle_Battle_BattleID1",
                        column: x => x.BattleID1,
                        principalSchema: "SamuraiBattle",
                        principalTable: "Battle",
                        principalColumn: "BattleID",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "Battle information.");

            migrationBuilder.CreateTable(
                name: "Samurai",
                schema: "SamuraiBattle",
                columns: table => new
                {
                    SamuraiID = table.Column<int>(nullable: false, comment: "Primary key for Customer records.")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Picture = table.Column<string>(maxLength: 255, nullable: true, comment: "Picture"),
                    Name = table.Column<string>(maxLength: 255, nullable: true, comment: "Name"),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Town = table.Column<string>(maxLength: 255, nullable: true),
                    SamuraiID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Samurai", x => x.SamuraiID);
                    table.ForeignKey(
                        name: "FK_Samurai_Samurai_SamuraiID1",
                        column: x => x.SamuraiID1,
                        principalSchema: "SamuraiBattle",
                        principalTable: "Samurai",
                        principalColumn: "SamuraiID",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "Samurai information.");

            migrationBuilder.CreateIndex(
                name: "IX_Battle_BattleID1",
                schema: "SamuraiBattle",
                table: "Battle",
                column: "BattleID1");

            migrationBuilder.CreateIndex(
                name: "IX_Samurai_SamuraiID1",
                schema: "SamuraiBattle",
                table: "Samurai",
                column: "SamuraiID1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Battle",
                schema: "SamuraiBattle");

            migrationBuilder.DropTable(
                name: "Samurai",
                schema: "SamuraiBattle");
        }
    }
}
