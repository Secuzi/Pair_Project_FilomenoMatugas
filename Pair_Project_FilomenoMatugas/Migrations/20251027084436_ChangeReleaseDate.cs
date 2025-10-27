using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pair_Project_FilomenoMatugas.Migrations
{
    /// <inheritdoc />
    public partial class ChangeReleaseDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateOnly>(
                name: "Released",
                table: "Movie",
                type: "date",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "MovieId",
                keyValue: "tt0109830",
                column: "Released",
                value: new DateOnly(1994, 7, 6));

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "MovieId",
                keyValue: "tt27668559",
                column: "Released",
                value: new DateOnly(2024, 3, 9));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Released",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "MovieId",
                keyValue: "tt0109830",
                column: "Released",
                value: "06 Jul 1994");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "MovieId",
                keyValue: "tt27668559",
                column: "Released",
                value: "09 Mar 2024");
        }
    }
}
