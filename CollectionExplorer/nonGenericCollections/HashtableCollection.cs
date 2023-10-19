using System.Collections;
namespace CollectionExplorer.nonGenericCollections
{
    public class HashtableCollection
    {
        private Hashtable data;

        public HashtableCollection()
        {
            data = new Hashtable();
        }

        public void AddItem(object key, object value)
        {
            data[key] = value;
        }

        public bool RemoveItem(object key)
        {
            if (ContainsItem(key))
            {
                data.Remove(key);
                return true;
            }
            return false;
        }

        public bool ContainsItem(object key)
        {
            return data.ContainsKey(key);
        }

        public void DisplayItems()
        {
            Console.WriteLine("Hashtable Items (Key-Value Pairs):");
            foreach (DictionaryEntry entry in data)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
        }

        public int GetItemCount()
        {
            return data.Count;
        }
    }

}
