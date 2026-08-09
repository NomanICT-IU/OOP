namespace GenericsExample
{
    public class CollectionInitializer<T>
    {
        private T[] collection;
        public CollectionInitializer(int collectionLength)
        {
            collection = new T[collectionLength];
        }

        public void AddElementToCollection(params T[] elemets)
        {
            for (int i = 0; i < elemets.Length; i++)
            {
                collection[i] = elemets[i];
            }
        }

        public T[] RetriveCollection()
        {
            return collection;
        }

        public T RetriveElementOnIndex(int index)
        {
            return collection[index];
        }
    }
}
