using System;

namespace lab2
{
    public class RomanNumberException : Exception
    {
        public RomanNumberException (string message)
            : base(message)
        {}
    }
}
