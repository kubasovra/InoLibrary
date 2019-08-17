﻿// <auto-generated />
using System;
using InoLibrary.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InoLibrary.Migrations
{
    [DbContext(typeof(InoLibraryDbContext))]
    [Migration("20190815144528_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("InoLibrary.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("InoLibrary.Models.Publication", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<string>("Path");

                    b.Property<DateTime>("PublishingYear");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Publications");
                });

            modelBuilder.Entity("InoLibrary.Models.PublicationCategory", b =>
                {
                    b.Property<int>("PublicationId");

                    b.Property<int>("CategoryId");

                    b.HasKey("PublicationId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("PublicationCategories");
                });

            modelBuilder.Entity("InoLibrary.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("Login");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("InoLibrary.Models.Publication", b =>
                {
                    b.HasOne("InoLibrary.Models.User", "User")
                        .WithMany("Publications")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("InoLibrary.Models.PublicationCategory", b =>
                {
                    b.HasOne("InoLibrary.Models.Category", "Category")
                        .WithMany("PublicationCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("InoLibrary.Models.Publication", "Publication")
                        .WithMany("PublicationCategories")
                        .HasForeignKey("PublicationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}