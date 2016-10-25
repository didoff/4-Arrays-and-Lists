using System;

namespace LastKNumbersSumSequence
{
    class LastKNumbersSumSequence
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long[] sequence = new long[n];

            sequence[0] = 1;

            for (int i = 1; i < sequence.Length; i++)
            {
                long sum = 0;
                int count = k;

                for (int j = i - 1; j >= 0; j--)
                {
                    if (count == 0)
                    {
                        break;
                    }

                    sum += sequence[j];
                    count--;
                }


                sequence[i] = sum;
            }

            Console.WriteLine(string.Join(" ", sequence));
        }
    }
}
