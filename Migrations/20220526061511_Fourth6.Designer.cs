﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WorCout_API.Helpers;

namespace WorCout_API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220526061511_Fourth6")]
    partial class Fourth6
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApi.Entities.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("AcceptTerms")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("PasswordReset")
                        .HasColumnType("datetime2");

                    b.Property<string>("ResetToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ResetTokenExpires")
                        .HasColumnType("datetime2");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime2");

                    b.Property<string>("VerificationToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Verified")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("WebApi.Models.WorCoutModels.Exercises", b =>
                {
                    b.Property<string>("exercise_name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("exercise_desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("muscle_group_name")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("exercise_name");

                    b.HasIndex("muscle_group_name");

                    b.ToTable("Exercises");
                });

            modelBuilder.Entity("WebApi.Models.WorCoutModels.MuscleGroups", b =>
                {
                    b.Property<string>("muscle_group_name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("targeted_muscles_id")
                        .HasColumnType("int");

                    b.HasKey("muscle_group_name");

                    b.HasIndex("targeted_muscles_id");

                    b.ToTable("MuscleGroups");
                });

            modelBuilder.Entity("WebApi.Models.WorCoutModels.Muscles", b =>
                {
                    b.Property<int>("muscles_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("abductor")
                        .HasColumnType("bit");

                    b.Property<bool>("abs")
                        .HasColumnType("bit");

                    b.Property<bool>("adductor")
                        .HasColumnType("bit");

                    b.Property<bool>("biceps")
                        .HasColumnType("bit");

                    b.Property<bool>("calves")
                        .HasColumnType("bit");

                    b.Property<bool>("chest")
                        .HasColumnType("bit");

                    b.Property<bool>("delts")
                        .HasColumnType("bit");

                    b.Property<bool>("forearm")
                        .HasColumnType("bit");

                    b.Property<bool>("glutes")
                        .HasColumnType("bit");

                    b.Property<bool>("hamstrings")
                        .HasColumnType("bit");

                    b.Property<bool>("lats")
                        .HasColumnType("bit");

                    b.Property<bool>("lower_back")
                        .HasColumnType("bit");

                    b.Property<bool>("quadriceps")
                        .HasColumnType("bit");

                    b.Property<bool>("shoulders")
                        .HasColumnType("bit");

                    b.Property<bool>("traps")
                        .HasColumnType("bit");

                    b.Property<bool>("triceps")
                        .HasColumnType("bit");

                    b.Property<bool>("upper_back")
                        .HasColumnType("bit");

                    b.HasKey("muscles_id");

                    b.ToTable("Muscles");
                });

            modelBuilder.Entity("WebApi.Models.WorCoutModels.Sessions", b =>
                {
                    b.Property<int>("session_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("session_date")
                        .HasColumnType("datetime2");

                    b.Property<int>("session_length")
                        .HasColumnType("int");

                    b.Property<DateTime>("session_time")
                        .HasColumnType("datetime2");

                    b.HasKey("session_id");

                    b.ToTable("Sessions");
                });

            modelBuilder.Entity("WebApi.Models.WorCoutModels.Tempos", b =>
                {
                    b.Property<int>("tempo_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("concentric_time_s")
                        .HasColumnType("int");

                    b.Property<int>("isometric_time_s")
                        .HasColumnType("int");

                    b.Property<int>("negative_time_s")
                        .HasColumnType("int");

                    b.Property<int>("pause_time_s")
                        .HasColumnType("int");

                    b.HasKey("tempo_id");

                    b.ToTable("Tempos");
                });

            modelBuilder.Entity("WebApi.Models.WorCoutModels.Workouts", b =>
                {
                    b.Property<int>("workout_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("completed")
                        .HasColumnType("bit");

                    b.Property<string>("exercise_name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("reps")
                        .HasColumnType("int");

                    b.Property<int>("session_id")
                        .HasColumnType("int");

                    b.Property<int>("set_number")
                        .HasColumnType("int");

                    b.Property<int>("tempo_id")
                        .HasColumnType("int");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.Property<float>("weight_lbs")
                        .HasColumnType("real");

                    b.HasKey("workout_id");

                    b.HasIndex("exercise_name");

                    b.HasIndex("tempo_id");

                    b.HasIndex("user_id");

                    b.ToTable("Workouts");
                });

            modelBuilder.Entity("WebApi.Entities.Account", b =>
                {
                    b.OwnsMany("WebApi.Entities.RefreshToken", "RefreshTokens", b1 =>
                        {
                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<int>("AccountId")
                                .HasColumnType("int");

                            b1.Property<DateTime>("Created")
                                .HasColumnType("datetime2");

                            b1.Property<string>("CreatedByIp")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<DateTime>("Expires")
                                .HasColumnType("datetime2");

                            b1.Property<string>("ReplacedByToken")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<DateTime?>("Revoked")
                                .HasColumnType("datetime2");

                            b1.Property<string>("RevokedByIp")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Token")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("Id");

                            b1.HasIndex("AccountId");

                            b1.ToTable("RefreshToken");

                            b1.WithOwner("Account")
                                .HasForeignKey("AccountId");

                            b1.Navigation("Account");
                        });

                    b.Navigation("RefreshTokens");
                });

            modelBuilder.Entity("WebApi.Models.WorCoutModels.Exercises", b =>
                {
                    b.HasOne("WebApi.Models.WorCoutModels.MuscleGroups", "MuscleGroups")
                        .WithMany()
                        .HasForeignKey("muscle_group_name");

                    b.Navigation("MuscleGroups");
                });

            modelBuilder.Entity("WebApi.Models.WorCoutModels.MuscleGroups", b =>
                {
                    b.HasOne("WebApi.Models.WorCoutModels.Muscles", "Muscles")
                        .WithMany()
                        .HasForeignKey("targeted_muscles_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Muscles");
                });

            modelBuilder.Entity("WebApi.Models.WorCoutModels.Workouts", b =>
                {
                    b.HasOne("WebApi.Models.WorCoutModels.Exercises", "Exercises")
                        .WithMany()
                        .HasForeignKey("exercise_name");

                    b.HasOne("WebApi.Models.WorCoutModels.Tempos", "Tempos")
                        .WithMany()
                        .HasForeignKey("tempo_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApi.Entities.Account", "Id")
                        .WithMany()
                        .HasForeignKey("user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exercises");

                    b.Navigation("Id");

                    b.Navigation("Tempos");
                });
#pragma warning restore 612, 618
        }
    }
}
