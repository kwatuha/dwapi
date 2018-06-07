﻿// <auto-generated />
using System;
using Dwapi.ExtractsManagement.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Dwapi.ExtractsManagement.Infrastructure.Migrations
{
    [DbContext(typeof(ExtractsContext))]
    [Migration("20180607130514_CbsPKSiteCode")]
    partial class CbsPKSiteCode
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Dwapi.ExtractsManagement.Core.Model.Destination.Cbs.MasterPatientIndex", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Birth_Certificate");

                    b.Property<string>("CCC_Number");

                    b.Property<string>("ContactAddress");

                    b.Property<string>("ContactName");

                    b.Property<string>("ContactPhoneNumber");

                    b.Property<string>("ContactRelation");

                    b.Property<DateTime?>("DOB");

                    b.Property<DateTime?>("DateConfirmedHIVPositive");

                    b.Property<DateTime>("DateExtracted");

                    b.Property<string>("FirstName");

                    b.Property<string>("FirstName_Normalized");

                    b.Property<string>("Gender");

                    b.Property<double?>("JaroWinklerScore");

                    b.Property<string>("LastName");

                    b.Property<string>("LastName_Normalized");

                    b.Property<string>("MaritalStatus");

                    b.Property<string>("MiddleName");

                    b.Property<string>("MiddleName_Normalized");

                    b.Property<string>("NHIF_Number");

                    b.Property<string>("National_ID");

                    b.Property<string>("PatientAlternatePhoneNumber");

                    b.Property<string>("PatientCounty");

                    b.Property<string>("PatientID");

                    b.Property<string>("PatientPhoneNumber");

                    b.Property<int>("PatientPk");

                    b.Property<string>("PatientSource");

                    b.Property<string>("PatientSubCounty");

                    b.Property<string>("PatientVillage");

                    b.Property<bool?>("Processed");

                    b.Property<string>("QueueId");

                    b.Property<int>("RowId");

                    b.Property<string>("Serial");

                    b.Property<int>("SiteCode");

                    b.Property<DateTime?>("StartARTDate");

                    b.Property<string>("StartARTRegimenCode");

                    b.Property<string>("StartARTRegimenDesc");

                    b.Property<string>("Status");

                    b.Property<DateTime?>("StatusDate");

                    b.Property<string>("TB_Number");

                    b.Property<string>("dmFirstName");

                    b.Property<string>("dmLastName");

                    b.Property<string>("dmMiddleName");

                    b.Property<string>("dmPKValue");

                    b.Property<string>("dmPKValueDoB");

                    b.Property<string>("sxFirstName");

                    b.Property<string>("sxLastName");

                    b.Property<string>("sxMiddleName");

                    b.Property<string>("sxPKValue");

                    b.Property<string>("sxPKValueDoB");

                    b.Property<string>("sxdmPKValue");

                    b.Property<string>("sxdmPKValueDoB");

                    b.HasKey("Id");

                    b.ToTable("MasterPatientIndices");
                });

            modelBuilder.Entity("Dwapi.ExtractsManagement.Core.Model.Destination.Dwh.PatientExtract", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ContactRelation");

                    b.Property<DateTime?>("DOB");

                    b.Property<DateTime?>("DateConfirmedHIVPositive");

                    b.Property<DateTime?>("DatePreviousARTStart");

                    b.Property<string>("District");

                    b.Property<string>("EducationLevel");

                    b.Property<string>("Emr");

                    b.Property<string>("FacilityName");

                    b.Property<string>("Gender");

                    b.Property<DateTime?>("LastVisit");

                    b.Property<string>("MaritalStatus");

                    b.Property<string>("PatientID");

                    b.Property<int>("PatientPK");

                    b.Property<string>("PatientSource");

                    b.Property<string>("PreviousARTExposure");

                    b.Property<bool?>("Processed");

                    b.Property<string>("Project");

                    b.Property<string>("QueueId");

                    b.Property<string>("Region");

                    b.Property<DateTime?>("RegistrationATPMTCT");

                    b.Property<DateTime?>("RegistrationAtCCC");

                    b.Property<DateTime?>("RegistrationAtTBClinic");

                    b.Property<DateTime?>("RegistrationDate");

                    b.Property<int>("SiteCode");

                    b.Property<string>("Status");

                    b.Property<string>("StatusAtCCC");

                    b.Property<string>("StatusAtPMTCT");

                    b.Property<string>("StatusAtTBClinic");

                    b.Property<DateTime?>("StatusDate");

                    b.Property<string>("Village");

                    b.HasKey("Id");

                    b.ToTable("PatientExtracts");
                });

            modelBuilder.Entity("Dwapi.ExtractsManagement.Core.Model.ExtractHistory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("ExtractId");

                    b.Property<int?>("Stats");

                    b.Property<int>("Status");

                    b.Property<DateTime?>("StatusDate");

                    b.Property<string>("StatusInfo");

                    b.HasKey("Id");

                    b.ToTable("ExtractHistory");
                });

            modelBuilder.Entity("Dwapi.ExtractsManagement.Core.Model.PsmartStage", b =>
                {
                    b.Property<Guid>("EId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("DateExtracted");

                    b.Property<DateTime?>("DateSent");

                    b.Property<DateTime>("DateStaged");

                    b.Property<DateTime?>("Date_Created");

                    b.Property<string>("Emr");

                    b.Property<int?>("Id");

                    b.Property<string>("RequestId");

                    b.Property<string>("Shr");

                    b.Property<string>("Status")
                        .HasMaxLength(100);

                    b.Property<DateTime?>("Status_Date");

                    b.Property<string>("Uuid");

                    b.HasKey("EId");

                    b.ToTable("PsmartStage");
                });

            modelBuilder.Entity("Dwapi.ExtractsManagement.Core.Model.Source.Cbs.TempMasterPatientIndex", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Birth_Certificate");

                    b.Property<string>("CCC_Number");

                    b.Property<bool>("CheckError");

                    b.Property<string>("ContactAddress");

                    b.Property<string>("ContactName");

                    b.Property<string>("ContactPhoneNumber");

                    b.Property<string>("ContactRelation");

                    b.Property<DateTime?>("DOB");

                    b.Property<DateTime?>("DateConfirmedHIVPositive");

                    b.Property<DateTime>("DateExtracted");

                    b.Property<string>("FirstName");

                    b.Property<string>("FirstName_Normalized");

                    b.Property<string>("Gender");

                    b.Property<double?>("JaroWinklerScore");

                    b.Property<string>("LastName");

                    b.Property<string>("LastName_Normalized");

                    b.Property<string>("MaritalStatus");

                    b.Property<string>("MiddleName");

                    b.Property<string>("MiddleName_Normalized");

                    b.Property<string>("NHIF_Number");

                    b.Property<string>("National_ID");

                    b.Property<string>("PatientAlternatePhoneNumber");

                    b.Property<string>("PatientCounty");

                    b.Property<string>("PatientID");

                    b.Property<string>("PatientPhoneNumber");

                    b.Property<int?>("PatientPk");

                    b.Property<string>("PatientSource");

                    b.Property<string>("PatientSubCounty");

                    b.Property<string>("PatientVillage");

                    b.Property<int>("RowId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Serial");

                    b.Property<int?>("SiteCode");

                    b.Property<DateTime?>("StartARTDate");

                    b.Property<string>("StartARTRegimenCode");

                    b.Property<string>("StartARTRegimenDesc");

                    b.Property<string>("TB_Number");

                    b.Property<string>("dmFirstName");

                    b.Property<string>("dmLastName");

                    b.Property<string>("dmMiddleName");

                    b.Property<string>("dmPKValue");

                    b.Property<string>("dmPKValueDoB");

                    b.Property<string>("sxFirstName");

                    b.Property<string>("sxLastName");

                    b.Property<string>("sxMiddleName");

                    b.Property<string>("sxPKValue");

                    b.Property<string>("sxPKValueDoB");

                    b.Property<string>("sxdmPKValue");

                    b.Property<string>("sxdmPKValueDoB");

                    b.HasKey("Id");

                    b.ToTable("TempMasterPatientIndices");
                });

            modelBuilder.Entity("Dwapi.ExtractsManagement.Core.Model.Source.Dwh.TempPatientExtract", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("CheckError");

                    b.Property<string>("ContactRelation");

                    b.Property<DateTime?>("DOB");

                    b.Property<DateTime?>("DateConfirmedHIVPositive");

                    b.Property<DateTime>("DateExtracted");

                    b.Property<string>("District");

                    b.Property<string>("EMR");

                    b.Property<string>("EducationLevel");

                    b.Property<int?>("FacilityId");

                    b.Property<string>("FacilityName");

                    b.Property<string>("Gender");

                    b.Property<DateTime?>("LastVisit");

                    b.Property<string>("MaritalStatus");

                    b.Property<string>("PatientID");

                    b.Property<int?>("PatientPK");

                    b.Property<string>("PatientSource");

                    b.Property<string>("PreviousARTExposure");

                    b.Property<DateTime?>("PreviousARTStartDate");

                    b.Property<string>("Project");

                    b.Property<string>("Region");

                    b.Property<DateTime?>("RegistrationAtCCC");

                    b.Property<DateTime?>("RegistrationAtPMTCT");

                    b.Property<DateTime?>("RegistrationAtTBClinic");

                    b.Property<DateTime?>("RegistrationDate");

                    b.Property<string>("SatelliteName");

                    b.Property<int?>("SiteCode");

                    b.Property<string>("StatusAtCCC");

                    b.Property<string>("StatusAtPMTCT");

                    b.Property<string>("StatusAtTBClinic");

                    b.Property<string>("Village");

                    b.HasKey("Id");

                    b.ToTable("TempPatientExtracts");
                });

            modelBuilder.Entity("Dwapi.ExtractsManagement.Core.Model.Source.Dwh.TempPatientExtractError", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("CheckError");

                    b.Property<string>("ContactRelation");

                    b.Property<DateTime?>("DOB");

                    b.Property<DateTime?>("DateConfirmedHIVPositive");

                    b.Property<DateTime>("DateExtracted");

                    b.Property<string>("District");

                    b.Property<string>("EducationLevel");

                    b.Property<string>("Emr");

                    b.Property<int?>("FacilityId");

                    b.Property<string>("FacilityName");

                    b.Property<string>("Gender");

                    b.Property<DateTime?>("LastVisit");

                    b.Property<string>("MaritalStatus");

                    b.Property<string>("PatientID");

                    b.Property<int?>("PatientPK");

                    b.Property<string>("PatientSource");

                    b.Property<string>("PreviousARTExposure");

                    b.Property<DateTime?>("PreviousARTStartDate");

                    b.Property<string>("Project");

                    b.Property<string>("Region");

                    b.Property<DateTime?>("RegistrationATPMTCT");

                    b.Property<DateTime?>("RegistrationAtCCC");

                    b.Property<DateTime?>("RegistrationAtTBClinic");

                    b.Property<DateTime?>("RegistrationDate");

                    b.Property<string>("SatelliteName");

                    b.Property<int?>("SiteCode");

                    b.Property<string>("StatusAtCCC");

                    b.Property<string>("StatusAtPMTCT");

                    b.Property<string>("StatusAtTBClinic");

                    b.Property<string>("Village");

                    b.HasKey("Id");

                    b.ToTable("vTempPatientExtractError");
                });

            modelBuilder.Entity("Dwapi.ExtractsManagement.Core.Model.Source.Dwh.TempPatientExtractErrorSummary", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("DateGenerated");

                    b.Property<string>("Extract");

                    b.Property<int?>("FacilityId");

                    b.Property<string>("FacilityName");

                    b.Property<string>("Field");

                    b.Property<string>("PatientID");

                    b.Property<int?>("PatientPK");

                    b.Property<Guid>("RecordId");

                    b.Property<int?>("SiteCode");

                    b.Property<string>("Summary");

                    b.Property<Guid?>("TempPatientExtractErrorId");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.HasIndex("TempPatientExtractErrorId");

                    b.ToTable("vTempPatientExtractErrorSummary");
                });

            modelBuilder.Entity("Dwapi.ExtractsManagement.Core.Model.ValidationError", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateGenerated");

                    b.Property<Guid>("RecordId");

                    b.Property<Guid>("ValidatorId");

                    b.HasKey("Id");

                    b.HasIndex("ValidatorId");

                    b.ToTable("ValidationError");
                });

            modelBuilder.Entity("Dwapi.ExtractsManagement.Core.Model.Validator", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Extract");

                    b.Property<string>("Field");

                    b.Property<string>("Logic");

                    b.Property<string>("Summary");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.ToTable("Validator");
                });

            modelBuilder.Entity("Dwapi.ExtractsManagement.Core.Model.Source.Dwh.TempPatientExtractErrorSummary", b =>
                {
                    b.HasOne("Dwapi.ExtractsManagement.Core.Model.Source.Dwh.TempPatientExtractError")
                        .WithMany("TempPatientExtractErrorSummaries")
                        .HasForeignKey("TempPatientExtractErrorId");
                });

            modelBuilder.Entity("Dwapi.ExtractsManagement.Core.Model.ValidationError", b =>
                {
                    b.HasOne("Dwapi.ExtractsManagement.Core.Model.Validator")
                        .WithMany("ValidationErrors")
                        .HasForeignKey("ValidatorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
