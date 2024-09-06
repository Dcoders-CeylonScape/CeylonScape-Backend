﻿// <auto-generated />
using System;
using AuthAPI;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AuthAPI.Migrations
{
    [DbContext(typeof(AuthAPIContext))]
    [Migration("20240906054010_dbfinal")]
    partial class dbfinal
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AuthAPI.Models.Business", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("AddressOfBusiness")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("NameOfBusiness")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("RegistrationNumber")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<int>("ResidenceVisaInfoId")
                        .HasColumnType("integer");

                    b.Property<string>("SharesOwned")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.HasIndex("ResidenceVisaInfoId")
                        .IsUnique();

                    b.ToTable("Businesses");
                });

            modelBuilder.Entity("AuthAPI.Models.Children", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("PlaceOfBirth")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserInfoId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserInfoId");

                    b.ToTable("Childrens");
                });

            modelBuilder.Entity("AuthAPI.Models.EmergencyContact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Relationship")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<double>("SpendableAmount")
                        .HasColumnType("double precision");

                    b.Property<string>("Support")
                        .HasColumnType("text");

                    b.Property<double>("UsdAmount")
                        .HasColumnType("double precision");

                    b.Property<int>("UserInfoId")
                        .HasColumnType("integer");

                    b.Property<string>("nameOfCreditCard")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserInfoId");

                    b.ToTable("EmergencyContacts");
                });

            modelBuilder.Entity("AuthAPI.Models.EntryVisaApproval", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateIssued")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("EntryVisaInfoId")
                        .HasColumnType("integer");

                    b.Property<string>("Purpose")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("VisaNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.HasIndex("EntryVisaInfoId");

                    b.ToTable("EntryVisaApprovals");
                });

            modelBuilder.Entity("AuthAPI.Models.EntryVisaInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateOfIssue")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DateOfLeaving")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("HasRefusedVisa")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastObtainedVisa")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastPlaceOfResidence")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("ModeOfTravel")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("ObjectOfVisit")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<int>("PeriodOfValidity")
                        .HasColumnType("integer");

                    b.Property<int>("PeriodOfVisitVisa")
                        .HasColumnType("integer");

                    b.Property<string>("ResidenceVisaNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<int>("UserInfoId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserInfoId");

                    b.ToTable("EntryVisaInfos");
                });

            modelBuilder.Entity("AuthAPI.Models.NaturalizationInfo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("FormerNationality")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<bool>("IsNaturalized")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("NaturalizationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("PlaceOfNaturalization")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<int>("UserInfoId")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("UserInfoId")
                        .IsUnique();

                    b.ToTable("NaturalizationInfos");
                });

            modelBuilder.Entity("AuthAPI.Models.Passport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateOfExpiry")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DateOfIssue")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("PlaceOfIssue")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<DateTime>("PreviousDateOfExpiry")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("PreviousDateOfIssue")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("PreviousNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PreviousPlaceOfIssue")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<int>("UserInfoId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserInfoId")
                        .IsUnique();

                    b.ToTable("Passports");
                });

            modelBuilder.Entity("AuthAPI.Models.Profession", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("AddressOfWorkplace")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Fax")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("NameOfWorkplace")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<int>("UserInfoId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserInfoId")
                        .IsUnique();

                    b.ToTable("Professions");
                });

            modelBuilder.Entity("AuthAPI.Models.ResidenceVisaApproval", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateIssued")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Purpose")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<int>("ResidenceVisaInfoId")
                        .HasColumnType("integer");

                    b.Property<string>("VisaNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.HasIndex("ResidenceVisaInfoId");

                    b.ToTable("ResidenceVisaApprovals");
                });

            modelBuilder.Entity("AuthAPI.Models.ResidenceVisaInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ApplyingFor")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<DateTime>("DateOfArrival")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ReasonForApplyingVisa")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("SalaryIncome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserInfoId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserInfoId")
                        .IsUnique();

                    b.ToTable("ResidenceVisaInfos");
                });

            modelBuilder.Entity("AuthAPI.Models.SpouseInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateOfExpiry")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Fullname")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<bool>("IsPrevious")
                        .HasColumnType("boolean");

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("PassportNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("PostalAddress")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<int>("UserInfoId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserInfoId")
                        .IsUnique();

                    b.ToTable("SpouseInfos");
                });

            modelBuilder.Entity("AuthAPI.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UserID"));

                    b.Property<int>("AccountVerified")
                        .HasColumnType("integer");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string[]>("OldPassword")
                        .HasColumnType("text[]");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("UserID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("AuthAPI.Models.UserInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("AddressDuringSriLanka")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("BirthCountry")
                        .HasColumnType("text");

                    b.Property<string>("BirthPlace")
                        .HasColumnType("text");

                    b.Property<int>("CivilStatus")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("DomicileAddress")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Gender")
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<int>("Height")
                        .HasColumnType("integer");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("Nationality")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Peculiarity")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<int>("Periodofvisit")
                        .HasColumnType("integer");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<int>("UserID")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("UserInfos");
                });

            modelBuilder.Entity("AuthAPI.Models.VisaExtensionInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("numeric");

                    b.Property<decimal>("AmountCashed")
                        .HasColumnType("numeric");

                    b.Property<bool>("CreditCardAvailable")
                        .HasColumnType("boolean");

                    b.Property<string>("CurrencyType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("EntryVisaInfoId")
                        .HasColumnType("integer");

                    b.Property<decimal>("ExchangeBroughtIn")
                        .HasColumnType("numeric");

                    b.Property<string>("ExtentVisaRequiredFor")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("PeriodVisaRequiredFor")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id");

                    b.HasIndex("EntryVisaInfoId");

                    b.ToTable("VisaExtensionInfos");
                });

            modelBuilder.Entity("AuthAPI.Models.Business", b =>
                {
                    b.HasOne("AuthAPI.Models.ResidenceVisaInfo", "ResidenceVisaInfo")
                        .WithOne("Business")
                        .HasForeignKey("AuthAPI.Models.Business", "ResidenceVisaInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ResidenceVisaInfo");
                });

            modelBuilder.Entity("AuthAPI.Models.Children", b =>
                {
                    b.HasOne("AuthAPI.Models.UserInfo", "UserInfo")
                        .WithMany()
                        .HasForeignKey("UserInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserInfo");
                });

            modelBuilder.Entity("AuthAPI.Models.EmergencyContact", b =>
                {
                    b.HasOne("AuthAPI.Models.UserInfo", "UserInfo")
                        .WithMany("EmergencyContacts")
                        .HasForeignKey("UserInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserInfo");
                });

            modelBuilder.Entity("AuthAPI.Models.EntryVisaApproval", b =>
                {
                    b.HasOne("AuthAPI.Models.EntryVisaInfo", "EntryVisaInfo")
                        .WithMany("EntryVisaApprovals")
                        .HasForeignKey("EntryVisaInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EntryVisaInfo");
                });

            modelBuilder.Entity("AuthAPI.Models.EntryVisaInfo", b =>
                {
                    b.HasOne("AuthAPI.Models.UserInfo", "UserInfo")
                        .WithMany("EntryVisas")
                        .HasForeignKey("UserInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserInfo");
                });

            modelBuilder.Entity("AuthAPI.Models.NaturalizationInfo", b =>
                {
                    b.HasOne("AuthAPI.Models.UserInfo", "UserInfo")
                        .WithOne("NaturalizationInfo")
                        .HasForeignKey("AuthAPI.Models.NaturalizationInfo", "UserInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserInfo");
                });

            modelBuilder.Entity("AuthAPI.Models.Passport", b =>
                {
                    b.HasOne("AuthAPI.Models.UserInfo", "UserInfo")
                        .WithOne("Passport")
                        .HasForeignKey("AuthAPI.Models.Passport", "UserInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserInfo");
                });

            modelBuilder.Entity("AuthAPI.Models.Profession", b =>
                {
                    b.HasOne("AuthAPI.Models.UserInfo", "UserInfo")
                        .WithOne("Profession")
                        .HasForeignKey("AuthAPI.Models.Profession", "UserInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserInfo");
                });

            modelBuilder.Entity("AuthAPI.Models.ResidenceVisaApproval", b =>
                {
                    b.HasOne("AuthAPI.Models.ResidenceVisaInfo", "ResidenceVisaInfo")
                        .WithMany("ResidenceVisaApprovals")
                        .HasForeignKey("ResidenceVisaInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ResidenceVisaInfo");
                });

            modelBuilder.Entity("AuthAPI.Models.ResidenceVisaInfo", b =>
                {
                    b.HasOne("AuthAPI.Models.UserInfo", "UserInfo")
                        .WithOne("ResidenceVisaInfo")
                        .HasForeignKey("AuthAPI.Models.ResidenceVisaInfo", "UserInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserInfo");
                });

            modelBuilder.Entity("AuthAPI.Models.SpouseInfo", b =>
                {
                    b.HasOne("AuthAPI.Models.UserInfo", "UserInfo")
                        .WithOne("Spouse")
                        .HasForeignKey("AuthAPI.Models.SpouseInfo", "UserInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserInfo");
                });

            modelBuilder.Entity("AuthAPI.Models.VisaExtensionInfo", b =>
                {
                    b.HasOne("AuthAPI.Models.EntryVisaInfo", "EntryVisaInfo")
                        .WithMany("VisaExtensionInfos")
                        .HasForeignKey("EntryVisaInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EntryVisaInfo");
                });

            modelBuilder.Entity("AuthAPI.Models.EntryVisaInfo", b =>
                {
                    b.Navigation("EntryVisaApprovals");

                    b.Navigation("VisaExtensionInfos");
                });

            modelBuilder.Entity("AuthAPI.Models.ResidenceVisaInfo", b =>
                {
                    b.Navigation("Business")
                        .IsRequired();

                    b.Navigation("ResidenceVisaApprovals");
                });

            modelBuilder.Entity("AuthAPI.Models.UserInfo", b =>
                {
                    b.Navigation("EmergencyContacts");

                    b.Navigation("EntryVisas");

                    b.Navigation("NaturalizationInfo");

                    b.Navigation("Passport");

                    b.Navigation("Profession");

                    b.Navigation("ResidenceVisaInfo");

                    b.Navigation("Spouse");
                });
#pragma warning restore 612, 618
        }
    }
}
