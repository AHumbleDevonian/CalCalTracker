namespace CalCalTracker.Domain.Units
{
    public class Kilogram :  RealWorldUnit
    {
        protected readonly double _value;
        public double Value => _value;

        internal Kilogram(double kilograms)
        {
            if (!IsValid(kilograms))
                new InvalidValueObjectException("Invalid unit for kilograms.");
            _value = kilograms;
        }

        private Kilogram() { }

        public override bool Equals(object obj)
        {
            if (obj is Kilogram)
            {
                var item = obj as Kilogram;

                if (item.Value == Value)
                {
                    return true;
                }
            }
            return false;
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() =>  _value.ToString() + "Kg";

        public static bool operator !=(Kilogram a, Kilogram b) => a.Value != b.Value;

        public static bool operator ==(Kilogram a, Kilogram b) => a.Value == b.Value;

        public static Kilogram From(double kilograms) => new Kilogram(kilograms);

        public static Kilogram From(Pound pounds) => new Kilogram(pounds.Value / 2.20462d);

        public static Kilogram From(Stone stones) => new Kilogram((stones.Value * 14d) / 2.20462d);

        public static bool IsValid(double unit) => IsRealWorldUnit(unit);
    }
}
