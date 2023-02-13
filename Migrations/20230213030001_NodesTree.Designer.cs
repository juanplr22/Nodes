﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nodes.Data;

namespace Nodes.Migrations
{
    [DbContext(typeof(ApidDbContext))]
    [Migration("20230213030001_NodesTree")]
    partial class NodesTree
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Nodes.Entities.NodesTree", b =>
                {
                    b.Property<int>("id")
                        .HasColumnType("int");

                    b.Property<int>("childNode")
                        .HasColumnType("int");

                    b.Property<DateTime>("created_At")
                        .HasColumnType("datetime2");

                    b.Property<string>("parent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("parentNode")
                        .HasColumnType("int");

                    b.Property<string>("timeZone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Nodos");

                    b.HasData(
                        new
                        {
                            id = 1,
                            childNode = 0,
                            created_At = new DateTime(2023, 2, 12, 23, 0, 0, 636, DateTimeKind.Local).AddTicks(3499),
                            parent = "padre",
                            parentNode = 0,
                            timeZone = "Venezuela Standard Time",
                            title = "one"
                        },
                        new
                        {
                            id = 2,
                            childNode = 0,
                            created_At = new DateTime(2023, 2, 12, 23, 0, 0, 637, DateTimeKind.Local).AddTicks(8350),
                            parent = "null",
                            parentNode = 0,
                            timeZone = "Venezuela Standard Time",
                            title = "two"
                        },
                        new
                        {
                            id = 3,
                            childNode = 0,
                            created_At = new DateTime(2023, 2, 12, 23, 0, 0, 637, DateTimeKind.Local).AddTicks(8366),
                            parent = "null",
                            parentNode = 0,
                            timeZone = "Venezuela Standard Time",
                            title = "three"
                        },
                        new
                        {
                            id = 4,
                            childNode = 5,
                            created_At = new DateTime(2023, 2, 12, 23, 0, 0, 637, DateTimeKind.Local).AddTicks(8369),
                            parent = "padre",
                            parentNode = 0,
                            timeZone = "Venezuela Standard Time",
                            title = "four"
                        },
                        new
                        {
                            id = 5,
                            childNode = 0,
                            created_At = new DateTime(2023, 2, 12, 23, 0, 0, 637, DateTimeKind.Local).AddTicks(8370),
                            parent = "hijo",
                            parentNode = 4,
                            timeZone = "Venezuela Standard Time",
                            title = "five"
                        },
                        new
                        {
                            id = 6,
                            childNode = 7,
                            created_At = new DateTime(2023, 2, 12, 23, 0, 0, 637, DateTimeKind.Local).AddTicks(8372),
                            parent = "padre",
                            parentNode = 0,
                            timeZone = "Venezuela Standard Time",
                            title = "six"
                        },
                        new
                        {
                            id = 7,
                            childNode = 0,
                            created_At = new DateTime(2023, 2, 12, 23, 0, 0, 637, DateTimeKind.Local).AddTicks(8373),
                            parent = "hijo",
                            parentNode = 6,
                            timeZone = "Venezuela Standard Time",
                            title = "seven"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
