namespace CalCalTracker.Domain
{
    public class Weight : ValueObject
    {
        protected readonly double? _value;
        public double ValueInKg => _value ?? 66;
        public double ValueInLb => ValueInKg * 2.20462d;
        public double ValueInStone => ValueInLb / 14;

        internal Weight(double? Weight)
        {
            if (Weight != null && (Weight < 12 || Weight > 100))
                throw new InvalidValueObjectException("Weight is out of range.");

            _value = Weight;
        }

        private Weight() { }

        public override bool Equals(object obj)
        {
            if (obj is Weight)
            {
                var item = obj as Weight;

                if (item.ValueInKg == ValueInKg)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Weight a, Weight b) => a.ValueInKg != b.ValueInKg;

        public static bool operator ==(Weight a, Weight b) => a.ValueInKg == b.ValueInKg;

        public static Weight From(double? Weight)
        {
            return new Weight(Weight);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => _value != null ? _value.ToString() : "Unknown";
    }
}
