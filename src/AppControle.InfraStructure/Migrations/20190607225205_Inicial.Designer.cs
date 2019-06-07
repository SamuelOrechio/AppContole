﻿// <auto-generated />
using AppControle.InfraStructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AppControle.InfraStructure.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20190607225205_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AppControle.AplicationCore.Entity.Pessoa", b =>
                {
                    b.Property<int>("PessoaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PessoaTipoId");

                    b.HasKey("PessoaId");

                    b.HasIndex("PessoaTipoId");

                    b.ToTable("Pessoa");
                });

            modelBuilder.Entity("AppControle.AplicationCore.Entity.PessoaTipo", b =>
                {
                    b.Property<int>("PessoaTipoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("Varchar(50)");

                    b.HasKey("PessoaTipoId");

                    b.ToTable("PessoaTipo");
                });

            modelBuilder.Entity("AppControle.AplicationCore.Entity.Pessoa", b =>
                {
                    b.HasOne("AppControle.AplicationCore.Entity.PessoaTipo", "PessoaTipo")
                        .WithMany()
                        .HasForeignKey("PessoaTipoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
