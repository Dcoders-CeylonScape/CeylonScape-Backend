using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AuthAPI.Migrations
{
    /// <inheritdoc />
    public partial class modelsnew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SpouseInfos",
                table: "SpouseInfos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Passports",
                table: "Passports");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NaturalizationInfos",
                table: "NaturalizationInfos");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "SpouseInfos",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Passports",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "NaturalizationInfos",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SpouseInfos",
                table: "SpouseInfos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Passports",
                table: "Passports",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NaturalizationInfos",
                table: "NaturalizationInfos",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "IX_SpouseInfos_UserInfoId",
                table: "SpouseInfos",
                column: "UserInfoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Passports_UserInfoId",
                table: "Passports",
                column: "UserInfoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_NaturalizationInfos_UserInfoId",
                table: "NaturalizationInfos",
                column: "UserInfoId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SpouseInfos",
                table: "SpouseInfos");

            migrationBuilder.DropIndex(
                name: "IX_SpouseInfos_UserInfoId",
                table: "SpouseInfos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Passports",
                table: "Passports");

            migrationBuilder.DropIndex(
                name: "IX_Passports_UserInfoId",
                table: "Passports");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NaturalizationInfos",
                table: "NaturalizationInfos");

            migrationBuilder.DropIndex(
                name: "IX_NaturalizationInfos_UserInfoId",
                table: "NaturalizationInfos");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "SpouseInfos");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Passports");

            migrationBuilder.DropColumn(
                name: "id",
                table: "NaturalizationInfos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SpouseInfos",
                table: "SpouseInfos",
                column: "UserInfoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Passports",
                table: "Passports",
                column: "UserInfoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NaturalizationInfos",
                table: "NaturalizationInfos",
                column: "UserInfoId");
        }
    }
}
