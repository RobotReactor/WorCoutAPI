using Microsoft.EntityFrameworkCore.Migrations;

namespace WorCout_API.Migrations
{
    public partial class Six : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Calories",
                columns: table => new
                {
                    cal_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_id = table.Column<int>(type: "int", nullable: false),
                    daily_calories = table.Column<int>(type: "int", nullable: true),
                    weight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    height = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    age = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calories", x => x.cal_id);
                    table.ForeignKey(
                        name: "FK_Calories_Accounts_user_id",
                        column: x => x.user_id,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Calories_user_id",
                table: "Calories",
                column: "user_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Calories");
        }
    }
}
