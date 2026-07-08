using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeoStrike.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedInitialBuildings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Buildings",
                columns: new[] { "Id", "Type", "startLevel" },
                values: new object[] { new Guid("cdeafbce-68b1-4127-940a-a6211b1a43d7"), 0, (short)0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: new Guid("cdeafbce-68b1-4127-940a-a6211b1a43d7"));
        }
    }
}
