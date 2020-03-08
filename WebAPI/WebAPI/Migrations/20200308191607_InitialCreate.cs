using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Proyectos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: false),
                    Descripcion = table.Column<string>(nullable: false),
                    Fecha_Inicio = table.Column<DateTime>(nullable: false),
                    Fecha_Fin = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proyectos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tareas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: false),
                    Descripcion = table.Column<string>(nullable: false),
                    Fecha_Ejecucion = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tareas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Proyectos");

            migrationBuilder.DropTable(
                name: "Tareas");
        }
    }
}
