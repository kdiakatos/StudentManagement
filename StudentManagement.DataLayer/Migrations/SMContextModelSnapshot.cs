﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentManagement.DataLayer;

namespace StudentManagement.DataLayer.Migrations
{
    [DbContext(typeof(SMContext))]
    partial class SMContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("StudentManagement.DataLayer.Entities.Discipline", b =>
                {
                    b.Property<Guid>("DisciplineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DisciplineName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfesorName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DisciplineId");

                    b.ToTable("Disciplines");

                    b.HasData(
                        new
                        {
                            DisciplineId = new Guid("a2b07a95-f621-47bb-4da4-08d8cb7c4d1a"),
                            DisciplineName = "Architecture 101",
                            ProfesorName = "Ted Mosby"
                        },
                        new
                        {
                            DisciplineId = new Guid("4eb64dfd-258b-4a90-9334-9d5ae32b6b5f"),
                            DisciplineName = "Math 102",
                            ProfesorName = "Barney Stinson"
                        });
                });

            modelBuilder.Entity("StudentManagement.DataLayer.Entities.Semester", b =>
                {
                    b.Property<Guid>("SemesterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("SemesterId");

                    b.ToTable("Semesters");

                    b.HasData(
                        new
                        {
                            SemesterId = new Guid("20e30074-7687-4101-4f07-08d8cb80e9b4"),
                            EndDate = new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Semester 1",
                            StartDate = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            SemesterId = new Guid("e759923c-d499-4548-4f08-08d8cb80e9b4"),
                            EndDate = new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Semester 2",
                            StartDate = new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("StudentManagement.DataLayer.Entities.SemesterDiscipline", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DisciplineId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SemesterId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("DisciplineId");

                    b.HasIndex("SemesterId");

                    b.ToTable("SemesterDisciplines");

                    b.HasData(
                        new
                        {
                            Id = new Guid("20e30074-7687-4191-4f07-08d8cb80e9b4"),
                            DisciplineId = new Guid("a2b07a95-f621-47bb-4da4-08d8cb7c4d1a"),
                            SemesterId = new Guid("20e30074-7687-4101-4f07-08d8cb80e9b4")
                        },
                        new
                        {
                            Id = new Guid("20e30074-7687-4101-4f17-08d8cb80e9b4"),
                            DisciplineId = new Guid("4eb64dfd-258b-4a90-9334-9d5ae32b6b5f"),
                            SemesterId = new Guid("20e30074-7687-4101-4f07-08d8cb80e9b4")
                        });
                });

            modelBuilder.Entity("StudentManagement.DataLayer.Entities.Student", b =>
                {
                    b.Property<Guid>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"),
                            DateOfBirth = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "John",
                            LastName = "Doe"
                        },
                        new
                        {
                            StudentId = new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6"),
                            DateOfBirth = new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Jane",
                            LastName = "Doe"
                        });
                });

            modelBuilder.Entity("StudentManagement.DataLayer.Entities.StudentDiscipline", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DisciplineId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Score")
                        .HasColumnType("float");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("DisciplineId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentDisciplines");

                    b.HasData(
                        new
                        {
                            Id = new Guid("20e30074-7687-4001-4f07-08d8cb80e9b4"),
                            DisciplineId = new Guid("4eb64dfd-258b-4a90-9334-9d5ae32b6b5f"),
                            Score = 4.0,
                            StudentId = new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6")
                        },
                        new
                        {
                            Id = new Guid("20e30074-7687-4101-4f07-08d8cb70e9b4"),
                            DisciplineId = new Guid("a2b07a95-f621-47bb-4da4-08d8cb7c4d1a"),
                            Score = 2.0,
                            StudentId = new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6")
                        });
                });

            modelBuilder.Entity("StudentManagement.DataLayer.Entities.StudentSemester", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SemesterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("SemesterId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentSemesters");

                    b.HasData(
                        new
                        {
                            Id = new Guid("20e30074-7687-4101-4f07-08d8cb80e9c4"),
                            SemesterId = new Guid("20e30074-7687-4101-4f07-08d8cb80e9b4"),
                            StudentId = new Guid("1fa85f64-5717-4562-b3fc-2c963f66afa6")
                        });
                });

            modelBuilder.Entity("StudentManagement.DataLayer.Entities.SemesterDiscipline", b =>
                {
                    b.HasOne("StudentManagement.DataLayer.Entities.Discipline", "Discipline")
                        .WithMany("SemesterDisciplines")
                        .HasForeignKey("DisciplineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentManagement.DataLayer.Entities.Semester", "Semester")
                        .WithMany("SemesterDisciplines")
                        .HasForeignKey("SemesterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Discipline");

                    b.Navigation("Semester");
                });

            modelBuilder.Entity("StudentManagement.DataLayer.Entities.StudentDiscipline", b =>
                {
                    b.HasOne("StudentManagement.DataLayer.Entities.Discipline", "Discipline")
                        .WithMany("StudentDisciplines")
                        .HasForeignKey("DisciplineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentManagement.DataLayer.Entities.Student", "Student")
                        .WithMany("StudentDisciplines")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Discipline");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("StudentManagement.DataLayer.Entities.StudentSemester", b =>
                {
                    b.HasOne("StudentManagement.DataLayer.Entities.Semester", "Semester")
                        .WithMany("StudentSemesters")
                        .HasForeignKey("SemesterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentManagement.DataLayer.Entities.Student", "Student")
                        .WithMany("StudentSemesters")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Semester");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("StudentManagement.DataLayer.Entities.Discipline", b =>
                {
                    b.Navigation("SemesterDisciplines");

                    b.Navigation("StudentDisciplines");
                });

            modelBuilder.Entity("StudentManagement.DataLayer.Entities.Semester", b =>
                {
                    b.Navigation("SemesterDisciplines");

                    b.Navigation("StudentSemesters");
                });

            modelBuilder.Entity("StudentManagement.DataLayer.Entities.Student", b =>
                {
                    b.Navigation("StudentDisciplines");

                    b.Navigation("StudentSemesters");
                });
#pragma warning restore 612, 618
        }
    }
}
