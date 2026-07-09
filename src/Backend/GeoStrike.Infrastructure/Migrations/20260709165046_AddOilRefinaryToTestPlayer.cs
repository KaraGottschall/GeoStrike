using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeoStrike.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddOilRefinaryToTestPlayer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Buildings",
                columns: new[] { "Id", "StartLevel", "Type" },
                values: new object[] { new Guid("b9336dd7-cfaa-4b03-a0b3-d46af7a94b96"), (short)1, (byte)1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: new Guid("b9336dd7-cfaa-4b03-a0b3-d46af7a94b96"));
        }
    }
}
