using CalCalTracker.Domain.EFCore;
using CalCalTracker.Domain.EFCore.Joins;
using Microsoft.EntityFrameworkCore;
using System;

namespace CalCalTracker.Persistence.Core
{
    public class CalCalTrackerContext: DbContext
    {
        public CalCalTrackerContext(DbContextOptions<CalCalTrackerContext> options)
            : base(options)
        { }

        public DbSet<FoodItem> FoodItems { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<DayLog> DayLogs { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserGoal> UserGoals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DayLogActivity>().HasKey(dayLogActivity => new { dayLogActivity.ActivityId, dayLogActivity.DayLogId });
            modelBuilder.Entity<DayLogActivity>().HasOne(dayLogActivity => dayLogActivity.Activity)
                .WithMany(activity => activity.ActivityDayLogs).HasForeignKey(dayLogActivity => dayLogActivity.ActivityId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<DayLogActivity>().HasOne(dayLogActivity => dayLogActivity.DayLog)
                .WithMany(dayLog => dayLog.DayLogActivities).HasForeignKey(dayLogActivity => dayLogActivity.DayLogId).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DayLogFoodItem>().HasKey(dayLogFoodItem => new { dayLogFoodItem.FoodItemId, dayLogFoodItem.DayLogId });
            modelBuilder.Entity<DayLogFoodItem>().HasOne(dayLogFoodItem => dayLogFoodItem.FoodItem)
                .WithMany(foodItem => foodItem.FoodItemDayLogs).HasForeignKey(dayLogFoodItem => dayLogFoodItem.FoodItemId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<DayLogFoodItem>().HasOne(dayLogFoodItem => dayLogFoodItem.DayLog)
                .WithMany(dayLog => dayLog.DayLogFoodItems).HasForeignKey(dayLogFoodItem => dayLogFoodItem.DayLogId).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DayLogMeal>().HasKey(dayLogMeal => new { dayLogMeal.MealId, dayLogMeal.DayLogId });
            modelBuilder.Entity<DayLogMeal>().HasOne(dayLogMeal => dayLogMeal.Meal)
                .WithMany(meal => meal.MealDayLogs).HasForeignKey(dayLogMeal => dayLogMeal.MealId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<DayLogMeal>().HasOne(dayLogMeal => dayLogMeal.DayLog)
                .WithMany(dayLog => dayLog.DayLogMeals).HasForeignKey(dayLogMeal => dayLogMeal.DayLogId).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<MealFoodItem>().HasKey(mealFoodItem => new { mealFoodItem.MealId, mealFoodItem.FoodItemId });
            modelBuilder.Entity<MealFoodItem>().HasOne(mealFoodItem => mealFoodItem.Meal)
                .WithMany(meal => meal.MealFoodItems).HasForeignKey(mealFoodItem => mealFoodItem.MealId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<MealFoodItem>().HasOne(mealFoodItem => mealFoodItem.FoodItem)
                .WithMany(foodItem => foodItem.FoodItemMeals).HasForeignKey(mealFoodItem => mealFoodItem.FoodItemId).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DayLog>().HasOne(dayLog => dayLog.CreatedUser).WithMany(user => user.DayLogs).IsRequired();
            modelBuilder.Entity<UserGoal>().HasOne(userGoal => userGoal.CreatedUser).WithMany(user => user.UserGoals).IsRequired();
            modelBuilder.Entity<FoodItem>().HasOne(foodItem => foodItem.CreatedUser).WithMany(user => user.UserFoodItems).IsRequired();
            modelBuilder.Entity<Meal>().HasOne(meal => meal.CreatedUser).WithMany(user => user.UserMeals).IsRequired();
            modelBuilder.Entity<Activity>().HasOne(activity => activity.CreatedUser).WithMany(user => user.UserActivities).IsRequired();
        }
    }
}
