using System;

namespace CalCalTracker.Domain.Base
{
    public abstract class CalCalEntity
    {
        protected DateTimeOffset _createdDate;
        protected DateTimeOffset _modifiedDate;
        protected long _id;

        protected CalCalEntity()
        {
            _modifiedDate = DateTimeOffset.UtcNow;
            _createdDate = DateTimeOffset.UtcNow;
        }

        public long Id => _id;
        public DateTimeOffset CreatedDate => _createdDate;
        public DateTimeOffset ModifiedDate => _modifiedDate;
    }
}
