using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeoStrike.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AtualizaModeloBuilding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompletionDate",
                table: "Buildings");

            migrationBuilder.DropColumn(
                name: "PlayerId",
                table: "Buildings");

            migrationBuilder.RenameColumn(
                name: "Level",
                table: "Buildings",
                newName: "startLevel");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "startLevel",
                table: "Buildings",
                newName: "Level");

            migrationBuilder.AddColumn<DateTime>(
                name: "CompletionDate",
                table: "Buildings",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PlayerId",
                table: "Buildings",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
