using System;
using System.Collections.Generic;
using System.Text;

namespace CalCalTracker.Domain
{
    public class UserLog
    {
        public long Id { get; set; }
        public DateTime Date { get; set; }
        public double? Weight { get; set; }
        public double CalculatedWeight { get; set; }
        public virtual ICollection<FoodItem> Foods { get; set; }
        public virtual ICollection<Meal> Meals { get; set; }
        public virtual ICollection<Activity> Activities { get; set; }
        public virtual User User { get; set; }
    }
}
