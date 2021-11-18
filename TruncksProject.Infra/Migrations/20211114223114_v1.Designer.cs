﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TruncksProject.Infra.DataContext;

namespace TruncksProject.Infra.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20211114223114_v1")]
    partial class v1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TruncksProject.Domain.Entities.ModelTrunck", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Name");

                    b.ToTable("ModelTrunck");
                });

            modelBuilder.Entity("TruncksProject.Domain.Entities.Trunck", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("IdModelTrunck")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("YearFabrication")
                        .HasMaxLength(4)
                        .HasColumnType("int");

                    b.Property<int>("YearModel")
                        .HasMaxLength(4)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdModelTrunck");

                    b.ToTable("Trunck");
                });

            modelBuilder.Entity("TruncksProject.Domain.Entities.Trunck", b =>
                {
                    b.HasOne("TruncksProject.Domain.Entities.ModelTrunck", "ModelTrunck")
                        .WithMany("Truncks")
                        .HasForeignKey("IdModelTrunck")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ModelTrunck");
                });

            modelBuilder.Entity("TruncksProject.Domain.Entities.ModelTrunck", b =>
                {
                    b.Navigation("Truncks");
                });
#pragma warning restore 612, 618
        }
    }
}
