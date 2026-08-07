using Structures;

internal class Program
{
    private static void Main(string[] args)
    {
        Time time = new Time(3, 30, 2);

       string result = time.GetTime();
        Console.WriteLine(result);
    }
}