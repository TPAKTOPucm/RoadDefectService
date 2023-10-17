using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RoadDefectService.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Defects",
                columns: table => new
                {
                    Y = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    X = table.Column<int>(type: "INTEGER", nullable: false),
                    AlligatorCracking = table.Column<bool>(type: "INTEGER", nullable: false),
                    EdgeCracking = table.Column<bool>(type: "INTEGER", nullable: false),
                    LongitudinalCracking = table.Column<bool>(type: "INTEGER", nullable: false),
                    Patching = table.Column<bool>(type: "INTEGER", nullable: false),
                    Pothole = table.Column<bool>(type: "INTEGER", nullable: false),
                    Rutting = table.Column<bool>(type: "INTEGER", nullable: false),
                    TransverseCracking = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Defects", x => x.Y);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    DefectsX = table.Column<int>(type: "INTEGER", nullable: false),
                    DefectsY = table.Column<int>(type: "INTEGER", nullable: false),
                    Data = table.Column<byte[]>(type: "BLOB", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.DefectsX);
                    table.ForeignKey(
                        name: "FK_Images_Defects_DefectsX",
                        column: x => x.DefectsX,
                        principalTable: "Defects",
                        principalColumn: "Y",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Defects");
        }
    }
}
