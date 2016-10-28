using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendList
{
    class AppendList
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('|').ToArray();

            List<string> results = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                string[] temp = input[i].Split(' ');
                for (int j = temp.Length - 1; j >= 0; j--)
                {
                        results.Add(temp[j]);

                    if (temp[j] == "")
                    {
                        results.Remove(temp[j]);
                    }
                }
            }

            results.Reverse();

            Console.WriteLine(string.Join(" ", results));
            
        }
    }
}
