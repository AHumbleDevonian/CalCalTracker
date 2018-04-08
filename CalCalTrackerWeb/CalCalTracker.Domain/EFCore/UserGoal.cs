using CalCalTracker.Domain.Base;
using System;

namespace CalCalTracker.Domain.EFCore
{
    public class UserGoal : Domain.UserGoal
    {
        public virtual Domain.EFCore.User CreatedUser { get; set; }
    }
}
