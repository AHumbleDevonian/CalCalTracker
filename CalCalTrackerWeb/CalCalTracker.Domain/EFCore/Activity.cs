using CalCalTracker.Domain.EFCore.Joins;
using CalCalTracker.Domain;
using System.Collections.Generic;

namespace CalCalTracker.Domain.EFCore
{
    public class Activity :  Domain.Activity
    {
        public virtual ICollection<DayLogActivity> ActivityDayLogs { get; set; }
        public virtual Domain.EFCore.User CreatedUser { get; set; }
    }
}
