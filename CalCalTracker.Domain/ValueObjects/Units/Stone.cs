namespace CalCalTracker.Domain.Units
{
    public class Stone : RealWorldUnit
    {
        protected readonly double _value;
        public double Value => _value;

        internal Stone(double stones)
        {
            if (!IsValid(stones))
                new InvalidValueObjectException("Invalid unit for stones.");
            _value = stones;
        }

        private Stone() { }

        public override bool Equals(object obj)
        {
            if (obj is Stone)
            {
                var item = obj as Stone;

                if (item.Value == Value)
                {
                    return true;
                }
            }
            return false;
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => _value.ToString() + "St";

        public static bool operator !=(Stone a, Stone b) => a.Value != b.Value;

        public static bool operator ==(Stone a, Stone b) => a.Value == b.Value;

        public static Stone From(double stones) => new Stone(stones);

        public static Stone From(Pound pounds) => new Stone(pounds.Value / 14d);

        public static Stone From(Kilogram kilograms) => new Stone((kilograms.Value * 2.20462d) / 14d);

        public static bool IsValid(double unit) => IsRealWorldUnit(unit);
    }
}
