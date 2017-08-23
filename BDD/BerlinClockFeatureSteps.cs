using System;
using TechTalk.SpecFlow;
using System.Linq;
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

        [Then(@"the clock should look like")]
        public void ThenTheClockShouldLookLike(string theExpectedBerlinClockOutput)
        {
            Assert.That(_berlinClock.convertTime(_inputTime), Is.EqualTo(theExpectedBerlinClockOutput));
        }

        [Then(@"the user should see an error message ""(.*)""")]
        public void ThenTheUserShouldSeeAnError(string errorMessage)
        {
            var exception = Assert.Throws<BerlinClockInputTimeFormatException>(() => _berlinClock.convertTime(_inputTime));
            Assert.That(exception.Message, Is.EqualTo(errorMessage));
        }
    }
}
