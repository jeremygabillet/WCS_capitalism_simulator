﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace WCS_capitalism_simulator.Migrations
{
    [DbContext(typeof(OffshoreContext))]
    [Migration("20211108161324_DbInitializationWithSeed")]
    partial class DbInitializationWithSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WCS_capitalism_simulator.Person", b =>
                {
                    b.Property<Guid>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonId");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("WCS_capitalism_simulator.SavingAccount", b =>
                {
                    b.Property<Guid>("SavingAccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<int>("InterestRate")
                        .HasColumnType("int");

                    b.Property<Guid?>("PersonId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("SavingAccountId");

                    b.HasIndex("PersonId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("WCS_capitalism_simulator.SavingAccount", b =>
                {
                    b.HasOne("WCS_capitalism_simulator.Person", null)
                        .WithMany("Accounts")
                        .HasForeignKey("PersonId");
                });

            modelBuilder.Entity("WCS_capitalism_simulator.Person", b =>
                {
                    b.Navigation("Accounts");
                });
#pragma warning restore 612, 618
        }
    }
}
