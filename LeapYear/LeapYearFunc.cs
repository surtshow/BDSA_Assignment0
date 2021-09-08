using System;

namespace LeapYear
{
    public class LeapYearFunc
    {
        public static void Main(string[] args) {}

        public bool IsLeapYear(int year) {
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0) {
                return true;
            }
            else {
                return false;
            }
        }

    }
}
