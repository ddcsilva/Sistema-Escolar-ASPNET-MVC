﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaEscolar.Data.Context;

#nullable disable

namespace SistemaEscolar.Data.Migrations
{
    [DbContext(typeof(SistemaEscolarContext))]
    partial class SistemaEscolarContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SistemaEscolar.Business.Models.Aluno", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("varchar(11)");

                    b.Property<DateTime>("DataMatricula")
                        .HasColumnType("date");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DataSaida")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Foto")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<int>("Sexo")
                        .HasColumnType("int");

                    b.Property<string>("Telefone")
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Alunos", (string)null);
                });

            modelBuilder.Entity("SistemaEscolar.Business.Models.Endereco", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AlunoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("varchar(8)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("AlunoId")
                        .IsUnique()
                        .HasDatabaseName("IX_Endereco_AlunoId");

                    b.ToTable("Enderecos", (string)null);
                });

            modelBuilder.Entity("SistemaEscolar.Business.Models.Endereco", b =>
                {
                    b.HasOne("SistemaEscolar.Business.Models.Aluno", "Aluno")
                        .WithOne("Endereco")
                        .HasForeignKey("SistemaEscolar.Business.Models.Endereco", "AlunoId")
                        .IsRequired()
                        .HasConstraintName("FK_Aluno_Endereco");

                    b.Navigation("Aluno");
                });

            modelBuilder.Entity("SistemaEscolar.Business.Models.Aluno", b =>
                {
                    b.Navigation("Endereco")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}