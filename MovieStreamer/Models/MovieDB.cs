using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MovieStreamer.Models
{
    public class MovieDB : IdentityDbContext<ApplicationUser>
    {
        public MovieDB() : base("MovieDB")
        {}

        public DbSet<MovieEntity> Movies { get; set; }
        public DbSet<UserListMoviesEntity> ListMovies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserListMoviesEntity>()
                .HasKey(lm => new { lm.imdbID, lm.UserId });
        }
    }
}