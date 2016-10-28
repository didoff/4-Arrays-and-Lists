using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveNegativesAndReverse
{
    class RemoveNegativesAndReverse
    {
        static void Main(string[] args)
        {
            // Lists
            string[] input = Console.ReadLine().Split(' ');

            List < int > nums = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (int.Parse(input[i])*-1 < 0)
                {
                    nums.Add(int.Parse(input[i]));
                }
            }

            if (!nums.Any())
            {
                Console.WriteLine("empty");
            }
            else
            {
                nums.Reverse();

                Console.WriteLine(string.Join(" ", nums));

            }

        }
    }
}
