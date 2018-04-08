using CalCalTracker.Domain.Base;
using System;

namespace CalCalTracker.Domain
{
    public class DayLog : CalCalEntity
    {
        public DateTime Date { get; set; }
        public double? Weight { get; set; }
        public double CalculatedWeight { get; set; }
    }
}
