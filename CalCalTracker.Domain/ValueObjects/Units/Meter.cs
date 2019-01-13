namespace CalCalTracker.Domain.Units
{
    public class Meter : RealWorldUnit
    {
        protected readonly double _value;
        public double Value => _value;

        internal Meter(double meters)
        {
            if (!IsValid(meters))
                new InvalidValueObjectException("Invalid unit for meters.");
            _value = meters;
        }

        private Meter() { }

        public override bool Equals(object obj)
        {
            if (obj is Meter)
            {
                var item = obj as Meter;

                if (item.Value == Value)
                {
                    return true;
                }
            }
            return false;
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => _value.ToString("0.##") + "Cm";

        public static bool operator !=(Meter a, Meter b) => a.Value != b.Value;

        public static bool operator ==(Meter a, Meter b) => a.Value == b.Value;

        public static Meter From(double meters) => new Meter(meters);

        public static Meter From(Centimeter centimeters) => new Meter(centimeters.Value / 100d);

        public static Meter From(Inch inches) => new Meter((inches.Value / 0.393701d) / 100d);

        public static Meter From(Feet foot) => new Meter(((foot.Value * 12) / 0.393701d) / 100d);

        public static bool IsValid(double unit) => IsRealWorldUnit(unit);
    }
}
