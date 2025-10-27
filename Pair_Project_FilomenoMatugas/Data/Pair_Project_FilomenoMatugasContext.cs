using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pair_Project_FilomenoMatugas.Models;

namespace Pair_Project_FilomenoMatugas.Data
{
    public class Pair_Project_FilomenoMatugasContext : DbContext
    {
        public Pair_Project_FilomenoMatugasContext (DbContextOptions<Pair_Project_FilomenoMatugasContext> options)
            : base(options)
        {
        }

        public DbSet<Pair_Project_FilomenoMatugas.Models.Movie> Movie { get; set; } = default!;
        //Seeding Purposes
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<Movie>().HasData(
        //        new Movie
        //        {
        //            MovieId = "tt0109830",
        //            Title = "Forrest Gump",
        //            Genre = "Drama, Romance",
        //            Released = new DateOnly(1994, 7, 6),
        //            Poster = "https://m.media-amazon.com/images/M/MV5BNDYwNzVjMTItZmU5YS00YjQ5LTljYjgtMjY2NDVmYWMyNWFmXkEyXkFqcGc@._V1_SX300.jpg",
        //            Country = "USA",
        //            Plot = "The history of the United States from the 1950s to the '70s unfolds from the perspective of an Alabama man with an IQ of 75, who yearns to be reunited with his childhood sweetheart.",
        //            Rating = "8.8",
        //            Votes = "2,422,593"
        //        },
        //        new Movie
        //        {
        //            MovieId = "tt27668559",
        //            Title = "Queen of Tears",
        //            Genre = "Comedy, Drama, Romance",
        //            Released = new DateOnly(2024, 3, 9),
        //            Poster = "https://m.media-amazon.com/images/M/MV5BNWNmYmQ2NzctNTA1NS00NGU2LThjOTQtYTgxNmUyYmNjODYyXkEyXkFqcGc@._V1_SX300.jpg",
        //            Country = "South Korea",
        //            Plot = "A miraculous love story of a married couple overcoming a dizzying crisis.",
        //            Rating = "8.2",
        //            Votes = "23,269"
        //        }
        //    );
        //}


    }
}
