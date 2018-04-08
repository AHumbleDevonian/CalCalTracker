namespace CalCalTracker.Domain.EFCore.Joins
{
    public class MealFoodItem
    {
        public long MealId { get; set; }
        public long FoodItemId { get; set; }

        public Domain.EFCore.Meal Meal { get; set; }
        public Domain.EFCore.FoodItem FoodItem { get; set; }
    }
}
