using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MasActitud.Migrations
{
    public partial class mejorasModelo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contrato_Trabajador_numeroIdentificacion",
                table: "Contrato");

            migrationBuilder.AlterColumn<string>(
                name: "tipoIdentificacion",
                table: "Trabajador",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Edad",
                table: "Trabajador",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "fechaNacimiento",
                table: "Trabajador",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "primerApellido",
                table: "Trabajador",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "primerNombre",
                table: "Trabajador",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "segundoApellido",
                table: "Trabajador",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "segundoNombre",
                table: "Trabajador",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "numeroIdentificacion",
                table: "Contrato",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255) CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "fechaFinalizacion",
                table: "Contrato",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "fechaInicio",
                table: "Contrato",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(128) CHARACTER SET utf8mb4",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(128) CHARACTER SET utf8mb4",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(128) CHARACTER SET utf8mb4",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(128) CHARACTER SET utf8mb4",
                oldMaxLength: 128);

            migrationBuilder.AddForeignKey(
                name: "FK_Contrato_Trabajador_numeroIdentificacion",
                table: "Contrato",
                column: "numeroIdentificacion",
                principalTable: "Trabajador",
                principalColumn: "numeroIdentificacion",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contrato_Trabajador_numeroIdentificacion",
                table: "Contrato");

            migrationBuilder.DropColumn(
                name: "Edad",
                table: "Trabajador");

            migrationBuilder.DropColumn(
                name: "fechaNacimiento",
                table: "Trabajador");

            migrationBuilder.DropColumn(
                name: "primerApellido",
                table: "Trabajador");

            migrationBuilder.DropColumn(
                name: "primerNombre",
                table: "Trabajador");

            migrationBuilder.DropColumn(
                name: "segundoApellido",
                table: "Trabajador");

            migrationBuilder.DropColumn(
                name: "segundoNombre",
                table: "Trabajador");

            migrationBuilder.DropColumn(
                name: "fechaFinalizacion",
                table: "Contrato");

            migrationBuilder.DropColumn(
                name: "fechaInicio",
                table: "Contrato");

            migrationBuilder.AlterColumn<string>(
                name: "tipoIdentificacion",
                table: "Trabajador",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "numeroIdentificacion",
                table: "Contrato",
                type: "varchar(255) CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "varchar(128) CHARACTER SET utf8mb4",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "varchar(128) CHARACTER SET utf8mb4",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "varchar(128) CHARACTER SET utf8mb4",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "varchar(128) CHARACTER SET utf8mb4",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddForeignKey(
                name: "FK_Contrato_Trabajador_numeroIdentificacion",
                table: "Contrato",
                column: "numeroIdentificacion",
                principalTable: "Trabajador",
                principalColumn: "numeroIdentificacion",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
