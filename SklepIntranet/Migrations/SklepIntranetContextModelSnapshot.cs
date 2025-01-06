﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SklepIntranet.Data;

#nullable disable

namespace SklepIntranet.Migrations
{
    [DbContext(typeof(SklepIntranetContext))]
    partial class SklepIntranetContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SklepIntranet.Models.CMS.News", b =>
                {
                    b.Property<int>("IdNews")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdNews"));

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<string>("LinkTitle")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Position")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("IdNews");

                    b.ToTable("News");
                });

            modelBuilder.Entity("SklepIntranet.Models.CMS.Page", b =>
                {
                    b.Property<int>("IdPage")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPage"));

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<string>("LinkTitle")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("Pozition")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("IdPage");

                    b.ToTable("Page");
                });
#pragma warning restore 612, 618
        }
    }
}
