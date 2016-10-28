using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitByWordCasing
{
    class SplitByWordCasing
    {
        static void Main(string[] args)
        {
            // EDNO MALKO MAZALO bace

            List<string> input = Console.ReadLine().Split(' ', ',', '.', ';', ':', '!', '(', ')', '"', '\'', '\\', '/', '[', ']').ToList();

            List<string> upperCaseWords = new List<string>();
            List<string> lowerCaseWords = new List<string>();
            List<string> mixedCaseWords = new List<string>();


            for (int i = 0; i < input.Count; i++)
            {
                bool isUpper = true;
                bool isLower = true;
                char[] charray = input[i].ToCharArray();
                for (int j = 0; j < charray.Length; j++)
                {
                    if (char.IsLower(charray[j]))
                    {
                        isUpper = false;

                        lowerCaseWords.Add(input[i]);
                    }
                    else if (char.IsUpper(charray[j]))
                    {
                        b++;
                        if (b == charray.Length)
                        {
                            upperCaseWords.Add(input[i]);
                        }
                    }
                    else
                    {
                        mixedCaseWords.Add(input[i]);
                    }


                }
            }

            Console.Write("Lower-case: ");
            Console.WriteLine(string.Join(", ", lowerCaseWords));
            Console.Write("Mixed-case: ");
            Console.WriteLine(string.Join(", ", mixedCaseWords));
            Console.Write("Upper-case: ");
            Console.WriteLine(string.Join(", ", upperCaseWords));


        }
    }
}
