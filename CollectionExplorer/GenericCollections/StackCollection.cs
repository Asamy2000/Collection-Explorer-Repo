

namespace CollectionExplorer.GenericCollections
{
    public class StackCollection<T>
    {
        private Stack<T> data;

        public StackCollection()
        {
            data = new Stack<T>();
        }

      
        public void PushItem(T item)
        {
            data.Push(item);
        }

       
        public T PopItem()
        {
            if (data.Count > 0)
            {
                return data.Pop();
            }
            else
            {
                Console.WriteLine("Stack is empty. Cannot pop an item.");
                return default(T);
            }
        }

        public bool ContainsItem(T item)
        {
            return data.Contains(item);
        }

        public void DisplayItems()
        {
            Console.WriteLine("Stack Items (Top to Bottom):");
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
