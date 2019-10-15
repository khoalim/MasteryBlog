﻿// <auto-generated />
using System;
using MasteryBlog.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MasteryBlog.Migrations
{
    [DbContext(typeof(BlogContext))]
    partial class BlogContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MasteryBlog.Models.Destination", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Image");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Destinations");

                    b.HasData(
                        new { Id = 1, Description = "Great for family fun", Image = "/Images/FamilyVacation.jpg", Name = "Family Getaway" },
                        new { Id = 2, Description = "Work hard, play hard", Image = "/Images/BusinessTrip.jpg", Name = "Business Trip" },
                        new { Id = 3, Description = "Top of the buckeklist", Image = "/Images/Retirement.jpg", Name = "Retirement" },
                        new { Id = 4, Description = "Paradise", Image = "/Images/Honeymoon.jpg", Name = "Honeymoon" }
                    );
                });

            modelBuilder.Entity("MasteryBlog.Models.Post", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author");

                    b.Property<string>("Body");

                    b.Property<string>("Category");

                    b.Property<int>("DestinationID");

                    b.Property<DateTime>("PublishDate");

                    b.Property<string>("Tags");

                    b.Property<string>("Title");

                    b.HasKey("ID");

                    b.HasIndex("DestinationID");

                    b.ToTable("Posts");

                    b.HasData(
                        new { ID = 1, Author = "Jane Doe", Body = "Clean excursion wanderlust design wanderlust WordPress blogger, organized theme website organized excursion cute. Darn colorful colorful whimsical, WordPress whimsical colorful modern design webdesign clean adventure excursion.", Category = "Family Getaway", DestinationID = 1, PublishDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "Travelling with picky eaters" },
                        new { ID = 2, Author = "John Smith", Body = "Theme colorful excursion webdesign, colorful travelblogger traveling darn Travel Travel design expedition. Darn whimsical traveling colorful wanderlust cute blogger.", Category = "Family Getaway", DestinationID = 1, PublishDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "10 Tips for Flying Internationally" },
                        new { ID = 3, Author = "Mary Poppins", Body = "Modern darn WordPress cute traveler design, webdesign WordPress Travel cute colorful whimsical modern whimsical. Expedition design adventure WordPress modern darn excursion, webdesign design darn organized.", Category = "Business Trip", DestinationID = 2, PublishDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "6 Ideas for Working Abroad" },
                        new { ID = 4, Author = "Billie Sullivan", Body = "Fun excursion excursion adventure traveling traveling Travel Travel, Travel website colorful pretty pretty simple. Travelblogger webdesign WordPress, adventure modern design organized website colorful theme travelblogger website simple.", Category = "Business Trip", DestinationID = 2, PublishDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "How to Survive a Working Holiday" },
                        new { ID = 5, Author = "Jermaine Hough", Body = "Cute website travelblogger theme WordPress whimsical organized design. Travelblogger whimsical adventure darn darn, design traveler colorful cute cute organized whimsical darn.", Category = "Retirement", DestinationID = 3, PublishDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "The Only Luxury You Have - Use It Well Before It's Too Late" },
                        new { ID = 6, Author = "Gregg Espinoza", Body = "Darn theme whimsical cute blogger expedition blogger colorful design. Excursion pretty WordPress design expedition traveling, wanderlust excursion WordPress theme cute. Design colorful theme wanderlust travelblogger, darn webdesign simple organized webdesign.", Category = "Retirement", DestinationID = 3, PublishDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "How to travel full time on a pension" },
                        new { ID = 7, Author = "Maxine Dickens", Body = "Adventure excursion theme Travel clean excursion expedition. Theme WordPress pretty website wanderlust website expedition WordPress. Simple design adventure expedition colorful simple wanderlust WordPress, excursion organized website wanderlust colorful.", Category = "Honeymoon", DestinationID = 4, PublishDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "10 Best Italy Honeymoon Destinations" },
                        new { ID = 8, Author = "Montel Dolan", Body = "Organized design WordPress, travelblogger webdesign fun Travel cute clean clean website. Traveling travelblogger organized Travel blogger adventure traveler wanderlust webdesign, blogger Travel darn organized.", Category = "Honeymoon", DestinationID = 4, PublishDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "How To Plan A Luxury Getaway" }
                    );
                });

            modelBuilder.Entity("MasteryBlog.Models.Post", b =>
                {
                    b.HasOne("MasteryBlog.Models.Destination", "Destination")
                        .WithMany("Posts")
                        .HasForeignKey("DestinationID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
