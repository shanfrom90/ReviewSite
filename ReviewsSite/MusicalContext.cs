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
                    Description = "A tale of two friends who happen to be witches. Hijinks ensue.",
                    Image = "/Images/wicked.jpeg"

                },


                new Musical
                {
                    Id = 2,
                    Title = "Chicago" ,
                    Genre = "Drama",
                    Description = "A tale of two friends who happen to be prisoners. Hijinks ensue.",
                    Image = "/Images/Chicago.png"


                },

                new Musical
                {
                    Id = 3,
                    Title = "Hamilton",
                    Genre = "Historical",
                    Description = "A tale of two friends who happen to be political rivals and founders of a nation. Hijinks ensue.",
                    Image = "/Images/hamilton.png"

                },

                new Musical
                {
                    Id = 4,
                    Title = "Jesus Christ Superstar",
                    Genre = "Drama",
                    Description = "A tale of the last days of Jesus. Hijinks ensue.",
                    Image = "/Images/jcsuperstar.jpg"


                },

                new Musical
                {
                    Id = 5,
                    Title = "The Lion King",
                    Genre = "Family",
                    Description = "A tale of two brothers who happen to be lions. Hijinks ensue.",
                    Image = "/Images/lionking3.png"

                },

                new Musical
                {
                    Id = 6,
                    Title = "Rent",
                    Genre = "Drama",
                    Description = "A tale of roommates in the city. Hijinks ensue.",
                    Image = "/Images/rent.png"

                },

                new Musical
                {
                    Id = 7,
                    Title = "The Book of Mormon",
                    Genre = "Comedy",
                    Description = "A tale of two Mormons who happen to be missionaries. Hijinks really ensue.",
                    Image = "/Images/bookofmormon.jpeg"

                },

                new Musical
                {
                    Id = 8,
                    Title = "Cats",
                    Genre = "Drama",
                    Description = "A tale of many cats who happen to be magical. Hijinks ensue.",
                    Image = "/Images/cats.jpg"

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
                },
                new Review
                {
                    Id = 3,
                    Rating = 4,
                    MusicalId = 1,
                    Content = "It was a non-stop thrill ride!"

                },
                new Review
                {
                    Id = 4,
                    Rating = 4,
                    MusicalId = 2,
                    Content = "Razzle Dazzle!"

                },

                new Review
                {
                    Id = 5,
                    Rating = 4,
                    MusicalId = 4,
                    Content = "Inspirational!"

                },
                new Review
                {
                    Id = 6,
                    Rating = 4,
                    MusicalId = 5,
                    Content = "A roaring good time!"

                },
                new Review
                {
                    Id = 7,
                    Rating = 4,
                    MusicalId = 6,
                    Content = "Great!"

                },
                new Review
                {
                    Id = 8,
                    Rating = 4,
                    MusicalId = 7,
                    Content = "Don't go with your parents! There will be awkwardness."

                },
                new Review
                {
                    Id = 9,
                    Rating = 4,
                    MusicalId = 8,
                    Content = "Memories will be made! Purrfect!"

                },
                new Review
                {
                    Id = 10,
                    Rating = 4,
                    MusicalId = 3,
                    Content = "Amazing!"

                }
                );
        }
    } 
}
