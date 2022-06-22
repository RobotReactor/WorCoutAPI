using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WorCout_API.Migrations
{
    public partial class Primary : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AcceptTerms = table.Column<bool>(type: "bit", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false),
                    VerificationToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Verified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ResetToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResetTokenExpires = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PasswordReset = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Muscles",
                columns: table => new
                {
                    muscles_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    shoulders = table.Column<bool>(type: "bit", nullable: false),
                    lower_back = table.Column<bool>(type: "bit", nullable: false),
                    upper_back = table.Column<bool>(type: "bit", nullable: false),
                    abs = table.Column<bool>(type: "bit", nullable: false),
                    hamstrings = table.Column<bool>(type: "bit", nullable: false),
                    glutes = table.Column<bool>(type: "bit", nullable: false),
                    quadriceps = table.Column<bool>(type: "bit", nullable: false),
                    biceps = table.Column<bool>(type: "bit", nullable: false),
                    triceps = table.Column<bool>(type: "bit", nullable: false),
                    delts = table.Column<bool>(type: "bit", nullable: false),
                    lats = table.Column<bool>(type: "bit", nullable: false),
                    traps = table.Column<bool>(type: "bit", nullable: false),
                    chest = table.Column<bool>(type: "bit", nullable: false),
                    forearm = table.Column<bool>(type: "bit", nullable: false),
                    calves = table.Column<bool>(type: "bit", nullable: false),
                    abductor = table.Column<bool>(type: "bit", nullable: false),
                    adductor = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Muscles", x => x.muscles_id);
                });

            migrationBuilder.CreateTable(
                name: "Sessions",
                columns: table => new
                {
                    session_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    session_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    session_time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    session_length = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sessions", x => x.session_id);
                });

            migrationBuilder.CreateTable(
                name: "Tempos",
                columns: table => new
                {
                    tempo_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    negative_time_s = table.Column<int>(type: "int", nullable: false),
                    isometric_time_s = table.Column<int>(type: "int", nullable: false),
                    concentric_time_s = table.Column<int>(type: "int", nullable: false),
                    pause_time_s = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tempos", x => x.tempo_id);
                });

            migrationBuilder.CreateTable(
                name: "RefreshToken",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Expires = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByIp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Revoked = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RevokedByIp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReplacedByToken = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshToken", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefreshToken_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MuscleGroups",
                columns: table => new
                {
                    muscle_group_name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    targeted_muscles_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MuscleGroups", x => x.muscle_group_name);
                    table.ForeignKey(
                        name: "FK_MuscleGroups_Muscles_targeted_muscles_id",
                        column: x => x.targeted_muscles_id,
                        principalTable: "Muscles",
                        principalColumn: "muscles_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Exercises",
                columns: table => new
                {
                    exercise_name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    muscle_group_name = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    exercise_desc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercises", x => x.exercise_name);
                    table.ForeignKey(
                        name: "FK_Exercises_MuscleGroups_muscle_group_name",
                        column: x => x.muscle_group_name,
                        principalTable: "MuscleGroups",
                        principalColumn: "muscle_group_name",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Workouts",
                columns: table => new
                {
                    workout_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tempo_id = table.Column<int>(type: "int", nullable: false),
                    user_id = table.Column<int>(type: "int", nullable: false),
                    exercise_name = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    session_id = table.Column<int>(type: "int", nullable: false),
                    set_number = table.Column<int>(type: "int", nullable: false),
                    reps = table.Column<int>(type: "int", nullable: false),
                    weight_lbs = table.Column<float>(type: "real", nullable: false),
                    completed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workouts", x => x.workout_id);
                    table.ForeignKey(
                        name: "FK_Workouts_Accounts_user_id",
                        column: x => x.user_id,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Workouts_Exercises_exercise_name",
                        column: x => x.exercise_name,
                        principalTable: "Exercises",
                        principalColumn: "exercise_name",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Workouts_Tempos_tempo_id",
                        column: x => x.tempo_id,
                        principalTable: "Tempos",
                        principalColumn: "tempo_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_muscle_group_name",
                table: "Exercises",
                column: "muscle_group_name");

            migrationBuilder.CreateIndex(
                name: "IX_MuscleGroups_targeted_muscles_id",
                table: "MuscleGroups",
                column: "targeted_muscles_id");

            migrationBuilder.CreateIndex(
                name: "IX_RefreshToken_AccountId",
                table: "RefreshToken",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Workouts_exercise_name",
                table: "Workouts",
                column: "exercise_name");

            migrationBuilder.CreateIndex(
                name: "IX_Workouts_tempo_id",
                table: "Workouts",
                column: "tempo_id");

            migrationBuilder.CreateIndex(
                name: "IX_Workouts_user_id",
                table: "Workouts",
                column: "user_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RefreshToken");

            migrationBuilder.DropTable(
                name: "Sessions");

            migrationBuilder.DropTable(
                name: "Workouts");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Exercises");

            migrationBuilder.DropTable(
                name: "Tempos");

            migrationBuilder.DropTable(
                name: "MuscleGroups");

            migrationBuilder.DropTable(
                name: "Muscles");
        }
    }
}
