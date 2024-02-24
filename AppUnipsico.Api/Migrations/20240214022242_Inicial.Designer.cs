﻿// <auto-generated />
using System;
using AppUnipsico.Api.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AppUnipsico.Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240214022242_Inicial")]
    partial class Inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AppUnipsico.Api.Models.AddressModel", b =>
                {
                    b.Property<Guid>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Neighborhood")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PublicPlace")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Town")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.HasKey("AddressId");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("AppUnipsico.Api.Models.ConsultModel", b =>
                {
                    b.Property<Guid>("ConsultId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("ConsultStatus")
                        .HasColumnType("int");

                    b.Property<Guid>("PatientId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("TeacherId")
                        .HasColumnType("char(36)");

                    b.HasKey("ConsultId");

                    b.HasIndex("PatientId");

                    b.HasIndex("StudentId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Consults");
                });

            modelBuilder.Entity("AppUnipsico.Api.Models.InstitutionModel", b =>
                {
                    b.Property<Guid>("InstitutionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("AddressId")
                        .HasColumnType("char(36)");

                    b.Property<string>("InstitutionName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("InstitutionId");

                    b.HasIndex("AddressId")
                        .IsUnique();

                    b.ToTable("Institutions");
                });

            modelBuilder.Entity("AppUnipsico.Api.Models.StageModel", b =>
                {
                    b.Property<Guid>("StageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("DateStage")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("InstitutionId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("TeacherId")
                        .HasColumnType("char(36)");

                    b.HasKey("StageId");

                    b.HasIndex("InstitutionId");

                    b.HasIndex("StudentId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Stages");
                });

            modelBuilder.Entity("AppUnipsico.Api.Models.UsuarioModel", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UserCpf")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("UserDateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("UserDateOfBirth")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("UserDisplayName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<bool>("UserIsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("UserTypeId")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.HasIndex("UserCpf")
                        .IsUnique();

                    b.HasIndex("UserEmail")
                        .IsUnique();

                    b.HasIndex("UserTypeId")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasDiscriminator<string>("Discriminator").HasValue("UsuarioModel");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("AppUnipsico.Api.Models.UserTypeModel", b =>
                {
                    b.Property<int>("UserTypeModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("UserTypeDateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("UserTypeDescription")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("UserTypeIsAdmin")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserTypeName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("UserTypeModelId");

                    b.ToTable("UserTypes");

                    b.HasData(
                        new
                        {
                            UserTypeModelId = 1,
                            UserTypeDateCreated = new DateTime(2024, 2, 13, 23, 22, 42, 390, DateTimeKind.Local).AddTicks(4614),
                            UserTypeDescription = "Paciente do consultório",
                            UserTypeIsAdmin = false,
                            UserTypeName = "Paciente"
                        },
                        new
                        {
                            UserTypeModelId = 2,
                            UserTypeDateCreated = new DateTime(2024, 2, 13, 23, 22, 42, 390, DateTimeKind.Local).AddTicks(4630),
                            UserTypeDescription = "Aluno de Psicologia",
                            UserTypeIsAdmin = false,
                            UserTypeName = "Aluno"
                        },
                        new
                        {
                            UserTypeModelId = 3,
                            UserTypeDateCreated = new DateTime(2024, 2, 13, 23, 22, 42, 390, DateTimeKind.Local).AddTicks(4632),
                            UserTypeDescription = "Professor e Admin",
                            UserTypeIsAdmin = true,
                            UserTypeName = "Professor"
                        });
                });

            modelBuilder.Entity("AppUnipsico.Api.Models.PatientModel", b =>
                {
                    b.HasBaseType("AppUnipsico.Api.Models.UsuarioModel");

                    b.HasDiscriminator().HasValue("PatientModel");
                });

            modelBuilder.Entity("AppUnipsico.Api.Models.StudentModel", b =>
                {
                    b.HasBaseType("AppUnipsico.Api.Models.UsuarioModel");

                    b.HasDiscriminator().HasValue("StudentModel");
                });

            modelBuilder.Entity("AppUnipsico.Api.Models.TeacherModel", b =>
                {
                    b.HasBaseType("AppUnipsico.Api.Models.UsuarioModel");

                    b.HasDiscriminator().HasValue("TeacherModel");
                });

            modelBuilder.Entity("AppUnipsico.Api.Models.ConsultModel", b =>
                {
                    b.HasOne("AppUnipsico.Api.Models.PatientModel", "Patient")
                        .WithMany("Consults")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppUnipsico.Api.Models.StudentModel", "Student")
                        .WithMany("Consults")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppUnipsico.Api.Models.TeacherModel", "Teacher")
                        .WithMany("Consults")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");

                    b.Navigation("Student");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("AppUnipsico.Api.Models.InstitutionModel", b =>
                {
                    b.HasOne("AppUnipsico.Api.Models.AddressModel", "Address")
                        .WithOne("Institution")
                        .HasForeignKey("AppUnipsico.Api.Models.InstitutionModel", "AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("AppUnipsico.Api.Models.StageModel", b =>
                {
                    b.HasOne("AppUnipsico.Api.Models.InstitutionModel", "Institution")
                        .WithMany("Stages")
                        .HasForeignKey("InstitutionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppUnipsico.Api.Models.StudentModel", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppUnipsico.Api.Models.TeacherModel", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Institution");

                    b.Navigation("Student");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("AppUnipsico.Api.Models.UsuarioModel", b =>
                {
                    b.HasOne("AppUnipsico.Api.Models.UserTypeModel", "UserType")
                        .WithOne("UserModel")
                        .HasForeignKey("AppUnipsico.Api.Models.UsuarioModel", "UserTypeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("UserType");
                });

            modelBuilder.Entity("AppUnipsico.Api.Models.AddressModel", b =>
                {
                    b.Navigation("Institution");
                });

            modelBuilder.Entity("AppUnipsico.Api.Models.InstitutionModel", b =>
                {
                    b.Navigation("Stages");
                });

            modelBuilder.Entity("AppUnipsico.Api.Models.UserTypeModel", b =>
                {
                    b.Navigation("UserModel")
                        .IsRequired();
                });

            modelBuilder.Entity("AppUnipsico.Api.Models.PatientModel", b =>
                {
                    b.Navigation("Consults");
                });

            modelBuilder.Entity("AppUnipsico.Api.Models.StudentModel", b =>
                {
                    b.Navigation("Consults");
                });

            modelBuilder.Entity("AppUnipsico.Api.Models.TeacherModel", b =>
                {
                    b.Navigation("Consults");
                });
#pragma warning restore 612, 618
        }
    }
}
