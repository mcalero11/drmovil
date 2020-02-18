using Microsoft.EntityFrameworkCore.Migrations;

namespace drmovil.api.Migrations
{
    public partial class Changes2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Mark_MarkId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_MarkId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "MarkId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "Tasks");

            migrationBuilder.AddColumn<int>(
                name: "MarkId",
                table: "Model",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Model_MarkId",
                table: "Model",
                column: "MarkId");

            migrationBuilder.AddForeignKey(
                name: "FK_Model_Mark_MarkId",
                table: "Model",
                column: "MarkId",
                principalTable: "Mark",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Model_Mark_MarkId",
                table: "Model");

            migrationBuilder.DropIndex(
                name: "IX_Model_MarkId",
                table: "Model");

            migrationBuilder.DropColumn(
                name: "MarkId",
                table: "Model");

            migrationBuilder.AddColumn<int>(
                name: "MarkId",
                table: "Tasks",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "MyProperty",
                table: "Tasks",
                type: "text",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_MarkId",
                table: "Tasks",
                column: "MarkId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Mark_MarkId",
                table: "Tasks",
                column: "MarkId",
                principalTable: "Mark",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
