using Microsoft.EntityFrameworkCore.Migrations;

namespace WorCout_API.Migrations
{
    public partial class Newest2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sessions_Accounts_user_id",
                table: "Sessions");

            migrationBuilder.DropIndex(
                name: "IX_Sessions_user_id",
                table: "Sessions");

            migrationBuilder.AlterColumn<int>(
                name: "session_id",
                table: "Workouts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Workouts_Sessions_session_id",
                table: "Workouts");

            migrationBuilder.DropIndex(
                name: "IX_Workouts_session_id",
                table: "Workouts");

            migrationBuilder.AlterColumn<int>(
                name: "session_id",
                table: "Workouts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_user_id",
                table: "Sessions",
                column: "user_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sessions_Accounts_user_id",
                table: "Sessions",
                column: "user_id",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
