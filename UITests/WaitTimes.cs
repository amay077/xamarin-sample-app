using System;
using Xamarin.UITest.Utils;

namespace XamarinSampleApp.UITests
{
    // Android emulators are slow, give some time for test.
    public class WaitTimes : IWaitTimes
    {
        public TimeSpan GestureWaitTimeout
        {
            get { return TimeSpan.FromMinutes(5); }
        }
        public TimeSpan WaitForTimeout
        {
            get { return TimeSpan.FromMinutes(5); }
        }
    }
}

