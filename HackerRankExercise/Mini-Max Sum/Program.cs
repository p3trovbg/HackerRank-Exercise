using System;
using System.Linq;

namespace Mini_Max_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
           var array = Console.ReadLine().Split().Select(long.Parse).ToArray();
           
            var secondSum = array.Where(x => x != array.Min()).Sum();
            var firstSum = array.Where(x => x != array.Max()).Sum();
            if (firstSum == 0 && secondSum == 0)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    firstSum += array[i];
                    secondSum += array[i];
                }
            }
            Console.WriteLine($"{firstSum} {secondSum}");
        }
    }
}
