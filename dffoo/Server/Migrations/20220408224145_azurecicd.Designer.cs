﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dffoo.Server.Data;

#nullable disable

namespace dffoo.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220408224145_azurecicd")]
    partial class azurecicd
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("dffoo.Shared.Champion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ATK")
                        .HasColumnType("int");

                    b.Property<bool>("BT")
                        .HasColumnType("bit");

                    b.Property<bool>("BTplus")
                        .HasColumnType("bit");

                    b.Property<int>("ChampClevel")
                        .HasColumnType("int");

                    b.Property<string>("ChampCrystal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChampName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChampSphere1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChampSphere2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChampSphere3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChampType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DEF")
                        .HasColumnType("int");

                    b.Property<bool>("EX")
                        .HasColumnType("bit");

                    b.Property<bool>("EXplus")
                        .HasColumnType("bit");

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<bool>("HG35")
                        .HasColumnType("bit");

                    b.Property<bool>("HG7star")
                        .HasColumnType("bit");

                    b.Property<bool>("HG7starPlus")
                        .HasColumnType("bit");

                    b.Property<bool>("HG90")
                        .HasColumnType("bit");

                    b.Property<bool>("HG90plus")
                        .HasColumnType("bit");

                    b.Property<int>("HP")
                        .HasColumnType("int");

                    b.Property<int>("IBRV")
                        .HasColumnType("int");

                    b.Property<bool>("LD")
                        .HasColumnType("bit");

                    b.Property<int>("MBRV")
                        .HasColumnType("int");

                    b.Property<bool>("W15cp")
                        .HasColumnType("bit");

                    b.Property<bool>("W35cp")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("Champions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ATK = 3517,
                            BT = true,
                            BTplus = false,
                            ChampClevel = 80,
                            ChampCrystal = "White",
                            ChampName = "Warrior Of Light",
                            ChampSphere1 = "A",
                            ChampSphere2 = "B",
                            ChampSphere3 = "D",
                            ChampType = "Sword",
                            DEF = 6024,
                            EX = true,
                            EXplus = false,
                            GameId = 1,
                            HG35 = true,
                            HG7star = true,
                            HG7starPlus = true,
                            HG90 = true,
                            HG90plus = true,
                            HP = 13955,
                            IBRV = 5081,
                            LD = true,
                            MBRV = 10262,
                            W15cp = true,
                            W35cp = true
                        },
                        new
                        {
                            Id = 2,
                            ATK = 3517,
                            BT = true,
                            BTplus = false,
                            ChampClevel = 80,
                            ChampCrystal = "Black",
                            ChampName = "Vivi",
                            ChampSphere1 = "A",
                            ChampSphere2 = "B",
                            ChampSphere3 = "D",
                            ChampType = "Staff",
                            DEF = 6024,
                            EX = true,
                            EXplus = false,
                            GameId = 9,
                            HG35 = true,
                            HG7star = true,
                            HG7starPlus = true,
                            HG90 = true,
                            HG90plus = true,
                            HP = 13955,
                            IBRV = 5081,
                            LD = true,
                            MBRV = 10262,
                            W15cp = true,
                            W35cp = true
                        },
                        new
                        {
                            Id = 4,
                            ATK = 3517,
                            BT = true,
                            BTplus = false,
                            ChampClevel = 80,
                            ChampCrystal = "Black",
                            ChampName = "Garnet",
                            ChampSphere1 = "A",
                            ChampSphere2 = "B",
                            ChampSphere3 = "D",
                            ChampType = "Staff",
                            DEF = 6024,
                            EX = true,
                            EXplus = false,
                            GameId = 9,
                            HG35 = true,
                            HG7star = true,
                            HG7starPlus = true,
                            HG90 = true,
                            HG90plus = true,
                            HP = 13955,
                            IBRV = 5081,
                            LD = true,
                            MBRV = 10262,
                            W15cp = true,
                            W35cp = true
                        },
                        new
                        {
                            Id = 3,
                            ATK = 3517,
                            BT = true,
                            BTplus = false,
                            ChampClevel = 80,
                            ChampCrystal = "Green",
                            ChampName = "Rem",
                            ChampSphere1 = "A",
                            ChampSphere2 = "B",
                            ChampSphere3 = "D",
                            ChampType = "Dagger",
                            DEF = 6024,
                            EX = true,
                            EXplus = false,
                            GameId = 17,
                            HG35 = true,
                            HG7star = true,
                            HG7starPlus = true,
                            HG90 = true,
                            HG90plus = true,
                            HP = 13955,
                            IBRV = 5081,
                            LD = true,
                            MBRV = 10262,
                            W15cp = true,
                            W35cp = true
                        });
                });

            modelBuilder.Entity("dffoo.Shared.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Final Fantasy 1"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Final Fantasy 2"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Final Fantasy 3"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Final Fantasy 4"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Final Fantasy 5"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Final Fantasy 6"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Final Fantasy 7"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Final Fantasy 8"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Final Fantasy 9"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Final Fantasy 10"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Final Fantasy 11"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Final Fantasy 12"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Final Fantasy 13"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Final Fantasy 14"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Final Fantasy 15"
                        },
                        new
                        {
                            Id = 16,
                            Name = "Final Fantasy Crystal Chronicles"
                        },
                        new
                        {
                            Id = 17,
                            Name = "Final Fantasy Type-0"
                        },
                        new
                        {
                            Id = 18,
                            Name = "World Of Final Fantasy"
                        },
                        new
                        {
                            Id = 19,
                            Name = "Final Fantasy Tactics"
                        });
                });

            modelBuilder.Entity("dffoo.Shared.User", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("birthday")
                        .HasColumnType("datetime2");

                    b.HasKey("Email");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("dffoo.Shared.Champion", b =>
                {
                    b.HasOne("dffoo.Shared.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");
                });
#pragma warning restore 612, 618
        }
    }
}
