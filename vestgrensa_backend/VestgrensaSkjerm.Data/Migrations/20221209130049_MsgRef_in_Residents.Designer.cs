﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using VestgrensaSkjerm.Data;

#nullable disable

namespace VestgrensaSkjerm.Data.Migrations
{
    [DbContext(typeof(VestgrensaDataContext))]
    [Migration("20221209130049_MsgRef_in_Residents")]
    partial class MsgRef_in_Residents
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-preview.6.22329.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("VestgrensaSkjerm.Common.Models.Message", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<int>("ResidentID")
                        .HasColumnType("integer");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.HasIndex("ResidentID");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("VestgrensaSkjerm.Common.Models.Resident", b =>
                {
                    b.Property<int>("ResidentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ResidentID"));

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("Current")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(true);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Programme")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RoomID")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("University")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ResidentID");

                    b.ToTable("Residents");
                });

            modelBuilder.Entity("VestgrensaSkjerm.Common.Models.Message", b =>
                {
                    b.HasOne("VestgrensaSkjerm.Common.Models.Resident", "Resident")
                        .WithMany("Messages")
                        .HasForeignKey("ResidentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Resident");
                });

            modelBuilder.Entity("VestgrensaSkjerm.Common.Models.Resident", b =>
                {
                    b.Navigation("Messages");
                });
#pragma warning restore 612, 618
        }
    }
}
