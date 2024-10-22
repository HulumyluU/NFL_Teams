﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using October8.Models;

#nullable disable

namespace October8.Migrations
{
    [DbContext(typeof(TeamContext))]
    [Migration("20241008190454_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.35")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("October8.Models.Conference", b =>
                {
                    b.Property<string>("ConferenceID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ConferenceID");

                    b.ToTable("Conferences");

                    b.HasData(
                        new
                        {
                            ConferenceID = "afc",
                            Name = "AFC"
                        },
                        new
                        {
                            ConferenceID = "nfc",
                            Name = "NFC"
                        });
                });

            modelBuilder.Entity("October8.Models.Division", b =>
                {
                    b.Property<string>("DivisionID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DivisionID");

                    b.ToTable("Divisions");

                    b.HasData(
                        new
                        {
                            DivisionID = "north",
                            Name = "North"
                        },
                        new
                        {
                            DivisionID = "south",
                            Name = "South"
                        },
                        new
                        {
                            DivisionID = "east",
                            Name = "East"
                        },
                        new
                        {
                            DivisionID = "west",
                            Name = "West"
                        });
                });

            modelBuilder.Entity("October8.Models.Team", b =>
                {
                    b.Property<string>("TeamID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConferenceID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DivisionID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LogoImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeamID");

                    b.HasIndex("ConferenceID");

                    b.HasIndex("DivisionID");

                    b.ToTable("Teams");

                    b.HasData(
                        new
                        {
                            TeamID = "ari",
                            ConferenceID = "nfc",
                            DivisionID = "west",
                            LogoImage = "ARI.png",
                            Name = "Arizona Cardinals"
                        },
                        new
                        {
                            TeamID = "ny",
                            ConferenceID = "nfc",
                            DivisionID = "west",
                            LogoImage = "ARI.png",
                            Name = "Arizona Cardinals"
                        },
                        new
                        {
                            TeamID = "ss",
                            ConferenceID = "nfc",
                            DivisionID = "west",
                            LogoImage = "ARI.png",
                            Name = "Arizona Cardinals"
                        },
                        new
                        {
                            TeamID = "abi",
                            ConferenceID = "nfc",
                            DivisionID = "west",
                            LogoImage = "ARI.png",
                            Name = "Arizona Cardinals"
                        });
                });

            modelBuilder.Entity("October8.Models.Team", b =>
                {
                    b.HasOne("October8.Models.Conference", "Conference")
                        .WithMany()
                        .HasForeignKey("ConferenceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("October8.Models.Division", "Division")
                        .WithMany()
                        .HasForeignKey("DivisionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Conference");

                    b.Navigation("Division");
                });
#pragma warning restore 612, 618
        }
    }
}
