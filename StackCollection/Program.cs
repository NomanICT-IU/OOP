using System.Collections;

namespace StackCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();

            stack.Push(324);
            stack.Push("Noman");
            stack.Push(true);

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
