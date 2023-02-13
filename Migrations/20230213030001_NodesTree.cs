using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Nodes.Migrations
{
    public partial class NodesTree : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Nodos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    parent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_At = table.Column<DateTime>(type: "datetime2", nullable: false),
                    parentNode = table.Column<int>(type: "int", nullable: false),
                    childNode = table.Column<int>(type: "int", nullable: false),
                    timeZone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nodos", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Nodos",
                columns: new[] { "id", "childNode", "created_At", "parent", "parentNode", "timeZone", "title" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(2023, 2, 12, 23, 0, 0, 636, DateTimeKind.Local).AddTicks(3499), "padre", 0, "Venezuela Standard Time", "one" },
                    { 2, 0, new DateTime(2023, 2, 12, 23, 0, 0, 637, DateTimeKind.Local).AddTicks(8350), "null", 0, "Venezuela Standard Time", "two" },
                    { 3, 0, new DateTime(2023, 2, 12, 23, 0, 0, 637, DateTimeKind.Local).AddTicks(8366), "null", 0, "Venezuela Standard Time", "three" },
                    { 4, 5, new DateTime(2023, 2, 12, 23, 0, 0, 637, DateTimeKind.Local).AddTicks(8369), "padre", 0, "Venezuela Standard Time", "four" },
                    { 5, 0, new DateTime(2023, 2, 12, 23, 0, 0, 637, DateTimeKind.Local).AddTicks(8370), "hijo", 4, "Venezuela Standard Time", "five" },
                    { 6, 7, new DateTime(2023, 2, 12, 23, 0, 0, 637, DateTimeKind.Local).AddTicks(8372), "padre", 0, "Venezuela Standard Time", "six" },
                    { 7, 0, new DateTime(2023, 2, 12, 23, 0, 0, 637, DateTimeKind.Local).AddTicks(8373), "hijo", 6, "Venezuela Standard Time", "seven" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Nodos");
        }
    }
}
