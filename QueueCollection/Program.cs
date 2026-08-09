using System.Collections;

namespace QueueCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue();

            queue.Enqueue(53);
            queue.Enqueue(50);
            queue.Enqueue("Noman");

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }
    }
}
