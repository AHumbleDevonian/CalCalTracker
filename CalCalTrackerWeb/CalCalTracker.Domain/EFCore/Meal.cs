using CalCalTracker.Domain.EFCore.Joins;
using CalCalTracker.Domain;
using System.Collections.Generic;

namespace CalCalTracker.Domain.EFCore
{
    public class Meal : Domain.Meal
    {
        public virtual ICollection<DayLogMeal> MealDayLogs { get; set; }
        public virtual ICollection<MealFoodItem> MealFoodItems { get; set; }
        public virtual Domain.EFCore.User CreatedUser { get; set; }
    }
}
