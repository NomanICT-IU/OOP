namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var initializer = new CollectionInitializer<int>(5);
            initializer.AddElementsToCollection(1, 2, 3, 4, 5);
            int[] arrayCollection = initializer.RetriveAllElements();

            int number = initializer.RetriveElementOnIndex(3);

            Console.WriteLine(number);
        }

    }
}
