namespace CalCalTracker.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialise : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Activities",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Calories = c.Long(nullable: false),
                        IsGlobal = c.Boolean(nullable: false),
                        User_Id = c.Long(),
                        User_Id1 = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .ForeignKey("dbo.Users", t => t.User_Id1)
                .Index(t => t.User_Id)
                .Index(t => t.User_Id1);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        DateOfBirth = c.DateTime(),
                        Gender = c.Int(),
                        Weight = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FoodItems",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        IsGlobal = c.Boolean(nullable: false),
                        Calories = c.Double(nullable: false),
                        Fat = c.Double(nullable: false),
                        SaturatedFat = c.Double(nullable: false),
                        PolyunsaturatedFat = c.Double(nullable: false),
                        MonounsaturatedFat = c.Double(nullable: false),
                        Cholesterol = c.Double(nullable: false),
                        Carbohydrates = c.Double(nullable: false),
                        Sugar = c.Double(nullable: false),
                        Fibre = c.Double(nullable: false),
                        Protein = c.Double(nullable: false),
                        VitaminA = c.Double(nullable: false),
                        VitaminB1 = c.Double(nullable: false),
                        VitaminB2 = c.Double(nullable: false),
                        VitaminB3 = c.Double(nullable: false),
                        VitaminB6 = c.Double(nullable: false),
                        VitaminB7 = c.Double(nullable: false),
                        VitaminB12 = c.Double(nullable: false),
                        PantothenicAcid = c.Double(nullable: false),
                        FolicAcid = c.Double(nullable: false),
                        VitaminC = c.Double(nullable: false),
                        VitaminD = c.Double(nullable: false),
                        VitaminE = c.Double(nullable: false),
                        VitaminK = c.Double(nullable: false),
                        BetaCarotene = c.Double(nullable: false),
                        Calcium = c.Double(nullable: false),
                        Chromium = c.Double(nullable: false),
                        Cobalt = c.Double(nullable: false),
                        Copper = c.Double(nullable: false),
                        Iodine = c.Double(nullable: false),
                        Iron = c.Double(nullable: false),
                        Magnesium = c.Double(nullable: false),
                        Manganese = c.Double(nullable: false),
                        Molybdenum = c.Double(nullable: false),
                        Phosphorus = c.Double(nullable: false),
                        Potassium = c.Double(nullable: false),
                        Selenium = c.Double(nullable: false),
                        Sodium = c.Double(nullable: false),
                        Zinc = c.Double(nullable: false),
                        User_Id = c.Long(nullable: false),
                        User_Id1 = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .ForeignKey("dbo.Users", t => t.User_Id1)
                .Index(t => t.User_Id)
                .Index(t => t.User_Id1);
            
            CreateTable(
                "dbo.Meals",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        IsGlobal = c.Boolean(nullable: false),
                        User_Id = c.Long(nullable: false),
                        User_Id1 = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .ForeignKey("dbo.Users", t => t.User_Id1)
                .Index(t => t.User_Id)
                .Index(t => t.User_Id1);
            
            CreateTable(
                "dbo.UserLogs",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Weight = c.Double(),
                        CalculatedWeight = c.Double(nullable: false),
                        User_Id = c.Long(nullable: false),
                        User_Id1 = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .ForeignKey("dbo.Users", t => t.User_Id1)
                .Index(t => t.User_Id)
                .Index(t => t.User_Id1);
            
            CreateTable(
                "dbo.UserGoals",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        TargetWeight = c.Double(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                        Active = c.Boolean(nullable: false),
                        GoalDate = c.DateTime(),
                        AchievedDate = c.DateTime(nullable: false),
                        User_Id = c.Long(nullable: false),
                        User_Id1 = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .ForeignKey("dbo.Users", t => t.User_Id1)
                .Index(t => t.User_Id)
                .Index(t => t.User_Id1);
            
            CreateTable(
                "dbo.UserLogActivities",
                c => new
                    {
                        UserLog_Id = c.Long(nullable: false),
                        Activity_Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserLog_Id, t.Activity_Id })
                .ForeignKey("dbo.UserLogs", t => t.UserLog_Id, cascadeDelete: true)
                .ForeignKey("dbo.Activities", t => t.Activity_Id, cascadeDelete: true)
                .Index(t => t.UserLog_Id)
                .Index(t => t.Activity_Id);
            
            CreateTable(
                "dbo.UserLogFoodItems",
                c => new
                    {
                        UserLog_Id = c.Long(nullable: false),
                        FoodItem_Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserLog_Id, t.FoodItem_Id })
                .ForeignKey("dbo.UserLogs", t => t.UserLog_Id, cascadeDelete: true)
                .ForeignKey("dbo.FoodItems", t => t.FoodItem_Id, cascadeDelete: true)
                .Index(t => t.UserLog_Id)
                .Index(t => t.FoodItem_Id);
            
            CreateTable(
                "dbo.UserLogMeals",
                c => new
                    {
                        UserLog_Id = c.Long(nullable: false),
                        Meal_Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserLog_Id, t.Meal_Id })
                .ForeignKey("dbo.UserLogs", t => t.UserLog_Id, cascadeDelete: true)
                .ForeignKey("dbo.Meals", t => t.Meal_Id, cascadeDelete: true)
                .Index(t => t.UserLog_Id)
                .Index(t => t.Meal_Id);
            
            CreateTable(
                "dbo.FoodItemMeals",
                c => new
                    {
                        FoodItem_Id = c.Long(nullable: false),
                        Meal_Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.FoodItem_Id, t.Meal_Id })
                .ForeignKey("dbo.FoodItems", t => t.FoodItem_Id, cascadeDelete: true)
                .ForeignKey("dbo.Meals", t => t.Meal_Id, cascadeDelete: true)
                .Index(t => t.FoodItem_Id)
                .Index(t => t.Meal_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Activities", "User_Id1", "dbo.Users");
            DropForeignKey("dbo.Meals", "User_Id1", "dbo.Users");
            DropForeignKey("dbo.UserLogs", "User_Id1", "dbo.Users");
            DropForeignKey("dbo.UserGoals", "User_Id1", "dbo.Users");
            DropForeignKey("dbo.UserGoals", "User_Id", "dbo.Users");
            DropForeignKey("dbo.FoodItems", "User_Id1", "dbo.Users");
            DropForeignKey("dbo.FoodItems", "User_Id", "dbo.Users");
            DropForeignKey("dbo.FoodItemMeals", "Meal_Id", "dbo.Meals");
            DropForeignKey("dbo.FoodItemMeals", "FoodItem_Id", "dbo.FoodItems");
            DropForeignKey("dbo.UserLogs", "User_Id", "dbo.Users");
            DropForeignKey("dbo.UserLogMeals", "Meal_Id", "dbo.Meals");
            DropForeignKey("dbo.UserLogMeals", "UserLog_Id", "dbo.UserLogs");
            DropForeignKey("dbo.UserLogFoodItems", "FoodItem_Id", "dbo.FoodItems");
            DropForeignKey("dbo.UserLogFoodItems", "UserLog_Id", "dbo.UserLogs");
            DropForeignKey("dbo.UserLogActivities", "Activity_Id", "dbo.Activities");
            DropForeignKey("dbo.UserLogActivities", "UserLog_Id", "dbo.UserLogs");
            DropForeignKey("dbo.Meals", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Activities", "User_Id", "dbo.Users");
            DropIndex("dbo.FoodItemMeals", new[] { "Meal_Id" });
            DropIndex("dbo.FoodItemMeals", new[] { "FoodItem_Id" });
            DropIndex("dbo.UserLogMeals", new[] { "Meal_Id" });
            DropIndex("dbo.UserLogMeals", new[] { "UserLog_Id" });
            DropIndex("dbo.UserLogFoodItems", new[] { "FoodItem_Id" });
            DropIndex("dbo.UserLogFoodItems", new[] { "UserLog_Id" });
            DropIndex("dbo.UserLogActivities", new[] { "Activity_Id" });
            DropIndex("dbo.UserLogActivities", new[] { "UserLog_Id" });
            DropIndex("dbo.UserGoals", new[] { "User_Id1" });
            DropIndex("dbo.UserGoals", new[] { "User_Id" });
            DropIndex("dbo.UserLogs", new[] { "User_Id1" });
            DropIndex("dbo.UserLogs", new[] { "User_Id" });
            DropIndex("dbo.Meals", new[] { "User_Id1" });
            DropIndex("dbo.Meals", new[] { "User_Id" });
            DropIndex("dbo.FoodItems", new[] { "User_Id1" });
            DropIndex("dbo.FoodItems", new[] { "User_Id" });
            DropIndex("dbo.Activities", new[] { "User_Id1" });
            DropIndex("dbo.Activities", new[] { "User_Id" });
            DropTable("dbo.FoodItemMeals");
            DropTable("dbo.UserLogMeals");
            DropTable("dbo.UserLogFoodItems");
            DropTable("dbo.UserLogActivities");
            DropTable("dbo.UserGoals");
            DropTable("dbo.UserLogs");
            DropTable("dbo.Meals");
            DropTable("dbo.FoodItems");
            DropTable("dbo.Users");
            DropTable("dbo.Activities");
        }
    }
}
