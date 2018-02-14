namespace MovieStreamer.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using MovieStreamer.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<MovieStreamer.Models.MovieDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MovieStreamer.Models.MovieDB context)
        {
            context.Movies.AddOrUpdate(new MovieEntity {
                Title = "Batman", 
                imdbRating = "8.9", 
                Year = "1989", 
                Rated = "PG-13", 
                Released = "23 Jun 1989",
                Runtime = "126 min",
                Genre = "Action, Adventure",
                Director = "Tim Burton",
                Writer = "Bob Kane (Batman characters), Sam Hamm (story), Sam Hamm (screenplay), Warren Skaaren (screenplay)",
                Actors = "Michael Keaton, Jack Nicholson, Kim Basinger, Robert Wuhl",
                Plot = "The Dark Knight of Gotham City begins his war on crime with his first major enemy being the clownishly homicidal Joker.",
                Awards = "Won 1 Oscar. Another 9 wins & 22 nominations.",
                Poster = "http://ia.media-imdb.com/images/M/MV5BMTYwNjAyODIyMF5BMl5BanBnXkFtZTYwNDMwMDk2._V1_SX300.jpg",
                imdbID = "tt0096895",
                Type = "movie",
            });
            context.ListMovies.AddOrUpdate(new UserListMoviesEntity
            {
                UserId = "cda18b06-872e-40d0-8e9f-7f335400651a",
                imdbID = "tt0096895"
            });
           
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
