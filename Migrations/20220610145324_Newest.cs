using Microsoft.EntityFrameworkCore.Migrations;

namespace WorCout_API.Migrations
{
    public partial class Newest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "user_id",
                table: "Sessions",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sessions_Accounts_user_id",
                table: "Sessions");

            migrationBuilder.DropIndex(
                name: "IX_Sessions_user_id",
                table: "Sessions");

            migrationBuilder.DropColumn(
                name: "user_id",
                table: "Sessions");
        }
    }
}
