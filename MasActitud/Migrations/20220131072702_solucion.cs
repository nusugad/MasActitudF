using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MasActitud.Migrations
{
    public partial class solucion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contrato_Trabajador_numeroIdentificacion",
                table: "Contrato");

            migrationBuilder.AlterColumn<string>(
                name: "numeroIdentificacion",
                table: "Contrato",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255) CHARACTER SET utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "numeroContrato",
                table: "Contrato",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255) CHARACTER SET utf8mb4")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddForeignKey(
                name: "FK_Contrato_Trabajador_numeroIdentificacion",
                table: "Contrato",
                column: "numeroIdentificacion",
                principalTable: "Trabajador",
                principalColumn: "numeroIdentificacion",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contrato_Trabajador_numeroIdentificacion",
                table: "Contrato");

            migrationBuilder.AlterColumn<string>(
                name: "numeroIdentificacion",
                table: "Contrato",
                type: "varchar(255) CHARACTER SET utf8mb4",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "numeroContrato",
                table: "Contrato",
                type: "varchar(255) CHARACTER SET utf8mb4",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddForeignKey(
                name: "FK_Contrato_Trabajador_numeroIdentificacion",
                table: "Contrato",
                column: "numeroIdentificacion",
                principalTable: "Trabajador",
                principalColumn: "numeroIdentificacion",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
