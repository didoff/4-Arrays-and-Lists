using System;

namespace ArrayReversing
{
    class ArrayReversing
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] arr = input.Split(' ');
            int length = arr.Length;

            string[] reversedArr = new string[arr.Length];

            for (int i = 0; i < length; i++)
            {
                reversedArr[i] = arr[length - i - 1];
            }

            Console.WriteLine(string.Join(" ", reversedArr));

        }
    }
}
