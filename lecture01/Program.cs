using System;

namespace lecture01
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static bool IsLeapYear(int year) 
        {
            if (year % 400 == 0) {
                return true;
            }
            if (year % 100 == 0) {
                return false;
            }
            if (year % 4 == 0) {
                return true;
            } else {
                return false;
            }
        }
    }
}
