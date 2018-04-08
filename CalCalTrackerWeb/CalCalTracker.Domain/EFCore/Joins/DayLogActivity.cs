namespace CalCalTracker.Domain.EFCore.Joins
{
    public class DayLogActivity
    {
        public long DayLogId { get; set; }
        public long ActivityId { get; set; }

        public Domain.EFCore.DayLog DayLog { get; set; }
        public Domain.EFCore.Activity Activity { get; set; }
    }
}
