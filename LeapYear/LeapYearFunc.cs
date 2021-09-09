using System;

namespace LeapYear
{
    public class LeapYearFunc
    {
        static int input;

        public static void Main(string[] args) {
            var lyf = new LeapYearFunc();
            bool isNotValidInput = true;
            while(isNotValidInput) {
                try {
                    input = Convert.ToInt32(Console.ReadLine());
                    if (input <= 1582) {throw new Exception();}
                    isNotValidInput = false;
                }
                catch (Exception e) {
                    Console.WriteLine("Invalid input, try again!");
                }
            }
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
