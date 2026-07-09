using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeoStrike.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SomeMigrationThatIDontKnowWhatItIs2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: new Guid("b9336dd7-cfaa-4b03-a0b3-d46af7a94b96"),
                column: "ConstructionCost",
                value: 100.0);

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: new Guid("cdeafbce-68b1-4127-940a-a6211b1a43d7"),
                column: "ConstructionCost",
                value: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: new Guid("b9336dd7-cfaa-4b03-a0b3-d46af7a94b96"),
                column: "ConstructionCost",
                value: 200.0);

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: new Guid("cdeafbce-68b1-4127-940a-a6211b1a43d7"),
                column: "ConstructionCost",
                value: 100.0);
        }
    }
}
