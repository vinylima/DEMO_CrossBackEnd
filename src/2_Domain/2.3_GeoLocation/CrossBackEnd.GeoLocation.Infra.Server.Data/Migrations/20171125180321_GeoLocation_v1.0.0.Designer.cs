﻿// <auto-generated />
using CrossBackEnd.GeoLocation.Infra.Server.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace CrossBackEnd.GeoLocation.Infra.Server.Data.Migrations
{
    [DbContext(typeof(GeoLocation_Context))]
    [Migration("20171125180321_GeoLocation_v1.0.0")]
    partial class GeoLocation_v100
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CrossBackEnd.GeoLocation.Domain.Models.City", b =>
                {
                    b.Property<Guid>("CityId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsCapital");

                    b.Property<string>("Name");

                    b.Property<int>("Population");

                    b.Property<Guid>("StateId");

                    b.HasKey("CityId");

                    b.HasIndex("StateId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("CrossBackEnd.GeoLocation.Domain.Models.Country", b =>
                {
                    b.Property<Guid>("CountryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Abbreviation");

                    b.Property<string>("Name");

                    b.HasKey("CountryId");

                    b.ToTable("Coutries");
                });

            modelBuilder.Entity("CrossBackEnd.GeoLocation.Domain.Models.State", b =>
                {
                    b.Property<Guid>("StateId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Abbreviation");

                    b.Property<Guid>("CountryId");

                    b.Property<string>("Name");

                    b.HasKey("StateId");

                    b.HasIndex("CountryId");

                    b.ToTable("States");
                });

            modelBuilder.Entity("CrossBackEnd.GeoLocation.Domain.Models.City", b =>
                {
                    b.HasOne("CrossBackEnd.GeoLocation.Domain.Models.State", "State")
                        .WithMany("Cities")
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CrossBackEnd.GeoLocation.Domain.Models.State", b =>
                {
                    b.HasOne("CrossBackEnd.GeoLocation.Domain.Models.Country", "Country")
                        .WithMany("States")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
