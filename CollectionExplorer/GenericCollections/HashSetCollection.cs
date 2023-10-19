

namespace CollectionExplorer.GenericCollections
{
    public class HashSetCollection<T>
    {
        private HashSet<T> data;

        public HashSetCollection()
        {
            data = new HashSet<T>();
        }

        public void AddItem(T item)
        {
            data.Add(item);
        }

        public bool RemoveItem(T item)
        {
            return data.Remove(item);
        }

        public bool ContainsItem(T item)
        {
            return data.Contains(item);
        }

        public void DisplayItems()
        {
            Console.WriteLine("Unique Items in HashSet:");
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }

        public int GetItemCount()
        {
            return data.Count;
        }
    }
}
