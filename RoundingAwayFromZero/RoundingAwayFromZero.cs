using System;

namespace RoundingAwayFromZero
{
    class RoundingAwayFromZero
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] toStringArr = input.Split(' ');

            double[] toDoubleArray = Array.ConvertAll(toStringArr, double.Parse);

            for (int i = 0; i < toDoubleArray.Length; i++)
            {
                Console.WriteLine($"{toDoubleArray[i]} => {Math.Round(toDoubleArray[i], MidpointRounding.AwayFromZero)}");
            }
            
        }
    }
}
