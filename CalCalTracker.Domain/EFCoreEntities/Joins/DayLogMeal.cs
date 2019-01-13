namespace CalCalTracker.Domain.EFCore.Joins
{
    public class DayLogMeal
    {
        public long MealId { get; set; }
        public long DayLogId { get; set; }

        public Domain.EFCore.Meal Meal { get; set; }
        public Domain.EFCore.DayLog DayLog { get; set; }
    }
}
