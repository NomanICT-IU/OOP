namespace ActionDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<int, int> actionDelegate = Calculator.Sum;
            actionDelegate(10, 12);

        }
    }
}
