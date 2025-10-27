using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pair_Project_FilomenoMatugas.Migrations
{
    /// <inheritdoc />
    public partial class primarykey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "MovieId", "Country", "Genre", "Plot", "Poster", "Rating", "Released", "Title", "Votes" },
                values: new object[,]
                {
                    { "tt0109830", "USA", "Drama, Romance", "The history of the United States from the 1950s to the '70s unfolds from the perspective of an Alabama man with an IQ of 75, who yearns to be reunited with his childhood sweetheart.", "https://m.media-amazon.com/images/M/MV5BNDYwNzVjMTItZmU5YS00YjQ5LTljYjgtMjY2NDVmYWMyNWFmXkEyXkFqcGc@._V1_SX300.jpg", "8.8", "06 Jul 1994", "Forrest Gump", "2,422,593" },
                    { "tt27668559", "South Korea", "Comedy, Drama, Romance", "A miraculous love story of a married couple overcoming a dizzying crisis.", "https://m.media-amazon.com/images/M/MV5BNWNmYmQ2NzctNTA1NS00NGU2LThjOTQtYTgxNmUyYmNjODYyXkEyXkFqcGc@._V1_SX300.jpg", "8.2", "09 Mar 2024", "Queen of Tears", "23,269" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "MovieId",
                keyValue: "tt0109830");

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "MovieId",
                keyValue: "tt27668559");
        }
    }
}
