namespace CalCalTracker.Domain.Units
{
    public class Feet : RealWorldUnit
    {
        protected readonly double _value;
        public double Value => _value;

        internal Feet(double foot)
        {
            if (!IsValid(foot))
                new InvalidValueObjectException("Invalid unit for feet.");
            _value = foot;
        }

        private Feet() { }

        public override bool Equals(object obj)
        {
            if (obj is Feet)
            {
                var item = obj as Feet;

                if (item.Value == Value)
                {
                    return true;
                }
            }
            return false;
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => _value.ToString("0.##") + "Cm";

        public static bool operator !=(Feet a, Feet b) => a.Value != b.Value;

        public static bool operator ==(Feet a, Feet b) => a.Value == b.Value;

        public static Feet From(double foot) => new Feet(foot);

        public static Feet From(Meter meters) => new Feet((meters.Value * 100d) * 0.393701d);

        public static Feet From(Inch inches) => new Feet(inches.Value / 12d);

        public static Feet From(Centimeter centimeters) => new Feet((centimeters.Value * 0.393701d) / 12d);

        public static bool IsValid(double unit) => IsRealWorldUnit(unit);
    }
}
