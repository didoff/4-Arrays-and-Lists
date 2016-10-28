using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAdjacentEqualNumbers
{
    class SumAdjacentEqualNumbers
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            List<double> nums = new List<double>();

            for (int i = 0; i < input.Length; i++)
            {
                nums.Add(double.Parse(input[i]));
            }

            for (int i = 0; i < nums.Count - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    nums[i] = nums[i] + nums[i + 1];
                    nums.RemoveAt(i + 1);
                    i = -1;
                }
            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
