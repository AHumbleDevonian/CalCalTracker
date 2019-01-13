namespace CalCalTracker.Domain.Units
{
    public class Inch : RealWorldUnit
    {
        protected readonly double _value;
        public double Value => _value;

        internal Inch(double inches)
        {
            if (!IsValid(inches))
                new InvalidValueObjectException("Invalid unit for inches.");
            _value = inches;
        }

        private Inch() { }

        public override bool Equals(object obj)
        {
            if (obj is Inch)
            {
                var item = obj as Inch;

                if (item.Value == Value)
                {
                    return true;
                }
            }
            return false;
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => _value.ToString("0.##") + "Cm";

        public static bool operator !=(Inch a, Inch b) => a.Value != b.Value;

        public static bool operator ==(Inch a, Inch b) => a.Value == b.Value;

        public static Inch From(double inches) => new Inch(inches);

        public static Inch From(Meter meters) => new Inch((meters.Value * 100d) * 0.393701d);

        public static Inch From(Centimeter centimeters) => new Inch(centimeters.Value * 0.393701d);

        public static Inch From(Feet foot) => new Inch(foot.Value * 12d);

        public static bool IsValid(double unit) => IsRealWorldUnit(unit);
    }
}
