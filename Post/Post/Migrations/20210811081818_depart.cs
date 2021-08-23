using Microsoft.EntityFrameworkCore.Migrations;

namespace Post.Migrations
{
    public partial class depart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personals_Departments_DepartId",
                table: "Personals");

            migrationBuilder.AlterColumn<int>(
                name: "DepartId",
                table: "Personals",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Personals_Departments_DepartId",
                table: "Personals",
                column: "DepartId",
                principalTable: "Departments",
                principalColumn: "DepartId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personals_Departments_DepartId",
                table: "Personals");

            migrationBuilder.AlterColumn<int>(
                name: "DepartId",
                table: "Personals",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Personals_Departments_DepartId",
                table: "Personals",
                column: "DepartId",
                principalTable: "Departments",
                principalColumn: "DepartId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
