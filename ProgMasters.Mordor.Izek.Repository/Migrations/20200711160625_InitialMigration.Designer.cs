﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProgMasters.Mordor.Izek.Repository;

namespace ProgMasters.Mordor.Izek.Repository.Migrations
{
    [DbContext(typeof(IzeContext))]
    [Migration("20200711160625_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ProgMasters.Mordor.Izek.Repository.Entities.DbHorda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Hordak");
                });

            modelBuilder.Entity("ProgMasters.Mordor.Izek.Repository.Entities.DbOrk", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("KillCount")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(767)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("OrkTable");
                });

            modelBuilder.Entity("ProgMasters.Mordor.Izek.Repository.Entities.DbOrkWeapon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("DbOrkId")
                        .HasColumnType("int");

                    b.Property<string>("Weapon")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("DbOrkId");

                    b.ToTable("OrkWeapons");
                });

            modelBuilder.Entity("ProgMasters.Mordor.Izek.Repository.Entities.DbOrkWeapon", b =>
                {
                    b.HasOne("ProgMasters.Mordor.Izek.Repository.Entities.DbOrk", null)
                        .WithMany("Weapons")
                        .HasForeignKey("DbOrkId");
                });
#pragma warning restore 612, 618
        }
    }
}
