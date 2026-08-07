using InheritanceWithNewKeyWord;

internal class Program
{
    private static void Main(string[] args)
    {
        var writer = new Writer("update.txt");
        var jsonWtrier = new JSONWriter("report.txt");


        var result1 = jsonWtrier.GetDetails();
        Console.WriteLine(result1);

        var result = writer.GetDetails();
        Console.WriteLine(result);
        Console.ReadKey();
    }
}