using System;

namespace FluentTypes.Exceptions
{
    internal sealed class NullObjectInstantiationException : Exception
    {
        public NullObjectInstantiationException() : base("Null Objects are allowed only one instantiation")
        { }
    }
}