using System;
using System.Collections.Generic;
using System.Text;

namespace CalCalTracker.Domain
{
    public class UserGoal
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public double TargetWeight { get; set; }
        public DateTime CreationDate { get; set; }
        public bool Active { get; set; }
        public DateTime? GoalDate { get; set; }
        public DateTime AchievedDate { get; set; }
        public virtual User User { get; set; }
    }
}
