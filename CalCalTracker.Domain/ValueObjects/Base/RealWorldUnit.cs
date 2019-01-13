namespace CalCalTracker.Domain
{
    public abstract class RealWorldUnit : ValueObject
    {
        public static bool IsRealWorldUnit(double unit) => unit >= 0;
    }
}
