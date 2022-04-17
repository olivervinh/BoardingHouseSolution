using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BoardingHouse.Infrastructure.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Houses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HousePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UnitHousePrice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    ElectricityPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UnitElectricityPrice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WaterPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UnitWaterPrice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberMezzanine = table.Column<int>(type: "int", nullable: false),
                    Acreage = table.Column<int>(type: "int", nullable: false),
                    UnitAcreage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublicationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HouseStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsParkingVehicleInRoom = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Houses", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Houses");
        }
    }
}
