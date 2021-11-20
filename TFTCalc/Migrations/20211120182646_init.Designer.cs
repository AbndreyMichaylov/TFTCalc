﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TFTCalc.DataBaseContexts;

namespace TFTCalc.Migrations
{
    [DbContext(typeof(TftDbContext))]
    [Migration("20211120182646_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TFTCalc.Models.Combo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ComboId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ComboId");

                    b.ToTable("Combo");
                });

            modelBuilder.Entity("TFTCalc.Models.ComboItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AttributeId")
                        .HasColumnType("int");

                    b.Property<string>("Effect")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ToComboCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AttributeId");

                    b.ToTable("ComboItem");
                });

            modelBuilder.Entity("TFTCalc.Models.Hero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cost")
                        .HasColumnType("int");

                    b.Property<byte[]>("Icon")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Hero");
                });

            modelBuilder.Entity("TFTCalc.Models.HeroAttribute", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("HeroId")
                        .HasColumnType("int");

                    b.Property<byte[]>("Icon")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HeroId");

                    b.ToTable("HeroAttributes");
                });

            modelBuilder.Entity("TFTCalc.Models.Combo", b =>
                {
                    b.HasOne("TFTCalc.Models.Combo", null)
                        .WithMany("Combos")
                        .HasForeignKey("ComboId");
                });

            modelBuilder.Entity("TFTCalc.Models.ComboItem", b =>
                {
                    b.HasOne("TFTCalc.Models.HeroAttribute", "Attribute")
                        .WithMany()
                        .HasForeignKey("AttributeId");

                    b.Navigation("Attribute");
                });

            modelBuilder.Entity("TFTCalc.Models.HeroAttribute", b =>
                {
                    b.HasOne("TFTCalc.Models.Hero", null)
                        .WithMany("Attributes")
                        .HasForeignKey("HeroId");
                });

            modelBuilder.Entity("TFTCalc.Models.Combo", b =>
                {
                    b.Navigation("Combos");
                });

            modelBuilder.Entity("TFTCalc.Models.Hero", b =>
                {
                    b.Navigation("Attributes");
                });
#pragma warning restore 612, 618
        }
    }
}