using MvcMovie.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;


namespace MvcMovie.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PagesMovieContext(
                serviceProvider.GetRequiredService
                <DbContextOptions<PagesMovieContext>>())) {

                if (context.Movie.Any())
                    return;

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Охотники за привидениями",
                        ReleaseDate = DateTime.Parse("01-01-2020"),
                        Genre = "Комедия",
                        Price = 7878.454M
                    },
                    new Movie
                    {
                        Title = "Охотники за привидениями 2",
                        ReleaseDate = DateTime.Parse("02-02-2020"),
                        Genre = "Комедия",
                        Price = 7878.454M
                    },
                    new Movie
                    {
                        Title = "Матрица",
                        ReleaseDate = DateTime.Parse("03-03-2020"),
                        Genre = "Боевик",
                        Price = 1354.88M
                    }
                    );
                context.SaveChanges();
            }

        }
    }
}
