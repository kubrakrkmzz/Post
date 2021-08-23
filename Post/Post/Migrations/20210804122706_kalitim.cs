using Microsoft.EntityFrameworkCore.Migrations;

namespace Post.Migrations
{
    public partial class kalitim : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Personals");

            migrationBuilder.AddColumn<int>(
                name: "DepartId",
                table: "Personals",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Personals_DepartId",
                table: "Personals",
                column: "DepartId");

            migrationBuilder.AddForeignKey(
                name: "FK_Personals_Departments_DepartId",
                table: "Personals",
                column: "DepartId",
                principalTable: "Departments",
                principalColumn: "DepartId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personals_Departments_DepartId",
                table: "Personals");

            migrationBuilder.DropIndex(
                name: "IX_Personals_DepartId",
                table: "Personals");

            migrationBuilder.DropColumn(
                name: "DepartId",
                table: "Personals");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Personals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
