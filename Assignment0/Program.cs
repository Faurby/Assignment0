using System;

namespace Assignment0
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                var input = Int32.Parse(Console.ReadLine());
                if (input > 1581)
                {
                    if (isLeapYear(input))
                    {
                        Console.WriteLine("yay");
                    }
                    else
                    {
                        Console.WriteLine("nay");
                    }
                }
                else
                {
                    Console.WriteLine("Must be above 1581");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please write a number");
            }

        }

        public static bool isLeapYear(int year)
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        return true;

                    }
                    return false;
                }
                return true;
            }
            return false;
        }
    }
}
