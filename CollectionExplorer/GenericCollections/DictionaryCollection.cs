using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionExplorer.GenericCollections
{
    public class DictionaryCollection<TKey, TValue>
    {
        private Dictionary<TKey, TValue> data;

        public DictionaryCollection()
        {
            data = new Dictionary<TKey, TValue>();
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
            Console.WriteLine("Dictionary Items (Key-Value Pairs):");
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
