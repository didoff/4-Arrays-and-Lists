using System;

namespace TakeMiddleElements
{
    class TakeMiddleElements
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ');

            if (array.Length == 1)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine($"{ array[0] }");
                }
            }
            else if(array.Length % 2 == 0)
            {
                    Console.WriteLine("{{ {0}, {1} }}", array[(array.Length)/2 - 1], array[(array.Length)/2]);
            }
            else if (array.Length % 2 != 0)
            {
                Console.WriteLine("{{ {0}, {1}, {2} }}", array[(array.Length) / 2 - 1], array[(array.Length) / 2], array[(array.Length) / 2 + 1]);
            }
        }
    }
}
