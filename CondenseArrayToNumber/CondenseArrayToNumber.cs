using System;

namespace CondenseArrayToNumber
{
    class CondenseArrayToNumber
    {
        static void Main(string[] args)
        {
            string[] strArr = Console.ReadLine().Split(' ');
            int[] nums = Array.ConvertAll(strArr, int.Parse);

            int[] condensed = new int[nums.Length - 1];

            for (int i = 0; i < nums.Length; i++)
            {
                condensed[i] = nums[i] + nums[i - 1];
            }

            // TO DO...
        }
    }
}
