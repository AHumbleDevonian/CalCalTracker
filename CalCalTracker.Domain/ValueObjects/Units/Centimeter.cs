namespace CalCalTracker.Domain.Units
{
    public class Centimeter : RealWorldUnit
    {
        protected readonly double _value;
        public double Value => _value;

        internal Centimeter(double centimeters)
        {
            if (!IsValid(centimeters))
                new InvalidValueObjectException("Invalid unit for centimeters.");
            _value = centimeters;
        }

        private Centimeter() { }

        public override bool Equals(object obj)
        {
            if (obj is Centimeter)
            {
                var item = obj as Centimeter;

                if (item.Value == Value)
                {
                    return true;
                }
            }
            return false;
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => _value.ToString("0.##") + "Cm";

        public static bool operator !=(Centimeter a, Centimeter b) => a.Value != b.Value;

        public static bool operator ==(Centimeter a, Centimeter b) => a.Value == b.Value;

        public static Centimeter From(double centimeters) => new Centimeter(centimeters);

        public static Centimeter From(Meter meters) => new Centimeter(meters.Value * 100d);

        public static Centimeter From(Inch inches) => new Centimeter(inches.Value / 0.393701d);

        public static Centimeter From(Feet foot) => new Centimeter((foot.Value * 12) / 0.393701d);

        public static bool IsValid(double unit) => IsRealWorldUnit(unit);
    }
}
