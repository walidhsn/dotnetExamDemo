using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Examen.Infra.Migrations
{
    /// <inheritdoc />
    public partial class testmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "agents",
                columns: table => new
                {
                    AgentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dateEmbauche = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_agents", x => x.AgentId);
                });

            migrationBuilder.CreateTable(
                name: "vehicules",
                columns: table => new
                {
                    vehiculeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    prixJour = table.Column<double>(type: "float", nullable: false),
                    kilometrage = table.Column<int>(type: "int", nullable: false),
                    couleur = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehicules", x => x.vehiculeId);
                });

            migrationBuilder.CreateTable(
                name: "locataires",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    adresse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telephone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pointBonus = table.Column<int>(type: "int", nullable: false),
                    dateAdhesion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AgentId = table.Column<int>(type: "int", nullable: false),
                    TypeLocataire = table.Column<int>(type: "int", nullable: false),
                    intitule = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    prenom = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_locataires", x => x.id);
                    table.ForeignKey(
                        name: "FK_locataires_agents_AgentId",
                        column: x => x.AgentId,
                        principalTable: "agents",
                        principalColumn: "AgentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "reservationes",
                columns: table => new
                {
                    dateReservation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    vehiculeKey = table.Column<int>(type: "int", nullable: false),
                    locataireKey = table.Column<int>(type: "int", nullable: false),
                    dureeJour = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reservationes", x => new { x.dateReservation, x.vehiculeKey, x.locataireKey });
                    table.ForeignKey(
                        name: "FK_reservationes_locataires_locataireKey",
                        column: x => x.locataireKey,
                        principalTable: "locataires",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_reservationes_vehicules_vehiculeKey",
                        column: x => x.vehiculeKey,
                        principalTable: "vehicules",
                        principalColumn: "vehiculeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_locataires_AgentId",
                table: "locataires",
                column: "AgentId");

            migrationBuilder.CreateIndex(
                name: "IX_reservationes_locataireKey",
                table: "reservationes",
                column: "locataireKey");

            migrationBuilder.CreateIndex(
                name: "IX_reservationes_vehiculeKey",
                table: "reservationes",
                column: "vehiculeKey");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "reservationes");

            migrationBuilder.DropTable(
                name: "locataires");

            migrationBuilder.DropTable(
                name: "vehicules");

            migrationBuilder.DropTable(
                name: "agents");
        }
    }
}
