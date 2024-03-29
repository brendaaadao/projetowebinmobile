﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoWebMVC.Models;

namespace ProjetoWebMVC.Migrations
{
    [DbContext(typeof(ProjetoWebMVCContext))]
    partial class ProjetoWebMVCContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ProjetoWebMVC.Models.Candidato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("Nome");

                    b.Property<double>("PretSalarial");

                    b.Property<double>("Telefone");

                    b.HasKey("Id");

                    b.ToTable("Candidato");
                });

            modelBuilder.Entity("ProjetoWebMVC.Models.CandidatoVaga", b =>
                {
                    b.Property<int>("IdCandidato");

                    b.Property<int>("IdVaga");

                    b.Property<int?>("VagaId");

                    b.HasKey("IdCandidato", "IdVaga");

                    b.HasIndex("VagaId");

                    b.ToTable("CandidatoVaga");
                });

            modelBuilder.Entity("ProjetoWebMVC.Models.Vaga", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.Property<string>("Nome");

                    b.Property<bool>("Status");

                    b.HasKey("Id");

                    b.ToTable("Vaga");
                });

            modelBuilder.Entity("ProjetoWebMVC.Models.CandidatoVaga", b =>
                {
                    b.HasOne("ProjetoWebMVC.Models.Vaga")
                        .WithMany("Candidatos")
                        .HasForeignKey("VagaId");
                });
#pragma warning restore 612, 618
        }
    }
}
