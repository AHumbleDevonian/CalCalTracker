using CalCalTracker.Domain.EFCore.Joins;
using CalCalTracker.Domain;
using System.Collections.Generic;

namespace CalCalTracker.Domain.EFCore
{
    public class Food : Domain.Food
    {
        public virtual ICollection<MealFoodItem> FoodItemMeals { get; set; }
        public virtual ICollection<DayLogFoodItem> FoodItemDayLogs { get; set; }
        public virtual Domain.EFCore.User CreatedUser { get; set; }
    }
}
