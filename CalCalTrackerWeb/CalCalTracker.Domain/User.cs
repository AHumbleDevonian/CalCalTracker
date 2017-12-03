using CalCalTracker.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalCalTracker.Domain
{
    public class User
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public Gender? Gender { get; set; }
        public double Weight { get; set; }
        public virtual ICollection<UserLog> UserLogs { get; set; }
        public virtual ICollection<Meal> UserMeals { get; set; }
        public virtual ICollection<FoodItem> UserFoodItems { get; set; }
        public virtual ICollection<Activity> UserActivites { get; set; }
        public virtual ICollection<UserGoal> UserGoals { get; set; }
    }
}
