using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleApp1.Migrations
{
    public partial class test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nombre = table.Column<string>(maxLength: 50, nullable: true),
                    clave = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Recurso",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nombre = table.Column<string>(nullable: true),
                    IdUsuario = table.Column<int>(nullable: false),
                    usuarioid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recurso", x => x.id);
                    table.ForeignKey(
                        name: "FK_Recurso_Usuario_usuarioid",
                        column: x => x.usuarioid,
                        principalTable: "Usuario",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tarea",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    titulo = table.Column<string>(nullable: true),
                    vencimiento = table.Column<string>(nullable: true),
                    estimacion = table.Column<string>(nullable: true),
                    IdRecursos = table.Column<int>(nullable: false),
                    responsableid = table.Column<int>(nullable: true),
                    estado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarea", x => x.id);
                    table.ForeignKey(
                        name: "FK_Tarea_Recurso_responsableid",
                        column: x => x.responsableid,
                        principalTable: "Recurso",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Detalle",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<string>(nullable: true),
                    Tiempo = table.Column<string>(nullable: true),
                    IdRecurso = table.Column<int>(nullable: false),
                    Recursoid = table.Column<int>(nullable: true),
                    IdTarea = table.Column<int>(nullable: false),
                    Tareaid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detalle", x => x.id);
                    table.ForeignKey(
                        name: "FK_Detalle_Recurso_Recursoid",
                        column: x => x.Recursoid,
                        principalTable: "Recurso",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Detalle_Tarea_Tareaid",
                        column: x => x.Tareaid,
                        principalTable: "Tarea",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Detalle_Recursoid",
                table: "Detalle",
                column: "Recursoid");

            migrationBuilder.CreateIndex(
                name: "IX_Detalle_Tareaid",
                table: "Detalle",
                column: "Tareaid");

            migrationBuilder.CreateIndex(
                name: "IX_Recurso_usuarioid",
                table: "Recurso",
                column: "usuarioid");

            migrationBuilder.CreateIndex(
                name: "IX_Tarea_responsableid",
                table: "Tarea",
                column: "responsableid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Detalle");

            migrationBuilder.DropTable(
                name: "Tarea");

            migrationBuilder.DropTable(
                name: "Recurso");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
