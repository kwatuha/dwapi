﻿// <auto-generated />
using Dwapi.ExtractsManagement.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Dwapi.ExtractsManagement.Infrastructure.Migrations
{
    [DbContext(typeof(ExtractsContext))]
    [Migration("20180214074716_ExtractsInitial")]
    partial class ExtractsInitial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Dwapi.ExtractsManagement.Core.Model.Extract", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Display")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Extracts");
                });

            modelBuilder.Entity("Dwapi.ExtractsManagement.Core.Model.ExtractHistory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateFound");

                    b.Property<DateTime>("DateLoaded");

                    b.Property<DateTime>("DateQueued");

                    b.Property<DateTime>("DateSent");

                    b.Property<Guid>("ExtractId");

                    b.Property<int>("Found");

                    b.Property<int>("Loaded");

                    b.Property<int>("Queued");

                    b.Property<int>("Rejected");

                    b.Property<int>("Sent");

                    b.Property<string>("Status")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("ExtractId");

                    b.ToTable("ExtractHistories");
                });

            modelBuilder.Entity("Dwapi.ExtractsManagement.Core.Model.Stage.Psmart.PsmartStage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("DateExtracted");

                    b.Property<DateTime>("DateStaged");

                    b.Property<string>("Demographics")
                        .HasMaxLength(100);

                    b.Property<string>("Emr")
                        .HasMaxLength(50);

                    b.Property<string>("Encounters")
                        .HasMaxLength(100);

                    b.Property<int?>("FacilityCode");

                    b.Property<string>("Serial")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("PsmartStages");
                });

            modelBuilder.Entity("Dwapi.ExtractsManagement.Core.Model.ExtractHistory", b =>
                {
                    b.HasOne("Dwapi.ExtractsManagement.Core.Model.Extract")
                        .WithMany("ExtractHistories")
                        .HasForeignKey("ExtractId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
