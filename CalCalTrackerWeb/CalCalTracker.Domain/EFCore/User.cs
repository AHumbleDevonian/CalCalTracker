using CalCalTracker.Domain.Base;
using CalCalTracker.Domain.Enums;
using System;
using System.Collections.Generic;

namespace CalCalTracker.Domain.EFCore
{
    public class User : Domain.User
    {
        public virtual ICollection<Domain.EFCore.DayLog> DayLogs { get; set; }
        public virtual ICollection<Domain.EFCore.Meal> UserMeals { get; set; }
        public virtual ICollection<Domain.EFCore.FoodItem> UserFoodItems { get; set; }
        public virtual ICollection<Domain.EFCore.Activity> UserActivities { get; set; }
        public virtual ICollection<Domain.EFCore.UserGoal> UserGoals { get; set; }
    }
}
