using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AuthAPI.Migrations
{
    /// <inheritdoc />
    public partial class allmodels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    AccountVerified = table.Column<int>(type: "integer", nullable: false),
                    MobileNumber = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    OldPassword = table.Column<string[]>(type: "text[]", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "UserInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FullName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Nationality = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Gender = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    DOB = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    BirthCountry = table.Column<string>(type: "text", nullable: false),
                    BirthPlace = table.Column<string>(type: "text", nullable: false),
                    Height = table.Column<double>(type: "double precision", nullable: false),
                    Peculiarity = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    DomicileAddress = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    AddressDuringSriLanka = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    Telephone = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    Mobile = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    Fax = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    CivilStatus = table.Column<int>(type: "integer", nullable: false),
                    UserID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Childrens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Gender = table.Column<string>(type: "text", nullable: false),
                    PlaceOfBirth = table.Column<string>(type: "text", nullable: false),
                    UserInfoId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Childrens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Childrens_UserInfos_UserInfoId",
                        column: x => x.UserInfoId,
                        principalTable: "UserInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmergencyContacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    Contact = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    Relationship = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    IsSrilanka = table.Column<bool>(type: "boolean", nullable: false),
                    UserInfoId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmergencyContacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmergencyContacts_UserInfos_UserInfoId",
                        column: x => x.UserInfoId,
                        principalTable: "UserInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EntryVisaInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ObjectOfVisit = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    ModeOfTravel = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    DateOfLeaving = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastPlaceOfResidence = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    DateOfIssue = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ResidenceVisaNumber = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    HasRefusedVisa = table.Column<bool>(type: "boolean", nullable: false),
                    UserInfoId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntryVisaInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EntryVisaInfos_UserInfos_UserInfoId",
                        column: x => x.UserInfoId,
                        principalTable: "UserInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NaturalizationInfos",
                columns: table => new
                {
                    UserInfoId = table.Column<int>(type: "integer", nullable: false),
                    IsNaturalized = table.Column<bool>(type: "boolean", nullable: false),
                    NaturalizationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    PlaceOfNaturalization = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    FormerNationality = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NaturalizationInfos", x => x.UserInfoId);
                    table.ForeignKey(
                        name: "FK_NaturalizationInfos_UserInfos_UserInfoId",
                        column: x => x.UserInfoId,
                        principalTable: "UserInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Passports",
                columns: table => new
                {
                    UserInfoId = table.Column<int>(type: "integer", nullable: false),
                    Number = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    PlaceOfIssue = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    DateOfIssue = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateOfExpiry = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsPrevious = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passports", x => x.UserInfoId);
                    table.ForeignKey(
                        name: "FK_Passports_UserInfos_UserInfoId",
                        column: x => x.UserInfoId,
                        principalTable: "UserInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Professions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NameOfWorkplace = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    AddressOfWorkplace = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    Email = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Fax = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    UserInfoId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Professions_UserInfos_UserInfoId",
                        column: x => x.UserInfoId,
                        principalTable: "UserInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ResidenceVisaInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DateOfArrival = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ReasonForApplyingVisa = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    ApplyingFor = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    SalaryIncome = table.Column<string>(type: "text", nullable: false),
                    UserInfoId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResidenceVisaInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResidenceVisaInfos_UserInfos_UserInfoId",
                        column: x => x.UserInfoId,
                        principalTable: "UserInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpouseInfos",
                columns: table => new
                {
                    UserInfoId = table.Column<int>(type: "integer", nullable: false),
                    Fullname = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Nationality = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    PostalAddress = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    PassportNumber = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    DateOfExpiry = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsPrevious = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpouseInfos", x => x.UserInfoId);
                    table.ForeignKey(
                        name: "FK_SpouseInfos_UserInfos_UserInfoId",
                        column: x => x.UserInfoId,
                        principalTable: "UserInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EntryVisaApprovals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    VisaNumber = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    DateIssued = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Purpose = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    EntryVisaInfoId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntryVisaApprovals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EntryVisaApprovals_EntryVisaInfos_EntryVisaInfoId",
                        column: x => x.EntryVisaInfoId,
                        principalTable: "EntryVisaInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VisaExtensionInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PeriodVisaRequiredFor = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    ExtentVisaRequiredFor = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    CurrencyType = table.Column<string>(type: "text", nullable: false),
                    Amount = table.Column<decimal>(type: "numeric", nullable: false),
                    AmountCashed = table.Column<decimal>(type: "numeric", nullable: false),
                    ExchangeBroughtIn = table.Column<decimal>(type: "numeric", nullable: false),
                    CreditCardAvailable = table.Column<bool>(type: "boolean", nullable: false),
                    EntryVisaInfoId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisaExtensionInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VisaExtensionInfos_EntryVisaInfos_EntryVisaInfoId",
                        column: x => x.EntryVisaInfoId,
                        principalTable: "EntryVisaInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Businesses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NameOfBusiness = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    AddressOfBusiness = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    RegistrationNumber = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    SharesOwned = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    ResidenceVisaInfoId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Businesses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Businesses_ResidenceVisaInfos_ResidenceVisaInfoId",
                        column: x => x.ResidenceVisaInfoId,
                        principalTable: "ResidenceVisaInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ResidenceVisaApprovals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    VisaNumber = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    DateIssued = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Purpose = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    ResidenceVisaInfoId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResidenceVisaApprovals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResidenceVisaApprovals_ResidenceVisaInfos_ResidenceVisaInfo~",
                        column: x => x.ResidenceVisaInfoId,
                        principalTable: "ResidenceVisaInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Businesses_ResidenceVisaInfoId",
                table: "Businesses",
                column: "ResidenceVisaInfoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Childrens_UserInfoId",
                table: "Childrens",
                column: "UserInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_EmergencyContacts_UserInfoId",
                table: "EmergencyContacts",
                column: "UserInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_EntryVisaApprovals_EntryVisaInfoId",
                table: "EntryVisaApprovals",
                column: "EntryVisaInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_EntryVisaInfos_UserInfoId",
                table: "EntryVisaInfos",
                column: "UserInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Professions_UserInfoId",
                table: "Professions",
                column: "UserInfoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ResidenceVisaApprovals_ResidenceVisaInfoId",
                table: "ResidenceVisaApprovals",
                column: "ResidenceVisaInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_ResidenceVisaInfos_UserInfoId",
                table: "ResidenceVisaInfos",
                column: "UserInfoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VisaExtensionInfos_EntryVisaInfoId",
                table: "VisaExtensionInfos",
                column: "EntryVisaInfoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Businesses");

            migrationBuilder.DropTable(
                name: "Childrens");

            migrationBuilder.DropTable(
                name: "EmergencyContacts");

            migrationBuilder.DropTable(
                name: "EntryVisaApprovals");

            migrationBuilder.DropTable(
                name: "NaturalizationInfos");

            migrationBuilder.DropTable(
                name: "Passports");

            migrationBuilder.DropTable(
                name: "Professions");

            migrationBuilder.DropTable(
                name: "ResidenceVisaApprovals");

            migrationBuilder.DropTable(
                name: "SpouseInfos");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "VisaExtensionInfos");

            migrationBuilder.DropTable(
                name: "ResidenceVisaInfos");

            migrationBuilder.DropTable(
                name: "EntryVisaInfos");

            migrationBuilder.DropTable(
                name: "UserInfos");
        }
    }
}
