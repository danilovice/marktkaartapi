using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MarktkaartAPI.Migrations
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Markten",
                columns: table => new
                {
                    Guid = table.Column<string>(nullable: false),
                    Adres = table.Column<string>(nullable: true),
                    Beschrijving = table.Column<string>(nullable: true),
                    Naam = table.Column<string>(nullable: true),
                    Plaats = table.Column<string>(nullable: true),
                    X = table.Column<double>(nullable: false),
                    Y = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Markten", x => x.Guid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Markten");
        }
    }
}
