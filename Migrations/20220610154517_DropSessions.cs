using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WorCout_API.Migrations
{
    public partial class DropSessions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Workouts_Sessions_session_id",
                table: "Workouts");

            migrationBuilder.DropTable(
                name: "Sessions");

            migrationBuilder.DropIndex(
                name: "IX_Workouts_session_id",
                table: "Workouts");

            migrationBuilder.DropColumn(
                name: "session_id",
                table: "Workouts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "session_id",
                table: "Workouts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Sessions",
                columns: table => new
                {
                    session_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    session_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    session_length = table.Column<int>(type: "int", nullable: false),
                    session_time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    user_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sessions", x => x.session_id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Workouts_session_id",
                table: "Workouts",
                column: "session_id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Workouts_Sessions_session_id",
                table: "Workouts",
                column: "session_id",
                principalTable: "Sessions",
                principalColumn: "session_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
