using System;
using System.Collections.Generic;
using System.Linq;

namespace Birthday_Cake_Candles
{
     class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            var candles = new Dictionary<int, int>();
            foreach (var digit in list)
            {
                if (!candles.ContainsKey(digit))
                {
                    candles.Add(digit, 0);
                }
                candles[digit]++;
            }
            Console.WriteLine(candles.OrderByDescending(x => x.Value).FirstOrDefault().Value);
        }
    }
}
