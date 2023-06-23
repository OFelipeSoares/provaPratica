﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TargetWorkTask.Models;

#nullable disable

namespace TargetWorkTask.Migrations
{
    [DbContext(typeof(BancoDeDados))]
    partial class BancoDeDadosModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TargetWorkTask.Models.BaseId", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BaseId");

                    b.HasDiscriminator<string>("Discriminator").HasValue("BaseId");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("TargetWorkTask.Models.Category", b =>
                {
                    b.HasBaseType("TargetWorkTask.Models.BaseId");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Category");
                });

            modelBuilder.Entity("TargetWorkTask.Models.Cliente", b =>
                {
                    b.HasBaseType("TargetWorkTask.Models.BaseId");

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("BaseId", t =>
                        {
                            t.Property("Nome")
                                .HasColumnName("Cliente_Nome");
                        });

                    b.HasDiscriminator().HasValue("Cliente");
                });

            modelBuilder.Entity("TargetWorkTask.Models.Produtos", b =>
                {
                    b.HasBaseType("TargetWorkTask.Models.BaseId");

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("IdCategory")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasIndex("CategoryId");

                    b.ToTable("BaseId", t =>
                        {
                            t.Property("Ativo")
                                .HasColumnName("Produtos_Ativo");

                            t.Property("Nome")
                                .HasColumnName("Produtos_Nome");
                        });

                    b.HasDiscriminator().HasValue("Produtos");
                });

            modelBuilder.Entity("TargetWorkTask.Models.Produtos", b =>
                {
                    b.HasOne("TargetWorkTask.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
