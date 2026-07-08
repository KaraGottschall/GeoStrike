using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeoStrike.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedPlayerWithInitialHq : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlayerBuildings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlayerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BuildingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerBuildings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayerBuildings_Buildings_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Buildings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PlayerBuildings_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Gold", "Money", "Name", "Oil" },
                values: new object[] { new Guid("41d3a083-4137-439a-8688-b9c6f6a9ab8c"), 5000000, 5000000.0, "John Doe", 5000000 });

            migrationBuilder.InsertData(
                table: "PlayerBuildings",
                columns: new[] { "Id", "BuildingId", "Level", "PlayerId", "Quantity" },
                values: new object[] { new Guid("3cd60eca-d0ce-4f25-8501-938b1e07ecbb"), new Guid("cdeafbce-68b1-4127-940a-a6211b1a43d7"), 2, new Guid("41d3a083-4137-439a-8688-b9c6f6a9ab8c"), 1 });

            migrationBuilder.CreateIndex(
                name: "IX_PlayerBuildings_BuildingId",
                table: "PlayerBuildings",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerBuildings_PlayerId",
                table: "PlayerBuildings",
                column: "PlayerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlayerBuildings");

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("41d3a083-4137-439a-8688-b9c6f6a9ab8c"));
        }
    }
}
