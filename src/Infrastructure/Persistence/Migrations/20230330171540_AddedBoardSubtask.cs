using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace RestApiTemplate.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddedBoardSubtask : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BoardTask",
                table: "BoardTask");

            migrationBuilder.RenameTable(
                name: "BoardTask",
                newName: "BoardTasks");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BoardTasks",
                table: "BoardTasks",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "BoardSubtask",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Priority = table.Column<int>(type: "integer", nullable: false),
                    DueDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    BoardTaskId = table.Column<int>(type: "integer", nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    LastModified = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoardSubtask", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BoardSubtask_BoardTasks_BoardTaskId",
                        column: x => x.BoardTaskId,
                        principalTable: "BoardTasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BoardSubtask_BoardTaskId",
                table: "BoardSubtask",
                column: "BoardTaskId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BoardSubtask");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BoardTasks",
                table: "BoardTasks");

            migrationBuilder.RenameTable(
                name: "BoardTasks",
                newName: "BoardTask");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BoardTask",
                table: "BoardTask",
                column: "Id");
        }
    }
}
