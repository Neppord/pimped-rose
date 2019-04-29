using System;

namespace PimpedRose
{
    public class Id<T>
    {
        public readonly T Value;

        public Id(T value)
        {
            Value = value;
        }

        public Id<R> Select<R>(Func<T, R> func)
        {
            return null;
        }
    }
}