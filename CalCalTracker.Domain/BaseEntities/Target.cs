using CalCalTracker.Domain.Base;
using System;

namespace CalCalTracker.Domain
{
    public abstract class Target : CalCalEntity
    {
        public string Name { get; set; }
        public double TargetWeight { get; set; }
        public bool Active { get; set; }
        public DateTime? GoalDate { get; set; }
        public DateTime AchievedDate { get; set; }
    }
}
