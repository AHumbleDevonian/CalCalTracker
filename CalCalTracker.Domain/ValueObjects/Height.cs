namespace CalCalTracker.Domain
{
    public class Height : ValueObject
    {
        protected readonly double? _valueKilograms;
        public double ValueInKg => _valueKilograms ?? 0;
        public double ValueInLb => ValueInKg * 2.20462d;
        public double ValueInStone => ValueInLb / 14;

        internal Height(double? Height)
        {
            if (Height != null && (Height < 17 || Height > 200))
                throw new InvalidValueObjectException("Height is out of range.");

            _value = Height;
        }

        private Height() { }

        public override bool Equals(object obj)
        {
            if (obj is Height)
            {
                var item = obj as Height;

                if (item.Value == Value)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Height a, Height b) => a.Value != b.Value;

        public static bool operator ==(Height a, Height b) => a.Value == b.Value;

        public static Height From(double? Height)
        {
            return new Height(Height);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => _value != null ? _value.ToString() : "Unknown";
    }
}
