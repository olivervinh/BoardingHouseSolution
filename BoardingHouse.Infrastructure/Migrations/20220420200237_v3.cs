using Microsoft.EntityFrameworkCore.Migrations;

namespace BoardingHouse.Infrastructure.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Convenience_Houses_FkHouseId",
                table: "Convenience");

            migrationBuilder.DropForeignKey(
                name: "FK_Houses_HouseType_FkHouseTypeId",
                table: "Houses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HouseType",
                table: "HouseType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Convenience",
                table: "Convenience");

            migrationBuilder.RenameTable(
                name: "HouseType",
                newName: "HouseTypes");

            migrationBuilder.RenameTable(
                name: "Convenience",
                newName: "Conveniences");

            migrationBuilder.RenameIndex(
                name: "IX_Convenience_FkHouseId",
                table: "Conveniences",
                newName: "IX_Conveniences_FkHouseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HouseTypes",
                table: "HouseTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Conveniences",
                table: "Conveniences",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Conveniences_Houses_FkHouseId",
                table: "Conveniences",
                column: "FkHouseId",
                principalTable: "Houses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Houses_HouseTypes_FkHouseTypeId",
                table: "Houses",
                column: "FkHouseTypeId",
                principalTable: "HouseTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Conveniences_Houses_FkHouseId",
                table: "Conveniences");

            migrationBuilder.DropForeignKey(
                name: "FK_Houses_HouseTypes_FkHouseTypeId",
                table: "Houses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HouseTypes",
                table: "HouseTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Conveniences",
                table: "Conveniences");

            migrationBuilder.RenameTable(
                name: "HouseTypes",
                newName: "HouseType");

            migrationBuilder.RenameTable(
                name: "Conveniences",
                newName: "Convenience");

            migrationBuilder.RenameIndex(
                name: "IX_Conveniences_FkHouseId",
                table: "Convenience",
                newName: "IX_Convenience_FkHouseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HouseType",
                table: "HouseType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Convenience",
                table: "Convenience",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Convenience_Houses_FkHouseId",
                table: "Convenience",
                column: "FkHouseId",
                principalTable: "Houses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Houses_HouseType_FkHouseTypeId",
                table: "Houses",
                column: "FkHouseTypeId",
                principalTable: "HouseType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
