

namespace CollectionExplorer.GenericCollections
{
    public class QueueCollection<T>
    {
        private Queue<T> data;

        public QueueCollection()
        {
            data = new Queue<T>();
        }

        public void EnqueueItem(T item)
        {
            data.Enqueue(item);
        }

        public T DequeueItem()
        {
            if (data.Count > 0)
            {
                return data.Dequeue();
            }
            else
            {
                Console.WriteLine("Queue is empty. Cannot dequeue an item.");
                return default;
            }
        }

        public bool ContainsItem(T item)
        {
            return data.Contains(item);
        }

        public void DisplayItems()
        {
            Console.WriteLine("Queue Items (Front to Back):");
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
