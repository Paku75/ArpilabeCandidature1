﻿// <auto-generated />
using ArpilabeCandidature1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ArpilabeCandidature1.Migrations
{
    [DbContext(typeof(PersonneContext))]
    [Migration("20201126115048_Change dbname")]
    partial class Changedbname
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ArpilabeCandidature1.Models.Personne", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("dateNaissance")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("depatement")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("note")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("telephone")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("id");

                    b.ToTable("Personne");
                });
#pragma warning restore 612, 618
        }
    }
}
