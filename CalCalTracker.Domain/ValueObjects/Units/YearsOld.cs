namespace CalCalTracker.Domain.Units
{
    public class YearsOld : RealWorldUnit
    {
        protected readonly int _value;
        public int Value => _value;

        internal YearsOld(int age)
        {
            if (!IsValid(age))
                throw new InvalidValueObjectException("Invalid unit for years old.");

           _value = age;
        }

        private YearsOld() { }

        public override bool Equals(object obj)
        {
            if (obj is YearsOld)
            {
                var item = obj as YearsOld;

                if (item.Value == Value)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(YearsOld a, YearsOld b) => a.Value != b.Value;

        public static bool operator ==(YearsOld a, YearsOld b) => a.Value == b.Value;

        public static bool IsValid(int unit) => IsRealWorldUnit(unit);

        public static YearsOld From(int age)
        {
            return new YearsOld(age);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => _value.ToString();
    }
}
