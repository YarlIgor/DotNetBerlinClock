using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace BerlinClock
{
    [Binding]
    public class TheBerlinClockSteps
    {
        private ITimeConverter _berlinClock = new TimeConverter();
        private String _inputTime;

        
        [When(@"the time is ""(.*)""")]
        public void WhenTheTimeIs(string time)
        {
            _inputTime = time;
        }
        
        [Then(@"the clock should look like ""(.*)""")]
        public void ThenTheClockShouldLookLike(string theExpectedBerlinClockOutput)
        {
            Assert.That(_berlinClock.convertTime(_inputTime), Is.EqualTo(theExpectedBerlinClockOutput));
        }
    }
}
