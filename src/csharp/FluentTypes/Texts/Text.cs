using FluentTypes.Bools;

namespace FluentTypes.Texts
{
    public abstract class Text
    {
        public static implicit operator string(Text origin) => origin.RawValue();

        public Bool IsEqual(Text other) => new TextEquals(this, other);

        protected abstract string RawValue();
    }
}