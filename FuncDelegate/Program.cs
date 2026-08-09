namespace FuncDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> sumDelegate = Calculator.Sum;
            Console.WriteLine(sumDelegate(10, 20));
        }
    }
}
