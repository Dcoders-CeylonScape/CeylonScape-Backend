using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuthAPI.Migrations
{
    /// <inheritdoc />
    public partial class dbform2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fax",
                table: "UserInfos");

            migrationBuilder.DropColumn(
                name: "IsPrevious",
                table: "Passports");

            migrationBuilder.DropColumn(
                name: "IsSrilanka",
                table: "EmergencyContacts");

            migrationBuilder.AlterColumn<string>(
                name: "Nationality",
                table: "UserInfos",
                type: "character varying(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<int>(
                name: "Height",
                table: "UserInfos",
                type: "integer",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "UserInfos",
                type: "character varying(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "BirthPlace",
                table: "UserInfos",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "BirthCountry",
                table: "UserInfos",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "UserInfos",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Periodofvisit",
                table: "UserInfos",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "WorkSpaceAddress",
                table: "UserInfos",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WorkSpaceEmail",
                table: "UserInfos",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WorkSpaceName",
                table: "UserInfos",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "PreviousDateOfExpiry",
                table: "Passports",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "PreviousDateOfIssue",
                table: "Passports",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "PreviousNumber",
                table: "Passports",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PreviousPlaceOfIssue",
                table: "Passports",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "HasRefusedVisa",
                table: "EntryVisaInfos",
                type: "text",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AddColumn<string>(
                name: "LastObtainedVisa",
                table: "EntryVisaInfos",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PeriodOfValidity",
                table: "EntryVisaInfos",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PeriodOfVisitVisa",
                table: "EntryVisaInfos",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Relationship",
                table: "EmergencyContacts",
                type: "character varying(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<double>(
                name: "SpendableAmount",
                table: "EmergencyContacts",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Support",
                table: "EmergencyContacts",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "UsdAmount",
                table: "EmergencyContacts",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "nameOfCreditCard",
                table: "EmergencyContacts",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "UserInfos");

            migrationBuilder.DropColumn(
                name: "Periodofvisit",
                table: "UserInfos");

            migrationBuilder.DropColumn(
                name: "WorkSpaceAddress",
                table: "UserInfos");

            migrationBuilder.DropColumn(
                name: "WorkSpaceEmail",
                table: "UserInfos");

            migrationBuilder.DropColumn(
                name: "WorkSpaceName",
                table: "UserInfos");

            migrationBuilder.DropColumn(
                name: "PreviousDateOfExpiry",
                table: "Passports");

            migrationBuilder.DropColumn(
                name: "PreviousDateOfIssue",
                table: "Passports");

            migrationBuilder.DropColumn(
                name: "PreviousNumber",
                table: "Passports");

            migrationBuilder.DropColumn(
                name: "PreviousPlaceOfIssue",
                table: "Passports");

            migrationBuilder.DropColumn(
                name: "LastObtainedVisa",
                table: "EntryVisaInfos");

            migrationBuilder.DropColumn(
                name: "PeriodOfValidity",
                table: "EntryVisaInfos");

            migrationBuilder.DropColumn(
                name: "PeriodOfVisitVisa",
                table: "EntryVisaInfos");

            migrationBuilder.DropColumn(
                name: "SpendableAmount",
                table: "EmergencyContacts");

            migrationBuilder.DropColumn(
                name: "Support",
                table: "EmergencyContacts");

            migrationBuilder.DropColumn(
                name: "UsdAmount",
                table: "EmergencyContacts");

            migrationBuilder.DropColumn(
                name: "nameOfCreditCard",
                table: "EmergencyContacts");

            migrationBuilder.AlterColumn<string>(
                name: "Nationality",
                table: "UserInfos",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Height",
                table: "UserInfos",
                type: "double precision",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "UserInfos",
                type: "character varying(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BirthPlace",
                table: "UserInfos",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BirthCountry",
                table: "UserInfos",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Fax",
                table: "UserInfos",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsPrevious",
                table: "Passports",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<bool>(
                name: "HasRefusedVisa",
                table: "EntryVisaInfos",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Relationship",
                table: "EmergencyContacts",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsSrilanka",
                table: "EmergencyContacts",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }
    }
}
