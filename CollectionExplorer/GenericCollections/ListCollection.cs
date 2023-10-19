namespace CollectionExplorer.GenericCollections
{
    public class ListCollection<T>
    {
        private List<T> data;

        public ListCollection()
        {
            data = new List<T>();
        }

        public void AddItem(T item)
        {
            data.Add(item);
        }

        public void RemoveItem(T item)
        {
            if (data.Contains(item))
            {
                data.Remove(item);
            }
            else
            {
                Console.WriteLine("Item not found in the list.");
            }
        }

        public bool ContainsItem(T item)
        {
            return data.Contains(item);
        }

        public void DisplayItems()
        {
            Console.WriteLine("List Items:");
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
