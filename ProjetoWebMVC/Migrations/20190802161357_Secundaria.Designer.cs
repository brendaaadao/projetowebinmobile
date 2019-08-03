﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoWebMVC.Models;

namespace ProjetoWebMVC.Migrations
{
    [DbContext(typeof(ProjetoWebMVCContext))]
    [Migration("20190802161357_Secundaria")]
    partial class Secundaria
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ProjetoWebMVC.Models.Candidato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("DepartamentoId");

                    b.Property<string>("Email");

                    b.Property<string>("Nome");

                    b.Property<double>("PretSalarial");

                    b.Property<double>("Telefone");

                    b.HasKey("Id");

                    b.HasIndex("DepartamentoId");

                    b.ToTable("Candidato");
                });

            modelBuilder.Entity("ProjetoWebMVC.Models.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Departamento");
                });

            modelBuilder.Entity("ProjetoWebMVC.Models.Candidato", b =>
                {
                    b.HasOne("ProjetoWebMVC.Models.Departamento")
                        .WithMany("Candidatos")
                        .HasForeignKey("DepartamentoId");
                });
#pragma warning restore 612, 618
        }
    }
}