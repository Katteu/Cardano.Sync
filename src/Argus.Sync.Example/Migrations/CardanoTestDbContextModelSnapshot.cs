﻿// <auto-generated />
using Argus.Sync.Example.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Argus.Sync.Example.Migrations
{
    [DbContext(typeof(CardanoTestDbContext))]
    partial class CardanoTestDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("public")
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Argus.Sync.Data.Models.OutputBySlot", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<long>("Index")
                        .HasColumnType("bigint");

                    b.Property<decimal>("Slot")
                        .HasColumnType("numeric(20,0)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte[]>("DatumData")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<int>("DatumType")
                        .HasColumnType("integer");

                    b.Property<byte[]>("RawCbor")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<byte[]>("ReferenceScript")
                        .HasColumnType("bytea");

                    b.Property<decimal?>("SpentSlot")
                        .HasColumnType("numeric(20,0)");

                    b.Property<int>("UtxoStatus")
                        .HasColumnType("integer");

                    b.HasKey("Id", "Index", "Slot");

                    b.ToTable("OutputBySlot", "public");
                });

            modelBuilder.Entity("Argus.Sync.Data.Models.ReducerState", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Hash")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Slot")
                        .HasColumnType("numeric(20,0)");

                    b.HasKey("Name");

                    b.ToTable("ReducerStates", "public");
                });
#pragma warning restore 612, 618
        }
    }
}
