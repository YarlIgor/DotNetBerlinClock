using System;
using System.Text.RegularExpressions;

namespace BerlinClock
{
    public class TimeConverter : ITimeConverter
    {
        public string convertTime(string time)
        {
            var berlinClockInputTime = GetBerlinClockInputTime(time);
            var seconds = GetSeconds(berlinClockInputTime.Seconds);
            var topRowHours = GetTopRowHours(berlinClockInputTime.Hours);
            var bottomRowHours = GetBottomRowHours(berlinClockInputTime.Hours);
            var topRowMinutes = GetTopRowMinutes(berlinClockInputTime.Minutes);
            var bottomRowMinutes = GetBottomRowMinutes(berlinClockInputTime.Minutes);
            return String.Join(" ", seconds, topRowHours, bottomRowHours, topRowMinutes, bottomRowMinutes);
        }

        // TODO: For the moment, let's allow the following time formats: 24:00:00 or HH:mm:ss. Futher clarification is required whether or not to support 24 clock (24:34:56) or just 24:00:00
        // Respective tests could be added after the clarification
        private BerlinClockInputTime GetBerlinClockInputTime(string time)
        {
            if (string.IsNullOrEmpty(time) || time.Length != 8)
                throw new BerlinClockInputTimeFormatException("BerlinClock input time could be 24:00:00 or HH:mm:ss. Please specify time in the correct format.");

            if (string.Equals(time, "24:00:00", StringComparison.InvariantCultureIgnoreCase))
                return BerlinClockInputTime.Midnight;

            var regex = new Regex("^([0-1][0-9]|2[0-3]):([0-5][0-9]):([0-5][0-9])$", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            var match = regex.Match(time);

            if (!match.Success)
            {
                throw new BerlinClockInputTimeFormatException("BerlinClock input time could be 24:00:00 or HH:mm:ss. Please specify time in the correct format.");
            }

            return new BerlinClockInputTime(int.Parse(match.Groups[1].Value), int.Parse(match.Groups[2].Value), int.Parse(match.Groups[3].Value));
        }

        private string GetSeconds(int secondsPart)
        {
            return (secondsPart % 2 == 0) ? LampLightState.Yellow : LampLightState.Off;
        }

        private string GetTopRowHours(int hoursPart)
        {
            return GetLampsStatesRow(4, hoursPart / 5, LampLightState.Red);
        }

        private string GetBottomRowHours(int hoursPart)
        {
            return GetLampsStatesRow(4, hoursPart % 5, LampLightState.Red);
        }

        private string GetTopRowMinutes(int minutesPart)
        {
            return GetLampsStatesRow(11, minutesPart / 5, LampLightState.Yellow).Replace("YYY", "YYR");
        }

        private string GetBottomRowMinutes(int minutesPart)
        {
            return GetLampsStatesRow(4, minutesPart % 5, LampLightState.Yellow);
        }

        private string GetLampsStatesRow(int totalLampsCount, int lampsStateCount, string lampLightState)
        {
            return lampLightState.Repeat(lampsStateCount) + LampLightState.Off.Repeat(totalLampsCount - lampsStateCount);
        }

        struct BerlinClockInputTime
        {
            public readonly int Hours;
            public readonly int Minutes;
            public readonly int Seconds;

            public static BerlinClockInputTime Midnight = new BerlinClockInputTime(24, 0, 0);

            public BerlinClockInputTime(int hours, int minutes, int seconds)
            {
                Hours = hours;
                Minutes = minutes;
                Seconds = seconds;
            }
        }

        internal static class LampLightState
        {
            internal static string Yellow = "Y";
            internal static string Off = "O";
            internal static string Red = "R";
        }
    }
}