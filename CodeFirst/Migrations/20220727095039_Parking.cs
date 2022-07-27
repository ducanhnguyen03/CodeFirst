using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirst.Migrations
{
    public partial class Parking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parkings",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Vịtrí = table.Column<string>(name: "Vị trí", type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Diệntích = table.Column<double>(name: "Diện tích", type: "float", nullable: false),
                    Sứcchứa = table.Column<int>(name: "Sức chứa", type: "int", nullable: false),
                    Chủsởhữu = table.Column<string>(name: "Chủ sở hữu", type: "nvarchar(100)", nullable: false),
                    Establish = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parkings", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "vehicles",
                columns: table => new
                {
                    Biểnsốxe = table.Column<string>(name: "Biển số xe", type: "varchar(10)", nullable: false),
                    Loạixe = table.Column<string>(name: "Loại xe", type: "nvarchar(50)", nullable: false),
                    Tênxe = table.Column<string>(name: "Tên xe", type: "nvarchar(50)", nullable: false),
                    Căncướccôngdân = table.Column<string>(name: "Căn cước công dân", type: "varchar(12)", nullable: false),
                    Hìnhthứcgửixe = table.Column<string>(name: "Hình thức gửi xe", type: "nvarchar(50)", nullable: false),
                    ParkingName = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehicles", x => x.Biểnsốxe);
                    table.ForeignKey(
                        name: "FK_vehicles_Parkings_ParkingName",
                        column: x => x.ParkingName,
                        principalTable: "Parkings",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_vehicles_ParkingName",
                table: "vehicles",
                column: "ParkingName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "vehicles");

            migrationBuilder.DropTable(
                name: "Parkings");
        }
    }
}
