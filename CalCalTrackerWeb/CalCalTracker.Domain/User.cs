using CalCalTracker.Domain.Base;
using CalCalTracker.Domain.Enums;
using System;
using System.Collections.Generic;

namespace CalCalTracker.Domain
{
    public class User : CalCalEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public Gender? Gender { get; set; }
        public double Weight { get; set; }
    }
}
