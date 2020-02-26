using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace drmovil.api.Migrations
{
    public partial class MinorChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mark_Stores_StoreId",
                table: "Mark");

            migrationBuilder.DropForeignKey(
                name: "FK_Model_Mark_MarkId",
                table: "Model");

            migrationBuilder.DropForeignKey(
                name: "FK_Model_Stores_StoreId",
                table: "Model");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskLog_Tasks_TaskId",
                table: "TaskLog");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Model_ModelId",
                table: "Tasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TaskLog",
                table: "TaskLog");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Model",
                table: "Model");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Mark",
                table: "Mark");

            migrationBuilder.RenameTable(
                name: "TaskLog",
                newName: "TaskLogs");

            migrationBuilder.RenameTable(
                name: "Model",
                newName: "Models");

            migrationBuilder.RenameTable(
                name: "Mark",
                newName: "Marks");

            migrationBuilder.RenameIndex(
                name: "IX_TaskLog_TaskId",
                table: "TaskLogs",
                newName: "IX_TaskLogs_TaskId");

            migrationBuilder.RenameIndex(
                name: "IX_Model_StoreId",
                table: "Models",
                newName: "IX_Models_StoreId");

            migrationBuilder.RenameIndex(
                name: "IX_Model_MarkId",
                table: "Models",
                newName: "IX_Models_MarkId");

            migrationBuilder.RenameIndex(
                name: "IX_Mark_StoreId",
                table: "Marks",
                newName: "IX_Marks_StoreId");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Stores",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "Stores",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TaskLogs",
                table: "TaskLogs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Models",
                table: "Models",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Marks",
                table: "Marks",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Hash = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Marks_Stores_StoreId",
                table: "Marks",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Models_Marks_MarkId",
                table: "Models",
                column: "MarkId",
                principalTable: "Marks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Models_Stores_StoreId",
                table: "Models",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaskLogs_Tasks_TaskId",
                table: "TaskLogs",
                column: "TaskId",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Models_ModelId",
                table: "Tasks",
                column: "ModelId",
                principalTable: "Models",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Marks_Stores_StoreId",
                table: "Marks");

            migrationBuilder.DropForeignKey(
                name: "FK_Models_Marks_MarkId",
                table: "Models");

            migrationBuilder.DropForeignKey(
                name: "FK_Models_Stores_StoreId",
                table: "Models");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskLogs_Tasks_TaskId",
                table: "TaskLogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Models_ModelId",
                table: "Tasks");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TaskLogs",
                table: "TaskLogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Models",
                table: "Models");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Marks",
                table: "Marks");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Stores");

            migrationBuilder.DropColumn(
                name: "Department",
                table: "Stores");

            migrationBuilder.RenameTable(
                name: "TaskLogs",
                newName: "TaskLog");

            migrationBuilder.RenameTable(
                name: "Models",
                newName: "Model");

            migrationBuilder.RenameTable(
                name: "Marks",
                newName: "Mark");

            migrationBuilder.RenameIndex(
                name: "IX_TaskLogs_TaskId",
                table: "TaskLog",
                newName: "IX_TaskLog_TaskId");

            migrationBuilder.RenameIndex(
                name: "IX_Models_StoreId",
                table: "Model",
                newName: "IX_Model_StoreId");

            migrationBuilder.RenameIndex(
                name: "IX_Models_MarkId",
                table: "Model",
                newName: "IX_Model_MarkId");

            migrationBuilder.RenameIndex(
                name: "IX_Marks_StoreId",
                table: "Mark",
                newName: "IX_Mark_StoreId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TaskLog",
                table: "TaskLog",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Model",
                table: "Model",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mark",
                table: "Mark",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Mark_Stores_StoreId",
                table: "Mark",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Model_Mark_MarkId",
                table: "Model",
                column: "MarkId",
                principalTable: "Mark",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Model_Stores_StoreId",
                table: "Model",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaskLog_Tasks_TaskId",
                table: "TaskLog",
                column: "TaskId",
                principalTable: "Tasks",
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
    }
}
