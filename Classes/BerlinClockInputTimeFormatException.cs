using System;

namespace BerlinClock
{
    public class BerlinClockInputTimeFormatException : Exception
    {
        public BerlinClockInputTimeFormatException() { }
        public BerlinClockInputTimeFormatException(string message) : base(message) { }
        public BerlinClockInputTimeFormatException(string message, Exception innerException) : base(message, innerException) { }
    }
}