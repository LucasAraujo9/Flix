using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LucasFlix.Migrations
{
    public partial class DbLucasFlix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ator",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomeDoAtor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ator", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Classificacao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClassificacaoDoFilme = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classificacao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Diretor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomeDoDiretor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diretor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genero",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GeneroDoFilme = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genero", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Filme",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomeDoFilme = table.Column<string>(nullable: true),
                    AtorId = table.Column<int>(nullable: true),
                    DiretorId = table.Column<int>(nullable: true),
                    ClassificacaoIndicativa = table.Column<string>(nullable: true),
                    GeneroFilme = table.Column<string>(nullable: true),
                    ClassificacaoId = table.Column<int>(nullable: true),
                    GeneroId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filme", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Filme_Ator_AtorId",
                        column: x => x.AtorId,
                        principalTable: "Ator",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Filme_Classificacao_ClassificacaoId",
                        column: x => x.ClassificacaoId,
                        principalTable: "Classificacao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Filme_Diretor_DiretorId",
                        column: x => x.DiretorId,
                        principalTable: "Diretor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Filme_Genero_GeneroId",
                        column: x => x.GeneroId,
                        principalTable: "Genero",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Serie",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomeDaSerie = table.Column<string>(nullable: true),
                    AtorId = table.Column<int>(nullable: true),
                    DiretorId = table.Column<int>(nullable: true),
                    ClassificacaoIndicativa = table.Column<string>(nullable: true),
                    GeneroFilme = table.Column<string>(nullable: true),
                    ClassificacaoId = table.Column<int>(nullable: true),
                    GeneroId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Serie", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Serie_Ator_AtorId",
                        column: x => x.AtorId,
                        principalTable: "Ator",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Serie_Classificacao_ClassificacaoId",
                        column: x => x.ClassificacaoId,
                        principalTable: "Classificacao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Serie_Diretor_DiretorId",
                        column: x => x.DiretorId,
                        principalTable: "Diretor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Serie_Genero_GeneroId",
                        column: x => x.GeneroId,
                        principalTable: "Genero",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Filme_AtorId",
                table: "Filme",
                column: "AtorId");

            migrationBuilder.CreateIndex(
                name: "IX_Filme_ClassificacaoId",
                table: "Filme",
                column: "ClassificacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Filme_DiretorId",
                table: "Filme",
                column: "DiretorId");

            migrationBuilder.CreateIndex(
                name: "IX_Filme_GeneroId",
                table: "Filme",
                column: "GeneroId");

            migrationBuilder.CreateIndex(
                name: "IX_Serie_AtorId",
                table: "Serie",
                column: "AtorId");

            migrationBuilder.CreateIndex(
                name: "IX_Serie_ClassificacaoId",
                table: "Serie",
                column: "ClassificacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Serie_DiretorId",
                table: "Serie",
                column: "DiretorId");

            migrationBuilder.CreateIndex(
                name: "IX_Serie_GeneroId",
                table: "Serie",
                column: "GeneroId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Filme");

            migrationBuilder.DropTable(
                name: "Serie");

            migrationBuilder.DropTable(
                name: "Ator");

            migrationBuilder.DropTable(
                name: "Classificacao");

            migrationBuilder.DropTable(
                name: "Diretor");

            migrationBuilder.DropTable(
                name: "Genero");
        }
    }
}
