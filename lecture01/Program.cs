using System;

namespace lecture01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("write a year and hit [ENTER] >");
            int.TryParse(Console.ReadLine(), out int input);
            Console.WriteLine(IsLeapYear(input)? "yay" : "nay");
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
