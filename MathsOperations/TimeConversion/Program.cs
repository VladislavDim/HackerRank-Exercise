class Result
{

    public static string timeConversion(string s)
    {
        DateTime dateTime = DateTime.ParseExact(s, "h:mm:sstt", null);

        return dateTime.ToString("HH:mm:ss");
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        
        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        Console.WriteLine(result);


    }
}
