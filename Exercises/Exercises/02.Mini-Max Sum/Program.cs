class Result
{
    public static void miniMaxSum(List<int> arr)
    {
        arr = arr.OrderBy(x => x).ToList();
        long maxSum = 0;
        long minSum = 0;

        for (int i = 0; i < arr.Count - 1; i++)
        {
            maxSum = maxSum + arr[i + 1];
            minSum = minSum + arr[arr.Count - i - 2];
        }

        Console.WriteLine($"{minSum} {maxSum}");
    }
}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}
