using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesMovie.Data;
using RazorPagesMovie.Models;



namespace RazorPagesMovie.Models
{

    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMovieContext(
            serviceProvider.GetRequiredService<
            DbContextOptions<RazorPagesMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return; // DB has been seeded
                }

                context.Movie.AddRange(

                    new Movie
                    {

                        Title = "The Dark Pyramid",
                        ReleaseDate = DateTime.Parse("2022-06-20"),
                        Genre = "Horror and Adventrous",
                        Price = 8.36M

                    },

                    new Movie
                    {
                        Title = "The GhostRider",
                        ReleaseDate = DateTime.Parse("2022-07-02"),
                        Genre = "Supernatural",
                        Price = 6.3M
                    },

                    new Movie
                    {
                        Title = "KGF2",
                        ReleaseDate = DateTime.Parse("2022-04-15"),
                        Genre = "Action  , Romantic and Emotional",
                        Price = 10.36M
                    },

                    new Movie
                    {

                        Title = "Prabhakar The Mysterious Boy",
                        ReleaseDate = DateTime.Parse("2022-09-12"),
                        Genre = "Adventrous and Fantasy",
                        Price = 15.36M
                    }


                    );

                context.SaveChanges();




            }

        }
    }
}