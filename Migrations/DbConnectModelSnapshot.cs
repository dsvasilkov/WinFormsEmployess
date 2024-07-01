﻿// <auto-generated />
using System;
using EmployeeFormsApp;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace EmployeeFormsApp.Migrations
{
    [DbContext(typeof(DbConnect))]
    partial class DbConnectModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("EmployeeFormsApp.Branch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Location")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("EmployeeFormsApp.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Head")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("EmployeeFormsApp.Education", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("DateGrade")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("EducationLevel")
                        .HasColumnType("text");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("integer");

                    b.Property<string>("Institution")
                        .HasColumnType("text");

                    b.Property<string>("Specialization")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Educations");
                });

            modelBuilder.Entity("EmployeeFormsApp.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Adress")
                        .HasColumnType("text");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("BranchId")
                        .HasColumnType("integer");

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("integer");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Gender")
                        .HasColumnType("text");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("INN")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("PassportIssueBy")
                        .HasColumnType("text");

                    b.Property<DateTime>("PassportIssueDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("PassportNumber")
                        .HasColumnType("integer");

                    b.Property<int>("PassportSeries")
                        .HasColumnType("integer");

                    b.Property<string>("Patronymic")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<string>("PhotoPath")
                        .HasColumnType("text");

                    b.Property<string>("PlasceOfReg")
                        .HasColumnType("text");

                    b.Property<string>("Surname")
                        .HasColumnType("text");

                    b.Property<int>("snils")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("EmployeeFormsApp.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("Salary")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("EmployeeFormsApp.PositionInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("integer");

                    b.Property<int?>("PositionId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("PositionId");

                    b.ToTable("PositionInfos");
                });

            modelBuilder.Entity("EmployeeFormsApp.Education", b =>
                {
                    b.HasOne("EmployeeFormsApp.Employee", "Employee")
                        .WithMany("Educations")
                        .HasForeignKey("EmployeeId");
                });

            modelBuilder.Entity("EmployeeFormsApp.Employee", b =>
                {
                    b.HasOne("EmployeeFormsApp.Branch", "Branch")
                        .WithMany("Employees")
                        .HasForeignKey("BranchId");

                    b.HasOne("EmployeeFormsApp.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId");
                });

            modelBuilder.Entity("EmployeeFormsApp.PositionInfo", b =>
                {
                    b.HasOne("EmployeeFormsApp.Employee", "Employee")
                        .WithMany("PositionInfos")
                        .HasForeignKey("EmployeeId");

                    b.HasOne("EmployeeFormsApp.Position", "Position")
                        .WithMany("PositionInfos")
                        .HasForeignKey("PositionId");
                });
#pragma warning restore 612, 618
        }
    }
}