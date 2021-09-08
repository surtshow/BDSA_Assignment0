using System;

namespace LeapYear
{
    public class LeapYearFunc
    {
        public static void Main(string[] args) {
            var lyf = new LeapYearFunc();
            int input = Convert.ToInt32(Console.ReadLine());
            if (lyf.IsLeapYear(input)) {Console.WriteLine("yay");}
            else {Console.WriteLine("nay");}
        }

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
