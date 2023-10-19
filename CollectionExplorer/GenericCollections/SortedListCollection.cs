

namespace CollectionExplorer.GenericCollections
{
    public class SortedListCollection<TKey, TValue>
    {
        private SortedList<TKey, TValue> data;

        public SortedListCollection()
        {
            data = new SortedList<TKey, TValue>();
        }

        public void AddItem(TKey key, TValue value)
        {
            data.Add(key, value);
        }

        public bool RemoveItem(TKey key)
        {
            if (data.ContainsKey(key))
            {
                data.Remove(key);
                return true;
            }
            return false;
        }

        public bool ContainsKey(TKey key)
        {
            return data.ContainsKey(key);
        }

        public bool ContainsValue(TValue value)
        {
            return data.ContainsValue(value);
        }

        public void DisplayItems()
        {
            Console.WriteLine("Sorted List Items (Key-Value Pairs):");
            foreach (var kvp in data)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }

        public int GetItemCount()
        {
            return data.Count;
        }
    }
}
