using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ControllerAPI.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NeonServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NeonServices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SystemClients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemClients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ResponseServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Response = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfResponse = table.Column<int>(type: "int", nullable: false),
                    ByTokens = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SystemClientId = table.Column<int>(type: "int", nullable: false),
                    NeonServiceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResponseServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResponseServices_NeonServices_NeonServiceId",
                        column: x => x.NeonServiceId,
                        principalTable: "NeonServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ResponseServices_SystemClients_SystemClientId",
                        column: x => x.SystemClientId,
                        principalTable: "SystemClients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ResponseServices_NeonServiceId",
                table: "ResponseServices",
                column: "NeonServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_ResponseServices_SystemClientId",
                table: "ResponseServices",
                column: "SystemClientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ResponseServices");

            migrationBuilder.DropTable(
                name: "NeonServices");

            migrationBuilder.DropTable(
                name: "SystemClients");
        }
    }
}
