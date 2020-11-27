﻿// <auto-generated />
using System;
using MadeInEugene.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MadeInEugene.Migrations
{
    [DbContext(typeof(ProductsCompaniesDbContext))]
    partial class ProductsCompaniesDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("MadeInEugene.Models.Company", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("NameOfCompany")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("contactInfo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CompanyId");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            CompanyId = -1,
                            NameOfCompany = "Nancy's",
                            contactInfo = "(541) 689-2911"
                        },
                        new
                        {
                            CompanyId = -2,
                            NameOfCompany = "Surata Soyfoods Inc",
                            contactInfo = "(541) 485-6990"
                        });
                });

            modelBuilder.Entity("MadeInEugene.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CompanyId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NameOfProduct")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Rating")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Review")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ProductId");

                    b.HasIndex("CompanyId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("MadeInEugene.Models.Product", b =>
                {
                    b.HasOne("MadeInEugene.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");

                    b.Navigation("Company");
                });
#pragma warning restore 612, 618
        }
    }
}
