class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        var negativeDigits = new List<int>();
        var positiveDigits = new List<int>();
        var zeros = new List<int>();

        for (int i = 0; i < arr.Count; i++)
        {
            var digit = arr[i];
            if (digit > 0)
            {
                positiveDigits.Add(digit);
            }
            else if (digit < 0)
            {
                negativeDigits.Add(digit);
            }
            else
            {
                zeros.Add(digit);
            }
        }

        int size = arr.Count;
        Console.WriteLine($"{(decimal)positiveDigits.Count / size:f6}");
        Console.WriteLine($"{(decimal)negativeDigits.Count / size:f6}");
        Console.WriteLine($"{(decimal)zeros.Count / size:f6}");
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}