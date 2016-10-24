using System;

namespace DayOfWeek
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            string[] weekdays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            int input = int.Parse(Console.ReadLine());

            if (input > 0 && input <= 7)
            {
                Console.WriteLine(weekdays[input - 1]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}
