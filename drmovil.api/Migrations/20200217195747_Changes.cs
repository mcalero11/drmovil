using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace drmovil.api.Migrations
{
    public partial class Changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhotosName",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "Details",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Sales");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Tasks",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "MarkId",
                table: "Tasks",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ModelId",
                table: "Tasks",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "MyProperty",
                table: "Tasks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PublicLink",
                table: "Tasks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comments",
                table: "Sales",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Customer",
                table: "Sales",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Sales",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Devices",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Devices",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Mark",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Hash = table.Column<int>(nullable: false),
                    MarkName = table.Column<string>(nullable: true),
                    StoreId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mark", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mark_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Model",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Hash = table.Column<int>(nullable: false),
                    ModelName = table.Column<string>(nullable: true),
                    StoreId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Model", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Model_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaskLog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Hash = table.Column<int>(nullable: false),
                    PreviousStatus = table.Column<int>(nullable: false),
                    NextStatus = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Comments = table.Column<string>(nullable: true),
                    TaskId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskLog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskLog_Tasks_TaskId",
                        column: x => x.TaskId,
                        principalTable: "Tasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaskPhotos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Hash = table.Column<int>(nullable: false),
                    PhotoName = table.Column<string>(nullable: true),
                    TaskId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskPhotos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskPhotos_Tasks_TaskId",
                        column: x => x.TaskId,
                        principalTable: "Tasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_MarkId",
                table: "Tasks",
                column: "MarkId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_ModelId",
                table: "Tasks",
                column: "ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Mark_StoreId",
                table: "Mark",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Model_StoreId",
                table: "Model",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskLog_TaskId",
                table: "TaskLog",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskPhotos_TaskId",
                table: "TaskPhotos",
                column: "TaskId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Mark_MarkId",
                table: "Tasks",
                column: "MarkId",
                principalTable: "Mark",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Model_ModelId",
                table: "Tasks",
                column: "ModelId",
                principalTable: "Model",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Mark_MarkId",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Model_ModelId",
                table: "Tasks");

            migrationBuilder.DropTable(
                name: "Mark");

            migrationBuilder.DropTable(
                name: "Model");

            migrationBuilder.DropTable(
                name: "TaskLog");

            migrationBuilder.DropTable(
                name: "TaskPhotos");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_MarkId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_ModelId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "MarkId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "ModelId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "PublicLink",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "Comments",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "Customer",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Devices");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Devices");

            migrationBuilder.AddColumn<string[]>(
                name: "PhotosName",
                table: "Tasks",
                type: "text[]",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Details",
                table: "Sales",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Sales",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
