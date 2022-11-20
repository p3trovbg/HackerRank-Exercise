using System.Runtime.CompilerServices;

class Result
{
    public static string TimeConversion(string s)
    {
        var meridiem = s.Substring(s.Length - 2, 2);
        var time = s.Substring(0, s.Length - 2);
        var hourAsString = s.Substring(0, 2);
        var hour = int.Parse(hourAsString);

        if (meridiem == "PM" && hour >= 12)
        {
            return time;
        }
        else if(meridiem == "AM" && hour >= 12)
        {
            hour -= 12;

            if(hour < 10)
            {
            var original = hourAsString;
            hourAsString = "0" + hour.ToString();
            time = time.Replace(original, hourAsString);
            }
            else
            {
                time = time.Replace(hourAsString, hour.ToString());
            }

            return time;
        }
        else
        {
            hour += 12;
            time = time.Replace(hourAsString, hour.ToString());
            return time;
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string s = Console.ReadLine();

        string result = Result.TimeConversion(s);

        Console.WriteLine(result);
    }
}