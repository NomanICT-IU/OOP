namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var jsonWriter = new JSONWriter("test.txt");
            var fileName = jsonWriter.FileName;

            jsonWriter.WriteFile(fileName);

            Console.ReadKey();
        }
    }
}
