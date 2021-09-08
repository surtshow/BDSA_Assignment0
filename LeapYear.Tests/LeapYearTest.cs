using System;
using System.IO;
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

        [Fact]
        public void is_yay_with_leap_year_input() {
            var writer = new StringWriter();
            Console.SetIn(new StringReader("2004"));
            Console.SetOut(writer);

            LeapYearFunc.Main(new string[0]);

            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("yay", output);
        }

        [Fact]
        public void is_nay_with_non_leap_year_input() {
            var writer = new StringWriter();
            Console.SetIn(new StringReader("2005"));
            Console.SetOut(writer);

            LeapYearFunc.Main(new string[0]);

            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("nay", output);
        }
    }
}
