using CalCalTracker.Domain.Base;

namespace CalCalTracker.Domain
{
    public abstract class Exercise : CalCalEntity
    {
        public string Name { get; set; }
        public long Calories { get; set; }
        public bool IsGlobal { get; set; }     
    }
}
