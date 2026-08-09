namespace GenericsExample
{
    public class CollectionInitializer<T>
    {
        private List<T> collection;
        public CollectionInitializer()
        {
            collection = new List<T>();
        }

        public void AddElementToCollection(params T[] elemets)
        {
            for (int i = 0; i < elemets.Length; i++)
            {
                collection.Add(elemets[i]);
            }
        }

        public List<T> RetriveCollection()
        {
            return collection;
        }

        public T RetriveElementOnIndex(int index)
        {
            return collection[index];
        }
    }
}
