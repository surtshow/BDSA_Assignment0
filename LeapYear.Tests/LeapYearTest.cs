using System;
using Xunit;

namespace LeapYear.Tests
{
    public class LeapYearTest
    {
        [Fact]
        public void divisible_by_4_is_leap_year()
        {
            var lyFunc = new LeapYearFunc();

            bool actual = lyFunc.IsLeapYear(2004);

            Assert.True(actual);
        }

        [Fact]
        public void not_divisible_by_4_is_not_leap_year()
        {
            var lyFunc = new LeapYearFunc();

            bool actual = lyFunc.IsLeapYear(2007);

            Assert.False(actual);
        }

        [Fact]
        public void divisible_by_100_is_not_leap_year()
        {
            var lyFunc = new LeapYearFunc();

            bool actual = lyFunc.IsLeapYear(2100);

            Assert.False(actual);
        }

        [Fact]
        public void divisible_by_400_is_leap_year()
        {
            var lyFunc = new LeapYearFunc();

            bool actual = lyFunc.IsLeapYear(2400);

            Assert.True(actual);
        }
    }
}
