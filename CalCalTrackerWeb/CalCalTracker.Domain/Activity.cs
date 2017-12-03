using System;
using System.Collections.Generic;
using System.Text;

namespace CalCalTracker.Domain
{
    public class Activity
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long Calories { get; set; }
        public bool IsGlobal { get; set; }
        public virtual User User { get;set; }
        public virtual ICollection<UserLog> UserLogs { get; set; }
    }
}
