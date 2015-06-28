namespace MvcMovie.Migrations
{
    using MvcMovie.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcMovie.Models.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MvcMovie.Models.MovieDBContext";
        }

        protected override void Seed(MvcMovie.Models.MovieDBContext context)
        {
            context.Movies.AddOrUpdate(i => i.Title,
                new Movie
                {
                    Title = "Jurassic World",
                    ReleaseDate = DateTime.Parse("2015-6-15"),
                    Genre = "Adventure",
                    Price = 20.00M,
                    Rating = "PG"
                },

                 new Movie
                 {
                     Title = "Jurassic Park - The Lost World",
                     ReleaseDate = DateTime.Parse("1997-5-23"),
                     Genre = "Adventure",
                     Price = 10.00M,
                     Rating = "PG"
                 },

                 new Movie
                 {
                     Title = "Jurassic Park III",
                     ReleaseDate = DateTime.Parse("2001-8-31"),
                     Genre = "Adventure",
                     Price = 15.00M,
                     Rating = "PG"
                 },

               new Movie
               {
                   Title = "Jurassic Park",
                   ReleaseDate = DateTime.Parse("1993-9-15"),
                   Genre = "Adventure",
                   Price = 5M,
                   Rating = "PG"
               }
           );
        }
    }
}
