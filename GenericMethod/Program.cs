namespace GenericMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator<double>();
            double result = calculator.Add(2, 3);
            Console.WriteLine(result);
        }
    }
}
