namespace CalCalTracker.Domain.Units
{
    public class Pound : RealWorldUnit
    {
        protected readonly double _value;
        public double Value => _value;

        internal Pound(double pounds)
        {
            if (!IsValid(pounds))
                new InvalidValueObjectException("Invalid unit for pounds.");
            _value = pounds;
        }

        private Pound() { }

        public override bool Equals(object obj)
        {
            if (obj is Pound)
            {
                var item = obj as Pound;

                if (item.Value == Value)
                {
                    return true;
                }
            }
            return false;
        }
        
        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => _value.ToString("0.##") + "Lb";

        public static bool operator !=(Pound a, Pound b) => a.Value != b.Value;

        public static bool operator ==(Pound a, Pound b) => a.Value == b.Value;

        public static Pound From(double Pounds) => new Pound(Pounds);

        public static Pound From(Kilogram kilograms) => new Pound(kilograms.Value * 2.20462d);

        public static Pound From(Stone stones) => new Pound(stones.Value * 14d);

        public static bool IsValid(double unit) => IsRealWorldUnit(unit);
    }
}
