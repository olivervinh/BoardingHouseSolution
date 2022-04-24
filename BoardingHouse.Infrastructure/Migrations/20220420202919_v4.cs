using Microsoft.EntityFrameworkCore.Migrations;

namespace BoardingHouse.Infrastructure.Migrations
{
    public partial class v4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Conveniences_Houses_FkHouseId",
                table: "Conveniences");

            migrationBuilder.AlterColumn<int>(
                name: "FkHouseId",
                table: "Conveniences",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Conveniences_Houses_FkHouseId",
                table: "Conveniences",
                column: "FkHouseId",
                principalTable: "Houses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Conveniences_Houses_FkHouseId",
                table: "Conveniences");

            migrationBuilder.AlterColumn<int>(
                name: "FkHouseId",
                table: "Conveniences",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Conveniences_Houses_FkHouseId",
                table: "Conveniences",
                column: "FkHouseId",
                principalTable: "Houses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
