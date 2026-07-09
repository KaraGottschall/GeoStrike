using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeoStrike.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SomeMigrationThatIDontKnowWhatItIs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "startLevel",
                table: "Buildings",
                newName: "StartLevel");

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: new Guid("cdeafbce-68b1-4127-940a-a6211b1a43d7"),
                column: "StartLevel",
                value: (short)1);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StartLevel",
                table: "Buildings",
                newName: "startLevel");

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: new Guid("cdeafbce-68b1-4127-940a-a6211b1a43d7"),
                column: "startLevel",
                value: (short)0);
        }
    }
}
