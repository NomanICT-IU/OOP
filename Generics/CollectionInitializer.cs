namespace Generics
{
    public class CollectionInitializer<T>
    {
        private T[] collection;

        public CollectionInitializer(int collectionLength)
        {
            collection = new T[collectionLength];
        }
        public void AddElementsToCollection(params T[] elements)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                collection[i] = elements[i];
            }
        }
        public T[] RetriveAllElements()
        {
            return collection;
        }

        public T RetriveElementOnIndex(int index)
        {
            return collection[index];
        }
    }
}
