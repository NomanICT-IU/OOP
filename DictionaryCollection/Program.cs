namespace DictionaryCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<string, int>();
            dictionary.Add("First", 174);
            dictionary.Add("Second", 175);
            dictionary.Add("Third", 176);
            dictionary.Add("Fourth", 177);

            foreach (var key in dictionary.Keys)
            {
                Console.WriteLine($"Key: {key}, value: {dictionary[key]}");
            }
        }
    }
}
