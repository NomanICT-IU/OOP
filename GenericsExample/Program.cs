namespace GenericsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var initializer = new CollectionInitializer<int>();
            initializer.AddElementToCollection(1, 2, 3, 4, 5);
            List<int> collection = initializer.RetriveCollection();
            int retriveNumber = initializer.RetriveElementOnIndex(2);

            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Retive Eelement on index {retriveNumber}");
        }
    }
}
