using System;

namespace CalCalTracker.Domain.Base
{
    public class CalCalEntity
    {
        protected CalCalEntity()
        {
            CreationDate = DateTime.Now;
            UpdatedDate = DateTime.Now;
        }

        public long Id { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
