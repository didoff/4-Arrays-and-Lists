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

            //for (int i = 0; i < input.Length; i++)
            //{
            //    List<string> temp = new List<string> { input[i] };

            //}

            for (int i = 0; i < input.Length; i++)
            {
                string[] tokens = input[i].Split(' ' );
                for (int j = 0; j < tokens.Length; j++)
                {
                    if (tokens[j] != "")
                    {
                        results.Add(tokens[j]);
                        //results.Remove(tokens[j]);
                    }
                    
                }
                
            }

            results.Reverse();

            Console.WriteLine(string.Join(" ", results));
        }
    }
}
