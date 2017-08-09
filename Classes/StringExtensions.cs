using System.Text;

namespace BerlinClock
{
    public static class StringExtensions
    {
        public static string Repeat(this string stringToRepeat, int repeatCount)
        {
            var builder = new StringBuilder(repeatCount * stringToRepeat.Length);
            for (int i = 0; i < repeatCount; i++)
            {
                builder.Append(stringToRepeat);
            }
            return builder.ToString();
        }    
    }
}