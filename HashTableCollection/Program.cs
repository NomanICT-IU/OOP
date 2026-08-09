using System.Collections;

namespace HashTableCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hashTable = new Hashtable();
            hashTable.Add("First", 174);
            hashTable.Add("Second", "Sixty");
            hashTable.Add("Third", 124.24);
            foreach (var key in hashTable.Keys)
            {
                Console.WriteLine($"Key: {key}, value: {hashTable[key]}");
            }
        }
    }
}
