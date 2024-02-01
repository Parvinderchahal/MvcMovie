using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "Mission Impossible",
                    ReleaseDate = DateTime.Parse("2023-2-12"),
                    Genre = "Action",
                    Rating = "R",
                    Price = 7.99M
                },
                new Movie
                {
                    Title = "Top Gun ",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Action",
                    Rating = "R",
                    Price = 8.99M
                },
                new Movie
                {
                    Title = "DeathNote",
                    ReleaseDate = DateTime.Parse("1992-2-23"),
                    Genre = "Thriller",
                    Rating = "E",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "Johny Bravo",
                    ReleaseDate = DateTime.Parse("1999-4-15"),
                    Genre = "Western",
                    Rating = "A",
                    Price = 3.99M
                }
            );
            context.SaveChanges();
        }
    }
}