using System;

namespace lecture01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("write a year and hit [ENTER] >");
            if (int.TryParse(Console.ReadLine(), out int input))
            {
                if (input >= 1582)
                {
                    Console.WriteLine(IsLeapYear(input)? "yay" : "nay");
                }
                else
                {
                    Console.WriteLine("Choose a number after 1581");
                }
            }
            else
            {
                Console.WriteLine("Not an int");
            }
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
