/*
 Excellent Reference
 https://dotnettutorials.net/lesson/generic-sorteddictionary-collection-class-in-csharp/
 */
namespace CollectionExplorer.GenericCollections
{
    public class SortedDictionaryCollection<TKey, TValue>
    {
        private SortedDictionary<TKey, TValue> data;

        public SortedDictionaryCollection()
        {
            data = new SortedDictionary<TKey, TValue>();
        }

        public void AddItem(TKey key, TValue value)
        {
            data[key] = value;
        }

        public bool RemoveItem(TKey key)
        {
            return data.Remove(key);
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
            Console.WriteLine("Sorted Dictionary Items (Key-Value Pairs):");
            foreach (var kvp in data)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }

        public int GetItemCount()
        {
            return data.Count;
        }

    
        public TKey GetMinKey()
        {
            if (data.Count > 0)
            {
                return data.Keys.Min();
            }
            else
            {
                Console.WriteLine("Sorted Dictionary is empty.");
                return default(TKey);
            }
        }

        public TKey GetMaxKey()
        {
            if (data.Count > 0)
            {
                return data.Keys.Max();
            }
            else
            {
                Console.WriteLine("Sorted Dictionary is empty.");
                return default(TKey);
            }
        }
    }

}
