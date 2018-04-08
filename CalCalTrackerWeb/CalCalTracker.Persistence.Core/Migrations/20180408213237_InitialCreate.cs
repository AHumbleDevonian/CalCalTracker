using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CalCalTracker.Persistence.Core.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: true),
                    DateOfBirthCr = table.Column<DateTime>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    Gender = table.Column<int>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    Weight = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Calories = table.Column<long>(nullable: false),
                    CreatedUserId = table.Column<long>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    IsGlobal = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Activities_Users_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DayLogs",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CalculatedWeight = table.Column<double>(nullable: false),
                    CreatedUserId = table.Column<long>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    Weight = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DayLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DayLogs_Users_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FoodItems",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BetaCarotene = table.Column<double>(nullable: false),
                    Calcium = table.Column<double>(nullable: false),
                    Calories = table.Column<double>(nullable: false),
                    Carbohydrates = table.Column<double>(nullable: false),
                    Cholesterol = table.Column<double>(nullable: false),
                    Chromium = table.Column<double>(nullable: false),
                    Cobalt = table.Column<double>(nullable: false),
                    Copper = table.Column<double>(nullable: false),
                    CreatedUserId = table.Column<long>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    Fat = table.Column<double>(nullable: false),
                    Fibre = table.Column<double>(nullable: false),
                    FolicAcid = table.Column<double>(nullable: false),
                    Iodine = table.Column<double>(nullable: false),
                    Iron = table.Column<double>(nullable: false),
                    IsGlobal = table.Column<bool>(nullable: false),
                    Magnesium = table.Column<double>(nullable: false),
                    Manganese = table.Column<double>(nullable: false),
                    Molybdenum = table.Column<double>(nullable: false),
                    MonounsaturatedFat = table.Column<double>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    PantothenicAcid = table.Column<double>(nullable: false),
                    Phosphorus = table.Column<double>(nullable: false),
                    PolyunsaturatedFat = table.Column<double>(nullable: false),
                    Potassium = table.Column<double>(nullable: false),
                    Protein = table.Column<double>(nullable: false),
                    SaturatedFat = table.Column<double>(nullable: false),
                    Selenium = table.Column<double>(nullable: false),
                    Sodium = table.Column<double>(nullable: false),
                    Sugar = table.Column<double>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    VitaminA = table.Column<double>(nullable: false),
                    VitaminB1 = table.Column<double>(nullable: false),
                    VitaminB12 = table.Column<double>(nullable: false),
                    VitaminB2 = table.Column<double>(nullable: false),
                    VitaminB3 = table.Column<double>(nullable: false),
                    VitaminB6 = table.Column<double>(nullable: false),
                    VitaminB7 = table.Column<double>(nullable: false),
                    VitaminC = table.Column<double>(nullable: false),
                    VitaminD = table.Column<double>(nullable: false),
                    VitaminE = table.Column<double>(nullable: false),
                    VitaminK = table.Column<double>(nullable: false),
                    Zinc = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FoodItems_Users_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Meals",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedUserId = table.Column<long>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    IsGlobal = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Meals_Users_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserGoals",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AchievedDate = table.Column<DateTime>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    CreatedUserId = table.Column<long>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    GoalDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    TargetWeight = table.Column<double>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserGoals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserGoals_Users_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DayLogActivity",
                columns: table => new
                {
                    ActivityId = table.Column<long>(nullable: false),
                    DayLogId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DayLogActivity", x => new { x.ActivityId, x.DayLogId });
                    table.ForeignKey(
                        name: "FK_DayLogActivity_Activities_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DayLogActivity_DayLogs_DayLogId",
                        column: x => x.DayLogId,
                        principalTable: "DayLogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DayLogFoodItem",
                columns: table => new
                {
                    FoodItemId = table.Column<long>(nullable: false),
                    DayLogId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DayLogFoodItem", x => new { x.FoodItemId, x.DayLogId });
                    table.ForeignKey(
                        name: "FK_DayLogFoodItem_DayLogs_DayLogId",
                        column: x => x.DayLogId,
                        principalTable: "DayLogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DayLogFoodItem_FoodItems_FoodItemId",
                        column: x => x.FoodItemId,
                        principalTable: "FoodItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DayLogMeal",
                columns: table => new
                {
                    MealId = table.Column<long>(nullable: false),
                    DayLogId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DayLogMeal", x => new { x.MealId, x.DayLogId });
                    table.ForeignKey(
                        name: "FK_DayLogMeal_DayLogs_DayLogId",
                        column: x => x.DayLogId,
                        principalTable: "DayLogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DayLogMeal_Meals_MealId",
                        column: x => x.MealId,
                        principalTable: "Meals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MealFoodItem",
                columns: table => new
                {
                    MealId = table.Column<long>(nullable: false),
                    FoodItemId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealFoodItem", x => new { x.MealId, x.FoodItemId });
                    table.ForeignKey(
                        name: "FK_MealFoodItem_FoodItems_FoodItemId",
                        column: x => x.FoodItemId,
                        principalTable: "FoodItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MealFoodItem_Meals_MealId",
                        column: x => x.MealId,
                        principalTable: "Meals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Activities_CreatedUserId",
                table: "Activities",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_DayLogActivity_DayLogId",
                table: "DayLogActivity",
                column: "DayLogId");

            migrationBuilder.CreateIndex(
                name: "IX_DayLogFoodItem_DayLogId",
                table: "DayLogFoodItem",
                column: "DayLogId");

            migrationBuilder.CreateIndex(
                name: "IX_DayLogMeal_DayLogId",
                table: "DayLogMeal",
                column: "DayLogId");

            migrationBuilder.CreateIndex(
                name: "IX_DayLogs_CreatedUserId",
                table: "DayLogs",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodItems_CreatedUserId",
                table: "FoodItems",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MealFoodItem_FoodItemId",
                table: "MealFoodItem",
                column: "FoodItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Meals_CreatedUserId",
                table: "Meals",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserGoals_CreatedUserId",
                table: "UserGoals",
                column: "CreatedUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DayLogActivity");

            migrationBuilder.DropTable(
                name: "DayLogFoodItem");

            migrationBuilder.DropTable(
                name: "DayLogMeal");

            migrationBuilder.DropTable(
                name: "MealFoodItem");

            migrationBuilder.DropTable(
                name: "UserGoals");

            migrationBuilder.DropTable(
                name: "Activities");

            migrationBuilder.DropTable(
                name: "DayLogs");

            migrationBuilder.DropTable(
                name: "FoodItems");

            migrationBuilder.DropTable(
                name: "Meals");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
