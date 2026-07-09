using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeoStrike.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AdicionaRefinariaInicialAoJogadorTeste : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PlayerBuildings",
                columns: new[] { "Id", "BuildingId", "Level", "PlayerId", "Quantity" },
                values: new object[] { new Guid("4a99048b-403e-417b-8efa-943322e46816"), new Guid("b9336dd7-cfaa-4b03-a0b3-d46af7a94b96"), 1, new Guid("41d3a083-4137-439a-8688-b9c6f6a9ab8c"), 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PlayerBuildings",
                keyColumn: "Id",
                keyValue: new Guid("4a99048b-403e-417b-8efa-943322e46816"));
        }
    }
}
