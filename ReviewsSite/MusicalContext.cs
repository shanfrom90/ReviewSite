using Microsoft.EntityFrameworkCore;
using ReviewsSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite
{
    public class MusicalContext : DbContext
    { public DbSet <Musical> Musicals { get; set; }
      public DbSet<Review> Reviews { get; set; }
      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=MusicTesting;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString)
                .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }
      protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Musical>().HasData(
                new Musical
                {
                    Id = 1 ,
                    Title = "Wicked",
                    Genre = "Drama",
                    Description = "A tale of two friends who happen to be withces. Hijinks ensue.",
                    Rating = 5 ,
                    Comment = "It was a non-stop thrill ride!"

                },


                new Musical
                {
                    Id = 2,
                    Title = "Chicago" ,
                    Genre = "Drama",
                    Description = "A tale of two friends who happen to be prisoners. Hijinks ensue.",
                    Rating = 5,
                    Comment = "Razzle Dazzle!"

                },

                new Musical
                {
                    Id = 3,
                    Title = "Hamilton",
                    Genre = "Historical",
                    Description = "A tale of two friends who happen to be political rivals and founders of a nation. Hijinks ensue.",
                    Rating = 5,
                    Comment = "Amazing!"

                },

                new Musical
                {
                    Id = 4,
                    Title = "Jesus Christ Superstar",
                    Genre = "Drama",
                    Description = "A tale of the last days of Jesus. Hijinks ensue.",
                    Rating = 5,
                    Comment = "Inspirational!"

                },

                new Musical
                {
                    Id = 5,
                    Title = "The Lion King",
                    Genre = "Family",
                    Description = "A tale of two brothers who happen to be lions. Hijinks ensue.",
                    Rating = 5,
                    Comment = "A roaring good time!"

                },

                new Musical
                {
                    Id = 6,
                    Title = "Rent",
                    Genre = "Drama",
                    Description = "A tale of roommates in the city. Hijinks ensue.",
                    Rating = 5,
                    Comment = "Great!"

                },

                new Musical
                {
                    Id = 7,
                    Title = "The Book of Mormon",
                    Genre = "Comedy",
                    Description = "A tale of two Mormons who happen to be missionaries. Hijinks really ensue.",
                    Rating = 5,
                    Comment = "Don't go with your parents! There will be awkwardness."

                },

                new Musical
                {
                    Id = 8,
                    Title = "Cats",
                    Genre = "Drama",
                    Description = "A tale of many cats who happen to be magical. Hijinks ensue.",
                    Rating = 5,
                    Comment = "Memories will be made! Purrfect!"

                }

                ) ;
            modelBuilder.Entity<Review>().HasData(
                new Review
                {
                    Id = 1,
                    Content = "I had the time of my life my life!",
                    Rating = 5,
                    MusicalId = 1
                },
                new Review
                {
                    Id = 2,
                    Content = "Wowza!",
                    Rating = 4,
                    MusicalId = 2
                }
                );
        }
    } 
}
