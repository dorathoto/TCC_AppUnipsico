﻿// <auto-generated />
using System;
using AppUnipsico.Api.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AppUnipsico.Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AppUnipsico.Api.Modelos.DataConsultaModel", b =>
                {
                    b.Property<Guid>("DataConsultaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("ConsultaId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("DataConsulta")
                        .HasColumnType("datetime(6)");

                    b.HasKey("DataConsultaId");

                    b.HasIndex("ConsultaId")
                        .IsUnique();

                    b.ToTable("DatasConsultas");
                });

            modelBuilder.Entity("AppUnipsico.Api.Models.ConsultaModel", b =>
                {
                    b.Property<Guid>("ConsultaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("ConsultaStatus")
                        .HasColumnType("int");

                    b.Property<Guid>("DataConsultaId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("PacienteId")
                        .HasColumnType("char(36)");

                    b.HasKey("ConsultaId");

                    b.HasIndex("PacienteId");

                    b.ToTable("Consultas");
                });

            modelBuilder.Entity("AppUnipsico.Api.Models.EnderecoModel", b =>
                {
                    b.Property<Guid>("EnderecoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("EnderecoId");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("AppUnipsico.Api.Models.EstagioModel", b =>
                {
                    b.Property<Guid>("EstagioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("AlunoId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("EstagioDataRealizacao")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("InstituicaoId")
                        .HasColumnType("char(36)");

                    b.HasKey("EstagioId");

                    b.HasIndex("AlunoId");

                    b.HasIndex("InstituicaoId");

                    b.ToTable("Estagios");
                });

            modelBuilder.Entity("AppUnipsico.Api.Models.InstituicaoModel", b =>
                {
                    b.Property<Guid>("InstituicaoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("EnderecoId")
                        .HasColumnType("char(36)");

                    b.Property<string>("InstituicaoNome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("InstituicaoId");

                    b.HasIndex("EnderecoId")
                        .IsUnique();

                    b.ToTable("Instituicoes");
                });

            modelBuilder.Entity("AppUnipsico.Api.Models.TipoUsuarioModel", b =>
                {
                    b.Property<int>("TipoUsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("TipoUsuarioDataRegistro")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("TipoUsuarioDescricao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("TipoUsuarioEhAdmin")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("TipoUsuarioNome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("TipoUsuarioId");

                    b.ToTable("TiposUsuarios");

                    b.HasData(
                        new
                        {
                            TipoUsuarioId = 1,
                            TipoUsuarioDataRegistro = new DateTime(2024, 2, 26, 2, 58, 27, 142, DateTimeKind.Local).AddTicks(1681),
                            TipoUsuarioDescricao = "Paciente do consultório",
                            TipoUsuarioEhAdmin = false,
                            TipoUsuarioNome = "Paciente"
                        },
                        new
                        {
                            TipoUsuarioId = 2,
                            TipoUsuarioDataRegistro = new DateTime(2024, 2, 26, 2, 58, 27, 142, DateTimeKind.Local).AddTicks(1705),
                            TipoUsuarioDescricao = "Aluno de Psicologia",
                            TipoUsuarioEhAdmin = false,
                            TipoUsuarioNome = "Aluno"
                        },
                        new
                        {
                            TipoUsuarioId = 3,
                            TipoUsuarioDataRegistro = new DateTime(2024, 2, 26, 2, 58, 27, 142, DateTimeKind.Local).AddTicks(1707),
                            TipoUsuarioDescricao = "Professor e Admin",
                            TipoUsuarioEhAdmin = true,
                            TipoUsuarioNome = "Professor"
                        });
                });

            modelBuilder.Entity("AppUnipsico.Api.Models.UsuarioModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<bool>("Ativo")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataRegistro")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("TipoUsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Cpf")
                        .IsUnique();

                    b.HasIndex("TipoUsuarioId");

                    b.ToTable("Usuarios");

                    b.HasDiscriminator<string>("Discriminator").HasValue("UsuarioModel");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("AppUnipsico.Api.Models.PacienteModel", b =>
                {
                    b.HasBaseType("AppUnipsico.Api.Models.UsuarioModel");

                    b.HasDiscriminator().HasValue("PacienteModel");
                });

            modelBuilder.Entity("AppUnipsico.Api.Modelos.DataConsultaModel", b =>
                {
                    b.HasOne("AppUnipsico.Api.Models.ConsultaModel", "Consulta")
                        .WithOne("DataConsulta")
                        .HasForeignKey("AppUnipsico.Api.Modelos.DataConsultaModel", "ConsultaId");

                    b.Navigation("Consulta");
                });

            modelBuilder.Entity("AppUnipsico.Api.Models.ConsultaModel", b =>
                {
                    b.HasOne("AppUnipsico.Api.Models.PacienteModel", "Paciente")
                        .WithMany("Consultas")
                        .HasForeignKey("PacienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("AppUnipsico.Api.Models.EstagioModel", b =>
                {
                    b.HasOne("AppUnipsico.Api.Models.UsuarioModel", "Aluno")
                        .WithMany()
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppUnipsico.Api.Models.InstituicaoModel", "Instituicao")
                        .WithMany("Estagio")
                        .HasForeignKey("InstituicaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aluno");

                    b.Navigation("Instituicao");
                });

            modelBuilder.Entity("AppUnipsico.Api.Models.InstituicaoModel", b =>
                {
                    b.HasOne("AppUnipsico.Api.Models.EnderecoModel", "Endereco")
                        .WithOne("Instituicao")
                        .HasForeignKey("AppUnipsico.Api.Models.InstituicaoModel", "EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("AppUnipsico.Api.Models.UsuarioModel", b =>
                {
                    b.HasOne("AppUnipsico.Api.Models.TipoUsuarioModel", "TipoUsuario")
                        .WithMany()
                        .HasForeignKey("TipoUsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoUsuario");
                });

            modelBuilder.Entity("AppUnipsico.Api.Models.ConsultaModel", b =>
                {
                    b.Navigation("DataConsulta")
                        .IsRequired();
                });

            modelBuilder.Entity("AppUnipsico.Api.Models.EnderecoModel", b =>
                {
                    b.Navigation("Instituicao");
                });

            modelBuilder.Entity("AppUnipsico.Api.Models.InstituicaoModel", b =>
                {
                    b.Navigation("Estagio");
                });

            modelBuilder.Entity("AppUnipsico.Api.Models.PacienteModel", b =>
                {
                    b.Navigation("Consultas");
                });
#pragma warning restore 612, 618
        }
    }
}
