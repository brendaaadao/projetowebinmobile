using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoWebMVC.Migrations
{
    public partial class quarta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidato_Departamento_DepartamentoId",
                table: "Candidato");

            migrationBuilder.DropTable(
                name: "Departamento");

            migrationBuilder.DropIndex(
                name: "IX_Candidato_DepartamentoId",
                table: "Candidato");

            migrationBuilder.DropColumn(
                name: "DepartamentoId",
                table: "Candidato");

            migrationBuilder.CreateTable(
                name: "CandidatoVaga",
                columns: table => new
                {
                    IdCandidato = table.Column<int>(nullable: false),
                    IdVaga = table.Column<int>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidatoVaga", x => new { x.IdCandidato, x.IdVaga });
                    table.ForeignKey(
                        name: "FK_CandidatoVaga_Vaga_VagaId",
                        column: x => x.IdVaga,
                        principalTable: "Vaga",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CandidatoVaga_Candidato_CandidatoId",
                        column: x => x.IdVaga,
                        principalTable: "Candidato",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CandidatoVaga_VagaId",
                table: "CandidatoVaga",
                column: "IdVaga");

            migrationBuilder.CreateIndex(
               name: "IX_CandidatoVaga_CandidatoId",
               table: "CandidatoVaga",
               column: "IdCandidato");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CandidatoVaga");


            migrationBuilder.AddColumn<int>(
                name: "DepartamentoId",
                table: "Candidato",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Departamento",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamento", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Candidato_DepartamentoId",
                table: "Candidato",
                column: "DepartamentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidato_Departamento_DepartamentoId",
                table: "Candidato",
                column: "DepartamentoId",
                principalTable: "Departamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
