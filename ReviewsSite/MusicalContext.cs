﻿using Microsoft.EntityFrameworkCore;
using ReviewsSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite
{
    public class MusicalContext : DbContext
    { public DbSet <Musical> Musicals { get; set; }
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

                }
                ) ; 
        }
    } 
}
