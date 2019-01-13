namespace CalCalTracker.Domain
{
    public class Sex : ValueObject
    {
        protected readonly SexEnum? _value;
        public SexEnum Value => _value ?? SexEnum.Male;

        internal Sex(SexEnum? sexEnum)
        {
            _value = sexEnum;
        }

        private Sex() {  }

        public override bool Equals(object obj)
        {
            if(obj is Sex)
            {
                var item = obj as Sex;

                if (item.Value == Value)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Sex a, Sex b) => a.Value != b.Value;

        public static bool operator ==(Sex a, Sex b) => a.Value == b.Value;

        public static Sex From(SexEnum sexEnum)
        {
            return new Sex(sexEnum);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => _value != null ? _value.ToString() : "Unspecified";
    }

    public enum SexEnum
    {
        Male,
        Female
    }
}
