using CalCalTracker.Domain.Base;
using System;

namespace CalCalTracker.Domain
{
    public abstract class DayLog : CalCalEntity
    {
        public DateTime Date { get; set; }
        public double? Weight { get; set; }
        public double CalculatedWeight { get; set; }
    }
}
