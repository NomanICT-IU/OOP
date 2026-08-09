namespace Delegate
{
    public delegate void WriterDeletaget(string text);
    public class Program
    {

        static void Main(string[] args)
        {
            var writerDeletaget = new WriterDeletaget(Writer.Write);
            writerDeletaget("Hello, World!");
            //Console.WriteLine("Hello, World!");
        }
    }
}
