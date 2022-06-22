using Microsoft.EntityFrameworkCore.Migrations;

namespace WorCout_API.Migrations
{
    public partial class Fourth8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MuscleGroups_Muscles_targeted_muscles_id",
                table: "MuscleGroups");

            migrationBuilder.DropForeignKey(
                name: "FK_Workouts_Tempos_tempo_id",
                table: "Workouts");

            migrationBuilder.AlterColumn<float>(
                name: "weight_lbs",
                table: "Workouts",
                type: "real",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<int>(
                name: "tempo_id",
                table: "Workouts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "set_number",
                table: "Workouts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "session_id",
                table: "Workouts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "reps",
                table: "Workouts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "completed",
                table: "Workouts",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "targeted_muscles_id",
                table: "MuscleGroups",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_MuscleGroups_Muscles_targeted_muscles_id",
                table: "MuscleGroups",
                column: "targeted_muscles_id",
                principalTable: "Muscles",
                principalColumn: "muscles_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Workouts_Tempos_tempo_id",
                table: "Workouts",
                column: "tempo_id",
                principalTable: "Tempos",
                principalColumn: "tempo_id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MuscleGroups_Muscles_targeted_muscles_id",
                table: "MuscleGroups");

            migrationBuilder.DropForeignKey(
                name: "FK_Workouts_Tempos_tempo_id",
                table: "Workouts");

            migrationBuilder.AlterColumn<float>(
                name: "weight_lbs",
                table: "Workouts",
                type: "real",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "tempo_id",
                table: "Workouts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "set_number",
                table: "Workouts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "session_id",
                table: "Workouts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "reps",
                table: "Workouts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "completed",
                table: "Workouts",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "targeted_muscles_id",
                table: "MuscleGroups",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MuscleGroups_Muscles_targeted_muscles_id",
                table: "MuscleGroups",
                column: "targeted_muscles_id",
                principalTable: "Muscles",
                principalColumn: "muscles_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Workouts_Tempos_tempo_id",
                table: "Workouts",
                column: "tempo_id",
                principalTable: "Tempos",
                principalColumn: "tempo_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
