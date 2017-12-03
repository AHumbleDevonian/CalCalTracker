using CalCalTracker.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalTracker.DAL
{
    public class CalCalContext : DbContext
    {
        public CalCalContext() : base("DefaultConnection") { }
        public CalCalContext(string connection): base(connection) { }

        public DbSet<User> Users { get; set; }
        public DbSet<UserLog> UserLogs { get; set; }
        public DbSet<UserGoal> UserGoals { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<FoodItem> FoodItems { get; set; }
        public DbSet<Activity> Activities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(user => user.Id);
            modelBuilder.Entity<UserLog>().HasKey(userLog => userLog.Id);
            modelBuilder.Entity<UserGoal>().HasKey(userGoal => userGoal.Id);
            modelBuilder.Entity<Meal>().HasKey(meal => meal.Id);
            modelBuilder.Entity<FoodItem>().HasKey(foodItem => foodItem.Id);
            modelBuilder.Entity<Activity>().HasKey(activity => activity.Id);

            modelBuilder.Entity<UserLog>().HasRequired(userLog => userLog.User).WithMany().WillCascadeOnDelete(false);
            modelBuilder.Entity<UserGoal>().HasRequired(userGoal => userGoal.User).WithMany().WillCascadeOnDelete(false);
            modelBuilder.Entity<Meal>().HasRequired(meal => meal.User).WithMany().WillCascadeOnDelete(false);
            modelBuilder.Entity<FoodItem>().HasRequired(foodItem => foodItem.User).WithMany().WillCascadeOnDelete(false);
            modelBuilder.Entity<Activity>().HasRequired(activity => activity.User).WithMany().WillCascadeOnDelete(false);

            modelBuilder.Entity<FoodItem>().HasMany(foodItem => foodItem.Meals).WithMany(meal => meal.FoodItems);

            modelBuilder.Entity<UserLog>().HasMany(userLog => userLog.Meals).WithMany(meal => meal.UserLogs);
            modelBuilder.Entity<UserLog>().HasMany(userLog => userLog.Foods).WithMany(foodItem => foodItem.UserLogs);
            modelBuilder.Entity<UserLog>().HasMany(userLog => userLog.Activities).WithMany(activities => activities.UserLogs);

        }
    }
}
