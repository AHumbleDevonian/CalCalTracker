using CalCalTracker.Domain.EFCore.Joins;
using CalCalTracker.Domain;
using System.Collections.Generic;

namespace CalCalTracker.Domain.EFCore
{
    public class DayLog : Domain.DayLog
    {
        public virtual ICollection<DayLogMeal> DayLogMeals { get; set; }
        public virtual ICollection<DayLogFoodItem> DayLogFoodItems { get; set; }
        public virtual ICollection<DayLogActivity> DayLogActivities { get; set; }
        public virtual Domain.EFCore.User CreatedUser { get; set; }
    }
}
