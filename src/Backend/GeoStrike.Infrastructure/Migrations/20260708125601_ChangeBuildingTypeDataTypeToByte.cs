using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeoStrike.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ChangeBuildingTypeDataTypeToByte : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "Type",
                table: "Buildings",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: new Guid("cdeafbce-68b1-4127-940a-a6211b1a43d7"),
                column: "Type",
                value: (byte)0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "Buildings",
                type: "int",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: new Guid("cdeafbce-68b1-4127-940a-a6211b1a43d7"),
                column: "Type",
                value: 0);
        }
    }
}
