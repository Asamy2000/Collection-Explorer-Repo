namespace CollectionExplorer.GenericCollections
{
    public class LinkedListCollection<T>
    {
        private LinkedListNode<T> head;
        private int count;

        public LinkedListCollection()
        {
            head = null;
            count = 0;
        }

        public void AddItem(T item)
        {
            LinkedListNode<T> newNode = new LinkedListNode<T>(item);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                LinkedListNode<T> current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
            count++;
        }

        public bool RemoveItem(T item)
        {
            if (head == null)
            {
                return false;
            }

            if (head.Value.Equals(item))
            {
                head = head.Next;
                count--;
                return true;
            }

            LinkedListNode<T> current = head;
            while (current.Next != null)
            {
                if (current.Next.Value.Equals(item))
                {
                    current.Next = current.Next.Next;
                    count--;
                    return true;
                }
                current = current.Next;
            }

            return false;
        }

        public bool ContainsItem(T item)
        {
            LinkedListNode<T> current = head;
            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public void DisplayItems()
        {
            LinkedListNode<T> current = head;
            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }
        }

        public int GetItemCount()
        {
            return count;
        }
    }

    public class LinkedListNode<T>
    {
        public T Value { get; }
        public LinkedListNode<T> Next { get; set; }

        public LinkedListNode(T value)
        {
            Value = value;
            Next = null;
        }
    }

}
