using CalCalTracker.Domain.Enums;
using System;

namespace CalCalTracker.Infrastructure.Dtos
{
    public class GetUserDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public Gender? Gender { get; set; }
        public double Weight { get; set; }
    }
}
