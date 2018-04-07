using FluentTypes.Numbers.Ints;

namespace FluentTypes.Texts
{
    public class IntToText : Text
    {
        private readonly Int _origin;

        public IntToText(Int origin) => _origin = origin;

        protected override string RawValue() => ((int)_origin).ToString();
    }
}