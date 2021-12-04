﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Domain.Entities.Author", b =>
                {
                    b.Property<int>("author_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("author_Id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("Domain.Entities.Book", b =>
                {
                    b.Property<int>("book_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("author_Id")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("publisher_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("releaseDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("book_id");

                    b.HasIndex("author_Id");

                    b.HasIndex("publisher_id");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("Domain.Entities.City", b =>
                {
                    b.Property<string>("postal_code")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("city")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)");

                    b.HasKey("postal_code");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("Domain.Entities.Library", b =>
                {
                    b.Property<int>("library_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("book_id")
                        .HasColumnType("int");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("library_id");

                    b.ToTable("Libraries");
                });

            modelBuilder.Entity("Domain.Entities.Publisher", b =>
                {
                    b.Property<int>("publisher_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("publisher_id");

                    b.ToTable("Publishers");
                });

            modelBuilder.Entity("Domain.Entities.Review", b =>
                {
                    b.Property<int>("review_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("book_id")
                        .HasColumnType("int");

                    b.Property<int>("rating")
                        .HasColumnType("int");

                    b.Property<string>("review")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("review_id");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("Domain.Entities.Subscriber", b =>
                {
                    b.Property<int>("sub_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("is_active")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("sub_end")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("sub_start")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("sub_id");

                    b.ToTable("Subscribers");
                });

            modelBuilder.Entity("Domain.Entities.Transactions", b =>
                {
                    b.Property<int>("trans_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("book_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("trans_id");

                    b.HasIndex("book_id");

                    b.HasIndex("user_id");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Property<int>("user_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("address")
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)");

                    b.Property<string>("lastname")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)");

                    b.Property<string>("postal-code")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)");

                    b.HasKey("user_id");

                    b.HasIndex("postal-code");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Domain.Entities.Book", b =>
                {
                    b.HasOne("Domain.Entities.Author", "author")
                        .WithMany("books")
                        .HasForeignKey("author_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Publisher", "publisher")
                        .WithMany()
                        .HasForeignKey("publisher_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("author");

                    b.Navigation("publisher");
                });

            modelBuilder.Entity("Domain.Entities.Transactions", b =>
                {
                    b.HasOne("Domain.Entities.Book", "book")
                        .WithMany("transactions")
                        .HasForeignKey("book_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.User", "user")
                        .WithMany("transactions")
                        .HasForeignKey("user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("book");

                    b.Navigation("user");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.HasOne("Domain.Entities.City", "postal_code")
                        .WithMany()
                        .HasForeignKey("postal-code");

                    b.Navigation("postal_code");
                });

            modelBuilder.Entity("Domain.Entities.Author", b =>
                {
                    b.Navigation("books");
                });

            modelBuilder.Entity("Domain.Entities.Book", b =>
                {
                    b.Navigation("transactions");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Navigation("transactions");
                });
#pragma warning restore 612, 618
        }
    }
}
