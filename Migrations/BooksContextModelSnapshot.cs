﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using book_store.Models;

namespace book_store.Migrations
{
    [DbContext(typeof(BooksContext))]
    partial class BooksContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("book_store.Models.Book", b =>
                {
                    b.Property<int>("bookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("author")
                        .HasColumnType("text");

                    b.Property<int?>("categoryId")
                        .HasColumnType("integer");

                    b.Property<string>("image")
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.Property<int>("pages")
                        .HasColumnType("integer");

                    b.Property<double>("price")
                        .HasColumnType("double precision");

                    b.Property<int?>("publisherId")
                        .HasColumnType("integer");

                    b.HasKey("bookId");

                    b.HasIndex("categoryId");

                    b.HasIndex("publisherId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("book_store.Models.Category", b =>
                {
                    b.Property<int>("categoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.HasKey("categoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("book_store.Models.Publisher", b =>
                {
                    b.Property<int>("publisherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.HasKey("publisherId");

                    b.ToTable("Publishers");
                });

            modelBuilder.Entity("book_store.Models.Book", b =>
                {
                    b.HasOne("book_store.Models.Category", "category")
                        .WithMany()
                        .HasForeignKey("categoryId");

                    b.HasOne("book_store.Models.Publisher", "publisher")
                        .WithMany()
                        .HasForeignKey("publisherId");

                    b.Navigation("category");

                    b.Navigation("publisher");
                });
#pragma warning restore 612, 618
        }
    }
}
