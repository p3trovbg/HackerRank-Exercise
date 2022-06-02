using System;

namespace Grading_Students
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var grades = new int[n];
            for (int i = 0; i < n; i++)
            {
                var digit = int.Parse(Console.ReadLine());
                if(digit < 38)
                {
                    grades[i] = digit;
                }
                else
                {
                    var originalDigit = digit;
                    while (digit % 5 != 0)
                    {
                        digit++;
                    }

                    int difference = digit - originalDigit;
                    
                    if(difference < 3)
                    {
                        grades[i] = digit;
                    } 
                    else
                    {
                        grades[i] = originalDigit;
                    }
                }
            }

            PrintGrades(grades);
        }

        private static void PrintGrades(int[] grades)
        {
            foreach (var grade in grades)
            {
                Console.WriteLine(grade);
            }
        }
    }
}
