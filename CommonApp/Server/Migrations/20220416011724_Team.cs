using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CommonApp.Server.Migrations
{
    public partial class Team : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TeamColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Teams_Id",
                table: "Employees",
                column: "Id",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Teams_Id",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
