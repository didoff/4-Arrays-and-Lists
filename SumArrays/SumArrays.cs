using System;

namespace SumArrays
{
    class SumArrays
    {
        static void Main(string[] args)
        {
            string[] strArr1 = Console.ReadLine().Split(' ');
            string[] strArr2 = Console.ReadLine().Split(' ');

            int[] arr1 = Array.ConvertAll(strArr1, int.Parse);
            int[] arr2 = Array.ConvertAll(strArr2, int.Parse);

            int[] sum = new int[Math.Max(arr1.Length, arr2.Length)];

            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] = arr1[i % arr1.Length] + arr2[i % arr2.Length];
                Console.Write(sum[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
