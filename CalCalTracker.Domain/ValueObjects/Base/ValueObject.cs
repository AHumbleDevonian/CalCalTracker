namespace CalCalTracker.Domain
{
    public abstract class ValueObject
    {
        public abstract override bool Equals(object obj);

        public abstract override int GetHashCode();

        public abstract override string ToString();
    }
}
