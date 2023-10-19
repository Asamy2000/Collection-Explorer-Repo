namespace CollectionExplorer.GenericCollections
{
    /*
     
  -->What is Generic SortedSet<T> Collection in C#?
     The Generic SortedSet<T> Collection Class in C# is used to store, remove or view elements.
     SortedSet Collection store the elements in sorted order. That means it stores the element in ascending order and also, 
     and it does not store duplicate elements. 
     So, it is recommended to use the SortedSet collection if you want to store only unique elements in ascending order. 
     This collection is of the generic type collection and hence it belongs to System.Collections.Generic namespace.

    It also provides many mathematical set operations, such as intersection, union, and difference. 
    It is a dynamic collection means the size of the SortedSet is automatically increased when new elements are added.
     
     
     */
    public class SortedSetCollection<T>
    {
        private SortedSet<T> data;

        public SortedSetCollection()
        {
            data = new SortedSet<T>();
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

        public T GetMinItem()
        {
            if (data.Count > 0)
            {
                return data.Min();
            }
            else
            {
                Console.WriteLine("SortedSet is empty.");
                return default(T);
            }
        }

        public T GetMaxItem()
        {
            if (data.Count > 0)
            {
                return data.Max;
            }
            else
            {
                Console.WriteLine("SortedSet is empty.");
                return default(T);
            }
        }

        public void DisplayItems()
        {
            Console.WriteLine("Sorted Set Items (Sorted Order):");
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }

        public int GetItemCount()
        {
            return data.Count;
        }

        public SortedSet<T> GetIntersection(SortedSetCollection<T> otherCollection)
        {
            var intersection = new SortedSet<T>(data);
            intersection.IntersectWith(otherCollection.data);
            return intersection;
        }

        public SortedSet<T> GetUnion(SortedSetCollection<T> otherCollection)
        {
            var union = new SortedSet<T>(data);
            union.UnionWith(otherCollection.data);
            return union;
        }

        public SortedSet<T> GetDifference(SortedSetCollection<T> otherCollection)
        {
            var difference = new SortedSet<T>(data);
            difference.ExceptWith(otherCollection.data);
            return difference;
        }
    }

}
