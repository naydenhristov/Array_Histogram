using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1_4_Array_Histogram
{
    public class Array_Histogram
    {
        public static void Main()
        {
            Dictionary<string, int> words = new Dictionary<string, int>();

            List<string> inputList = Console.ReadLine()
                .Split(' ')
                .ToList();

            int sum = 0;

            foreach (string item in inputList)
            {
                if (words.ContainsKey(item))
                {
                    words[item]++;
                    sum++;
                }
                else
                {
                    words.Add(item, 1);
                    sum++;
                }
            }

            var items = from pair in words
                        orderby pair.Value descending
                        select pair;

            foreach (KeyValuePair<string, int> pair in items)
            {
                double percent = (double)pair.Value / sum * 100;
                Console.WriteLine("{0} -> {1} times ({2:F2}%)", pair.Key, pair.Value, percent);
            }
        }
    }
}
