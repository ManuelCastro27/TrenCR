using Microsoft.EntityFrameworkCore.Migrations;

namespace TransportePublico.Migrations
{
    public partial class MigracionInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estacion",
                columns: table => new
                {
                    IDEstacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreEstacion = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estacion", x => x.IDEstacion);
                });

            migrationBuilder.CreateTable(
                name: "Ruta",
                columns: table => new
                {
                    IDRuta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreRuta = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ruta", x => x.IDRuta);
                });

            migrationBuilder.CreateTable(
                name: "Horario",
                columns: table => new
                {
                    IDHorario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDEstacion = table.Column<int>(type: "int", nullable: false),
                    IDRuta = table.Column<int>(type: "int", nullable: false),
                    Hora = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstacionIDEstacion = table.Column<int>(type: "int", nullable: true),
                    RutaIDRuta = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Horario", x => x.IDHorario);
                    table.ForeignKey(
                        name: "FK_Horario_Estacion_EstacionIDEstacion",
                        column: x => x.EstacionIDEstacion,
                        principalTable: "Estacion",
                        principalColumn: "IDEstacion",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Horario_Ruta_RutaIDRuta",
                        column: x => x.RutaIDRuta,
                        principalTable: "Ruta",
                        principalColumn: "IDRuta",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Horario_EstacionIDEstacion",
                table: "Horario",
                column: "EstacionIDEstacion");

            migrationBuilder.CreateIndex(
                name: "IX_Horario_RutaIDRuta",
                table: "Horario",
                column: "RutaIDRuta");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Horario");

            migrationBuilder.DropTable(
                name: "Estacion");

            migrationBuilder.DropTable(
                name: "Ruta");
        }
    }
}
