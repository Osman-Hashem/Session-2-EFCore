﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Session_2.Contexts;

#nullable disable

namespace Session_2.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250218232856_AddOneToManyRelationship")]
    partial class AddOneToManyRelationship
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Session_2.Entities.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 100L, 100);

                    b.Property<string>("DeptName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("DepartmentName");

                    b.Property<int>("EmpId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmpId")
                        .IsUnique();

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("Session_2.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 10L, 10);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar")
                        .HasColumnName("EmployeeName");

                    b.Property<decimal?>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("WorkForId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WorkForId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Session_2.Entities.Department", b =>
                {
                    b.HasOne("Session_2.Entities.Employee", "Manager")
                        .WithOne("Department")
                        .HasForeignKey("Session_2.Entities.Department", "EmpId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("Session_2.Entities.Employee", b =>
                {
                    b.HasOne("Session_2.Entities.Department", "WorkFor")
                        .WithMany("Employees")
                        .HasForeignKey("WorkForId");

                    b.Navigation("WorkFor");
                });

            modelBuilder.Entity("Session_2.Entities.Department", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("Session_2.Entities.Employee", b =>
                {
                    b.Navigation("Department");
                });
#pragma warning restore 612, 618
        }
    }
}
