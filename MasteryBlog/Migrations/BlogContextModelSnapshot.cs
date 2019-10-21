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
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MasteryBlog.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Image");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new { Id = 1, Description = "Great for family fun", Image = "/Images/FamilyVacation.jpg", Name = "Family Getaway" },
                        new { Id = 2, Description = "Work hard, play hard", Image = "/Images/BusinessTrip.jpg", Name = "Business Trip" },
                        new { Id = 3, Description = "Top of the bucketlist", Image = "/Images/Retirement.jpg", Name = "Retirement" },
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

                    b.Property<int>("CategoryID");

                    b.Property<DateTime>("PublishDate");

                    b.Property<int?>("TagID");

                    b.Property<string>("Title");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("TagID");

                    b.ToTable("Posts");

                    b.HasData(
                        new { ID = 1, Author = "Jane Doe", Body = "Clean excursion wanderlust design wanderlust WordPress blogger, organized theme website organized excursion cute. Darn colorful colorful whimsical, WordPress whimsical colorful modern design webdesign clean adventure excursion.", CategoryID = 1, PublishDate = new DateTime(2019, 10, 21, 2, 24, 20, 137, DateTimeKind.Local), Title = "Travelling with picky eaters" },
                        new { ID = 2, Author = "John Smith", Body = "Theme colorful excursion webdesign, colorful travelblogger traveling darn Travel Travel design expedition. Darn whimsical traveling colorful wanderlust cute blogger.", CategoryID = 1, PublishDate = new DateTime(2019, 10, 21, 2, 24, 20, 139, DateTimeKind.Local), Title = "10 Tips for Flying Internationally" },
                        new { ID = 3, Author = "Mary Poppins", Body = "Modern darn WordPress cute traveler design, webdesign WordPress Travel cute colorful whimsical modern whimsical. Expedition design adventure WordPress modern darn excursion, webdesign design darn organized.", CategoryID = 2, PublishDate = new DateTime(2019, 10, 21, 2, 24, 20, 139, DateTimeKind.Local), Title = "6 Ideas for Working Abroad" },
                        new { ID = 4, Author = "Billie Sullivan", Body = "Fun excursion excursion adventure traveling traveling Travel Travel, Travel website colorful pretty pretty simple. Travelblogger webdesign WordPress, adventure modern design organized website colorful theme travelblogger website simple.", CategoryID = 2, PublishDate = new DateTime(2019, 10, 21, 2, 24, 20, 139, DateTimeKind.Local), Title = "How to Survive a Working Holiday" },
                        new { ID = 5, Author = "Jermaine Hough", Body = "Cute website travelblogger theme WordPress whimsical organized design. Travelblogger whimsical adventure darn darn, design traveler colorful cute cute organized whimsical darn.", CategoryID = 3, PublishDate = new DateTime(2019, 10, 21, 2, 24, 20, 139, DateTimeKind.Local), Title = "The Only Luxury You Have - Use It Well Before It's Too Late" },
                        new { ID = 6, Author = "Gregg Espinoza", Body = "Darn theme whimsical cute blogger expedition blogger colorful design. Excursion pretty WordPress design expedition traveling, wanderlust excursion WordPress theme cute. Design colorful theme wanderlust travelblogger, darn webdesign simple organized webdesign.", CategoryID = 3, PublishDate = new DateTime(2019, 10, 21, 2, 24, 20, 139, DateTimeKind.Local), Title = "How to travel full time on a pension" },
                        new { ID = 7, Author = "Maxine Dickens", Body = "Adventure excursion theme Travel clean excursion expedition. Theme WordPress pretty website wanderlust website expedition WordPress. Simple design adventure expedition colorful simple wanderlust WordPress, excursion organized website wanderlust colorful.", CategoryID = 4, PublishDate = new DateTime(2019, 10, 21, 2, 24, 20, 139, DateTimeKind.Local), Title = "10 Best Italy Honeymoon Destinations" },
                        new { ID = 8, Author = "Montel Dolan", Body = "Organized design WordPress, travelblogger webdesign fun Travel cute clean clean website. Traveling travelblogger organized Travel blogger adventure traveler wanderlust webdesign, blogger Travel darn organized.", CategoryID = 4, PublishDate = new DateTime(2019, 10, 21, 2, 24, 20, 139, DateTimeKind.Local), Title = "How To Plan A Luxury Getaway" }
                    );
                });

            modelBuilder.Entity("MasteryBlog.Models.PostTag", b =>
                {
                    b.Property<int>("PostID");

                    b.Property<int>("TagID");

                    b.HasKey("PostID", "TagID");

                    b.HasIndex("TagID");

                    b.ToTable("PostTags");

                    b.HasData(
                        new { PostID = 1, TagID = 1 },
                        new { PostID = 1, TagID = 5 },
                        new { PostID = 2, TagID = 5 },
                        new { PostID = 3, TagID = 3 },
                        new { PostID = 3, TagID = 4 },
                        new { PostID = 4, TagID = 7 },
                        new { PostID = 4, TagID = 8 },
                        new { PostID = 5, TagID = 2 },
                        new { PostID = 5, TagID = 4 },
                        new { PostID = 6, TagID = 3 },
                        new { PostID = 6, TagID = 7 },
                        new { PostID = 7, TagID = 1 },
                        new { PostID = 7, TagID = 6 },
                        new { PostID = 8, TagID = 6 },
                        new { PostID = 8, TagID = 7 }
                    );
                });

            modelBuilder.Entity("MasteryBlog.Models.Tag", b =>
                {
                    b.Property<int>("TagID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("TagID");

                    b.ToTable("Tags");

                    b.HasData(
                        new { TagID = 1, Name = "Adventure" },
                        new { TagID = 2, Name = "Beach" },
                        new { TagID = 3, Name = "Explore" },
                        new { TagID = 4, Name = "Tour Guide" },
                        new { TagID = 5, Name = "Child Friendly" },
                        new { TagID = 6, Name = "Newlyweds" },
                        new { TagID = 7, Name = "Relaxation" },
                        new { TagID = 8, Name = "Exchange Rate" }
                    );
                });

            modelBuilder.Entity("MasteryBlog.Models.Post", b =>
                {
                    b.HasOne("MasteryBlog.Models.Category", "Category")
                        .WithMany("Posts")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MasteryBlog.Models.Tag", "Tag")
                        .WithMany()
                        .HasForeignKey("TagID");
                });

            modelBuilder.Entity("MasteryBlog.Models.PostTag", b =>
                {
                    b.HasOne("MasteryBlog.Models.Post", "Post")
                        .WithMany("PostTags")
                        .HasForeignKey("PostID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MasteryBlog.Models.Tag", "Tag")
                        .WithMany("PostTags")
                        .HasForeignKey("TagID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
