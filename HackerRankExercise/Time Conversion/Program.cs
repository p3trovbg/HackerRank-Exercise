using System;

using System.Linq;

namespace Time_Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var time = Console.ReadLine().Split(new string[] {":", "PM"}, StringSplitOptions.RemoveEmptyEntries);
            int x = int.Parse(time[0]);
            if (x == 12)
            {
                x = 0;
            }
            else
            {
                x += 12;
            }
            Console.WriteLine($"{x}:{time[1]}:{time[2]}");
              
        }
    }
}
