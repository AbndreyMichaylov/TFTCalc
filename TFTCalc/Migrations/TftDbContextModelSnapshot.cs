﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TFTCalc.DataBaseContexts;

namespace TFTCalc.Migrations
{
    [DbContext(typeof(TftDbContext))]
    partial class TftDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ComboItemHeroAttribute", b =>
                {
                    b.Property<int>("ComboItemsId")
                        .HasColumnType("int");

                    b.Property<int>("HeroAttributeId")
                        .HasColumnType("int");

                    b.HasKey("ComboItemsId", "HeroAttributeId");

                    b.HasIndex("HeroAttributeId");

                    b.ToTable("ComboItemHeroAttribute");
                });

            modelBuilder.Entity("HeroHeroAttribute", b =>
                {
                    b.Property<int>("AttributesId")
                        .HasColumnType("int");

                    b.Property<int>("HeroId")
                        .HasColumnType("int");

                    b.HasKey("AttributesId", "HeroId");

                    b.HasIndex("HeroId");

                    b.ToTable("HeroHeroAttribute");
                });

            modelBuilder.Entity("TFTCalc.Models.Combo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Combo");
                });

            modelBuilder.Entity("TFTCalc.Models.ComboItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ComboId")
                        .HasColumnType("int");

                    b.Property<string>("Effect")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ToComboCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ComboId");

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

                    b.Property<byte[]>("Icon")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("HeroAttributes");
                });

            modelBuilder.Entity("ComboItemHeroAttribute", b =>
                {
                    b.HasOne("TFTCalc.Models.ComboItem", null)
                        .WithMany()
                        .HasForeignKey("ComboItemsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TFTCalc.Models.HeroAttribute", null)
                        .WithMany()
                        .HasForeignKey("HeroAttributeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HeroHeroAttribute", b =>
                {
                    b.HasOne("TFTCalc.Models.HeroAttribute", null)
                        .WithMany()
                        .HasForeignKey("AttributesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TFTCalc.Models.Hero", null)
                        .WithMany()
                        .HasForeignKey("HeroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TFTCalc.Models.ComboItem", b =>
                {
                    b.HasOne("TFTCalc.Models.Combo", null)
                        .WithMany("Combos")
                        .HasForeignKey("ComboId");
                });

            modelBuilder.Entity("TFTCalc.Models.Combo", b =>
                {
                    b.Navigation("Combos");
                });
#pragma warning restore 612, 618
        }
    }
}
