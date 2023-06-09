﻿// <auto-generated />
using MVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVC.Migrations
{
    [DbContext(typeof(EducationContext))]
    partial class EducationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MVC.Models.Course", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("Dept_ID")
                        .HasColumnType("int");

                    b.Property<int>("degree")
                        .HasColumnType("int");

                    b.Property<int>("mindegree")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("Dept_ID");

                    b.ToTable("courses");
                });

            modelBuilder.Entity("MVC.Models.CrsResult", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("Course_ID")
                        .HasColumnType("int");

                    b.Property<int>("Trainee_ID")
                        .HasColumnType("int");

                    b.Property<int>("degree")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Course_ID");

                    b.HasIndex("Trainee_ID");

                    b.ToTable("crsResults");
                });

            modelBuilder.Entity("MVC.Models.Department", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("manager")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("departments");
                });

            modelBuilder.Entity("MVC.Models.Instructor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("Course_ID")
                        .HasColumnType("int");

                    b.Property<int>("Dept_ID")
                        .HasColumnType("int");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("img")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("salary")
                        .HasColumnType("float");

                    b.HasKey("id");

                    b.HasIndex("Course_ID");

                    b.HasIndex("Dept_ID");

                    b.ToTable("instructors");
                });

            modelBuilder.Entity("MVC.Models.Trainee", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("Dept_ID")
                        .HasColumnType("int");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("grade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("img")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("Dept_ID");

                    b.ToTable("trainees");
                });

            modelBuilder.Entity("MVC.Models.Course", b =>
                {
                    b.HasOne("MVC.Models.Department", "Department")
                        .WithMany("Course")
                        .HasForeignKey("Dept_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("MVC.Models.CrsResult", b =>
                {
                    b.HasOne("MVC.Models.Course", "Course")
                        .WithMany("CrsResult")
                        .HasForeignKey("Course_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVC.Models.Trainee", "Trainee")
                        .WithMany("CrsResult")
                        .HasForeignKey("Trainee_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Trainee");
                });

            modelBuilder.Entity("MVC.Models.Instructor", b =>
                {
                    b.HasOne("MVC.Models.Course", "Course")
                        .WithMany("Instructors")
                        .HasForeignKey("Course_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVC.Models.Department", "Department")
                        .WithMany("Instructors")
                        .HasForeignKey("Dept_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("MVC.Models.Trainee", b =>
                {
                    b.HasOne("MVC.Models.Department", "Department")
                        .WithMany("Trainee")
                        .HasForeignKey("Dept_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("MVC.Models.Course", b =>
                {
                    b.Navigation("CrsResult");

                    b.Navigation("Instructors");
                });

            modelBuilder.Entity("MVC.Models.Department", b =>
                {
                    b.Navigation("Course");

                    b.Navigation("Instructors");

                    b.Navigation("Trainee");
                });

            modelBuilder.Entity("MVC.Models.Trainee", b =>
                {
                    b.Navigation("CrsResult");
                });
#pragma warning restore 612, 618
        }
    }
}
