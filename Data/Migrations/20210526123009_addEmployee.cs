using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication3MVC.Data.Migrations
{
    public partial class addEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    nom = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    prenom = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DateEntree = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CA = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee",
                table: "Employees",
                columns: new[] { "nom", "prenom" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
