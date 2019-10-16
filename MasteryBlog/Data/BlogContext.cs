﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MasteryBlog.Models;
using Microsoft.EntityFrameworkCore;

namespace MasteryBlog.Data
{
    public class BlogContext : DbContext
    {

        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=BlogTesting;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    Image = "/Images/FamilyVacation.jpg",
                    Name = "Family Getaway",
                    Description = "Great for family fun",
                },

                new Category()
                {
                    Id = 2,
                    Image = "/Images/BusinessTrip.jpg",
                    Name = "Business Trip",
                    Description = "Work hard, play hard",
                },

                new Category()
                {
                    Id = 3,
                    Image = "/Images/Retirement.jpg",
                    Name = "Retirement",
                    Description = "Top of the bucketlist",
                },

                new Category()
                {
                    Id = 4,
                    Image = "/Images/Honeymoon.jpg",
                    Name = "Honeymoon",
                    Description = "Paradise",
                }
                );

            modelBuilder.Entity<Post>().HasData(
                new Post()
                {
                    ID = 1,
                    Title = "Travelling with picky eaters",
                    Body = "Clean excursion wanderlust design wanderlust WordPress blogger, organized theme website organized excursion cute. Darn colorful colorful whimsical, WordPress whimsical colorful modern design webdesign clean adventure excursion.",
                    Author = "Jane Doe",                    
                    CategoryID = 1,
                },
                new Post()
                {
                    ID = 2,
                    Title = "10 Tips for Flying Internationally",
                    Body = "Theme colorful excursion webdesign, colorful travelblogger traveling darn Travel Travel design expedition. Darn whimsical traveling colorful wanderlust cute blogger.",
                    Author = "John Smith",                    
                    CategoryID = 1
                },
               new Post()
               {
                   ID = 3,
                   Title = "6 Ideas for Working Abroad",
                   Body = "Modern darn WordPress cute traveler design, webdesign WordPress Travel cute colorful whimsical modern whimsical. Expedition design adventure WordPress modern darn excursion, webdesign design darn organized.",
                   Author = "Mary Poppins",                   
                   CategoryID = 2
               },
               new Post()
               {
                   ID = 4,
                   Title = "How to Survive a Working Holiday",
                   Body = "Fun excursion excursion adventure traveling traveling Travel Travel, Travel website colorful pretty pretty simple. Travelblogger webdesign WordPress, adventure modern design organized website colorful theme travelblogger website simple.",
                   Author = "Billie Sullivan",                   
                   CategoryID = 2
               },
               new Post()
               {
                   ID = 5,
                   Title = "The Only Luxury You Have - Use It Well Before It's Too Late",
                   Body = "Cute website travelblogger theme WordPress whimsical organized design. Travelblogger whimsical adventure darn darn, design traveler colorful cute cute organized whimsical darn.",
                   Author = "Jermaine Hough",                   
                   CategoryID = 3
               },
               new Post()
               {
                   ID = 6,
                   Title = "How to travel full time on a pension",
                   Body = "Darn theme whimsical cute blogger expedition blogger colorful design. Excursion pretty WordPress design expedition traveling, wanderlust excursion WordPress theme cute. Design colorful theme wanderlust travelblogger, darn webdesign simple organized webdesign.",
                   Author = "Gregg Espinoza",                   
                   CategoryID = 3
               },
               new Post()
               {
                   ID = 7,
                   Title = "10 Best Italy Honeymoon Destinations",
                   Body = "Adventure excursion theme Travel clean excursion expedition. Theme WordPress pretty website wanderlust website expedition WordPress. Simple design adventure expedition colorful simple wanderlust WordPress, excursion organized website wanderlust colorful.",
                   Author = "Maxine Dickens",                   
                   CategoryID = 4
               },
               new Post()
               {
                   ID = 8,
                   Title = "How To Plan A Luxury Getaway",
                   Body = "Organized design WordPress, travelblogger webdesign fun Travel cute clean clean website. Traveling travelblogger organized Travel blogger adventure traveler wanderlust webdesign, blogger Travel darn organized.",
                   Author = "Montel Dolan",                   
                   CategoryID = 4
               }
               );


        }
    }
}