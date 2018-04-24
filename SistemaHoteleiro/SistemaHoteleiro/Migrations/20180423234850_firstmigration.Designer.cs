﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using SistemaHoteleiro.Models;
using System;

namespace SistemaHoteleiro.Migrations
{
    [DbContext(typeof(SistemaHoteleiroContexto))]
    [Migration("20180423234850_firstmigration")]
    partial class firstmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SistemaHoteleiro.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.Property<decimal>("valor");

                    b.HasKey("Id");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("SistemaHoteleiro.Models.CheckinCheckout", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataHoraCheckin");

                    b.Property<DateTime>("DataHoraCheckout");

                    b.Property<int>("FuncionarioId");

                    b.Property<int>("ReservaId");

                    b.Property<decimal>("TotalPagar");

                    b.HasKey("Id");

                    b.HasIndex("FuncionarioId");

                    b.HasIndex("ReservaId");

                    b.ToTable("CheckinsCheckouts");
                });

            modelBuilder.Entity("SistemaHoteleiro.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<int>("PessoaId");

                    b.HasKey("Id");

                    b.HasIndex("PessoaId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("SistemaHoteleiro.Models.ClienteTelefone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClienteId");

                    b.Property<string>("Telefone");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("ClienteTelefones");
                });

            modelBuilder.Entity("SistemaHoteleiro.Models.Funcionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("HotelId");

                    b.Property<int>("PessoaId");

                    b.Property<decimal>("Salario");

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.HasIndex("PessoaId");

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("SistemaHoteleiro.Models.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bairro");

                    b.Property<string>("Cidade");

                    b.Property<string>("Nome");

                    b.Property<string>("Rua");

                    b.HasKey("Id");

                    b.ToTable("Hoteis");
                });

            modelBuilder.Entity("SistemaHoteleiro.Models.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bairro");

                    b.Property<string>("Cidade");

                    b.Property<string>("Cpf");

                    b.Property<DateTime>("DataNasc");

                    b.Property<string>("Nome");

                    b.Property<string>("Rua");

                    b.HasKey("Id");

                    b.ToTable("Pessoas");
                });

            modelBuilder.Entity("SistemaHoteleiro.Models.Quarto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoriaId");

                    b.Property<string>("Descricao");

                    b.Property<bool>("Disponibilidade");

                    b.Property<int>("HotelId");

                    b.Property<int>("MaxPessoas");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("HotelId");

                    b.ToTable("Quartos");
                });

            modelBuilder.Entity("SistemaHoteleiro.Models.Reserva", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClienteId");

                    b.Property<DateTime>("DataHoraFinal");

                    b.Property<DateTime>("DataHoraInicio");

                    b.Property<int>("QuartoId");

                    b.Property<int>("TipoReservaId");

                    b.Property<decimal>("Valor");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("QuartoId");

                    b.HasIndex("TipoReservaId");

                    b.ToTable("Reservas");
                });

            modelBuilder.Entity("SistemaHoteleiro.Models.ReservaServico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Data");

                    b.Property<int>("Qtde");

                    b.Property<int>("ReservaId");

                    b.Property<int>("ServicoId");

                    b.HasKey("Id");

                    b.HasIndex("ReservaId");

                    b.HasIndex("ServicoId");

                    b.ToTable("ReservaServicos");
                });

            modelBuilder.Entity("SistemaHoteleiro.Models.Servico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.Property<decimal>("Valor");

                    b.HasKey("Id");

                    b.ToTable("Servicos");
                });

            modelBuilder.Entity("SistemaHoteleiro.Models.TipoReserva", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.Property<decimal>("Valor");

                    b.HasKey("Id");

                    b.ToTable("TiposReservas");
                });

            modelBuilder.Entity("SistemaHoteleiro.Models.CheckinCheckout", b =>
                {
                    b.HasOne("SistemaHoteleiro.Models.Funcionario", "Funcionario")
                        .WithMany("CheckinsCheckouts")
                        .HasForeignKey("FuncionarioId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SistemaHoteleiro.Models.Reserva", "Reserva")
                        .WithMany("CheckinsCheckouts")
                        .HasForeignKey("ReservaId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("SistemaHoteleiro.Models.Cliente", b =>
                {
                    b.HasOne("SistemaHoteleiro.Models.Pessoa", "Pessoa")
                        .WithMany("Clientes")
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SistemaHoteleiro.Models.ClienteTelefone", b =>
                {
                    b.HasOne("SistemaHoteleiro.Models.Cliente", "Cliente")
                        .WithMany("ClienteTelefones")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SistemaHoteleiro.Models.Funcionario", b =>
                {
                    b.HasOne("SistemaHoteleiro.Models.Hotel", "Hotel")
                        .WithMany("Funcionarios")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SistemaHoteleiro.Models.Pessoa", "Pessoa")
                        .WithMany("Funcionarios")
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SistemaHoteleiro.Models.Quarto", b =>
                {
                    b.HasOne("SistemaHoteleiro.Models.Categoria", "Categoria")
                        .WithMany("Quartos")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SistemaHoteleiro.Models.Hotel", "Hotel")
                        .WithMany("Quartos")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SistemaHoteleiro.Models.Reserva", b =>
                {
                    b.HasOne("SistemaHoteleiro.Models.Cliente", "Cliente")
                        .WithMany("Reservas")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SistemaHoteleiro.Models.Quarto", "Quarto")
                        .WithMany("Reservas")
                        .HasForeignKey("QuartoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SistemaHoteleiro.Models.TipoReserva", "TipoReserva")
                        .WithMany("Reservas")
                        .HasForeignKey("TipoReservaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SistemaHoteleiro.Models.ReservaServico", b =>
                {
                    b.HasOne("SistemaHoteleiro.Models.Reserva", "Reserva")
                        .WithMany("ReservaServicos")
                        .HasForeignKey("ReservaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SistemaHoteleiro.Models.Servico", "Servico")
                        .WithMany("ReservaServicos")
                        .HasForeignKey("ServicoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
