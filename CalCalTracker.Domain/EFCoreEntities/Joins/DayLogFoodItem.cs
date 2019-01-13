namespace CalCalTracker.Domain.EFCore.Joins
{
    public class DayLogFoodItem
    {
        public long DayLogId { get; set; }
        public long FoodItemId { get; set; }

        public Domain.EFCore.FoodItem FoodItem { get; set; }
        public Domain.EFCore.DayLog DayLog { get; set; }
    }
}
