using System;
using System.Linq;

namespace BerlinClock
{
    public class TimeConverter : ITimeConverter
    {
        public string convertTime(string aTime)
        {
            var timeParts = aTime.Split(':').Select(int.Parse).ToArray();
            var seconds = GetSeconds(timeParts[2]);
            var topRowHours = GetTopRowHours(timeParts[0]);
            var bottomRowHours = GetBottomRowHours(timeParts[0]);
            var topRowMinutes = GetTopRowMinutes(timeParts[1]);
            var bottomRowMinutes = GetBottomRowMinutes(timeParts[1]);
            return String.Join(" ", seconds, topRowHours, bottomRowHours, topRowMinutes, bottomRowMinutes);
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

        internal static class LampLightState
        {
            internal static string Yellow = "Y";
            internal static string Off = "O";
            internal static string Red = "R";
        }
    }
}