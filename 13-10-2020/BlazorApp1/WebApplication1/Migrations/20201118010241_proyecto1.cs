using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class proyecto1 : Migration
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
                    Userid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recurso", x => x.id);
                    table.ForeignKey(
                        name: "FK_Recurso_Usuario_Userid",
                        column: x => x.Userid,
                        principalTable: "Usuario",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
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
                    responsableid = table.Column<int>(nullable: false),
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
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Detalle",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<string>(nullable: true),
                    Tiempo = table.Column<string>(nullable: true),
                    Recurid = table.Column<int>(nullable: false),
                    Tareaid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detalle", x => x.id);
                    table.ForeignKey(
                        name: "FK_Detalle_Recurso_Recurid",
                        column: x => x.Recurid,
                        principalTable: "Recurso",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Detalle_Tarea_Tareaid",
                        column: x => x.Tareaid,
                        principalTable: "Tarea",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Detalle_Recurid",
                table: "Detalle",
                column: "Recurid");

            migrationBuilder.CreateIndex(
                name: "IX_Detalle_Tareaid",
                table: "Detalle",
                column: "Tareaid");

            migrationBuilder.CreateIndex(
                name: "IX_Recurso_Userid",
                table: "Recurso",
                column: "Userid");

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
