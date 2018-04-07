using FluentTypes.Numbers.Dbls;
using FluentTypes.Numbers.Ints;

namespace FluentTypes.Numbers
{
    public abstract class Number
    {
        public abstract Int AsInt();
        public abstract Dbl AsDbl();
    }
}
