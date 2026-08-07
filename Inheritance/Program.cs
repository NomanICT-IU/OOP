

using Inheritance;

internal class Program
{
    private static void Main(string[] args)
    {
        var jsonWriter = new JSONWriter();

        jsonWriter.Write();
        jsonWriter.JSONWrite();
        jsonWriter.XMLWrite();
    }
}