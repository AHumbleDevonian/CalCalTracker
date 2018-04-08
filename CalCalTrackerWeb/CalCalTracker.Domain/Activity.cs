using CalCalTracker.Domain.Base;

namespace CalCalTracker.Domain
{
    public class Activity : CalCalEntity
    {
        public string Name { get; set; }
        public long Calories { get; set; }
        public bool IsGlobal { get; set; }     
    }
}
