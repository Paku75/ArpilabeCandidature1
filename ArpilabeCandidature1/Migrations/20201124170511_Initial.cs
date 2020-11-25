using Microsoft.EntityFrameworkCore.Migrations;

namespace ArpilabeCandidature1.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personne",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    prenom = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    telephone = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    note = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    depatement = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    dateNaissance = table.Column<string>(type: "nvarchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personne", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personne");
        }
    }
}
