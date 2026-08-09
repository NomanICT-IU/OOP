namespace GenericsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var initializer = new CollectionInitializer<int>(5);
            initializer.AddElementToCollection(1, 2, 3, 4, 5);
            int[] collection = initializer.RetriveCollection();
            int retriveNumber = initializer.RetriveElementOnIndex(2);

            for (int i = 0; i < collection.Length; i++)
            {
                Console.WriteLine(collection[i]);
            }

            Console.WriteLine($"Retive Eelement on index {retriveNumber}");
        }
    }
}
