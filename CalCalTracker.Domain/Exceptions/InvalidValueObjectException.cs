using System;

namespace CalCalTracker.Domain
{
    public class InvalidValueObjectException : Exception
    {
        public InvalidValueObjectException(string message) : base(message) { }
    }
}
