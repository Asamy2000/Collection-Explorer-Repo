using System.Collections;

namespace CollectionExplorer.nonGenericCollections
{
    public class ArrayListCollection
    {
        private ArrayList data;

        public ArrayListCollection()
        {
            data = new ArrayList();
        }

        public void AddItem(object item)
        {
            data.Add(item);
        }

        public void RemoveItem(object item)
        {
             data.Remove(item);
        }

        public bool ContainsItem(object item)
        {
            return data.Contains(item);
        }

        public void DisplayItems()
        {
            Console.WriteLine("ArrayList Items:");
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }

        public int GetItemCount()
        {
            return data.Count;
        }

        public void Clear()
        {
            data.Clear();
        }

        public void InsertItem(int index, object item)
        {
            data.Insert(index, item);
        }

        public object GetItem(int index)
        {
            if (index >= 0 && index < data.Count)
            {
                return data[index];
            }
            else
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }
        }

        public void Sort()
        {
            data.Sort();
        }

        public void RemoveAt(int index)
        {
            if (index >= 0 && index < data.Count)
            {
                data.RemoveAt(index);
            }
            else
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }
        }

        public void RemoveRange(int index, int count)
        {
            if (index >= 0 && index + count <= data.Count)
            {
                data.RemoveRange(index, count);
            }
            else
            {
                throw new IndexOutOfRangeException("Invalid index or count for RemoveRange.");
            }
        }

        public void InsertRange(int index, ICollection collection)
        {
            if (index >= 0 && index <= data.Count)
            {
                data.InsertRange(index, collection);
            }
            else
            {
                throw new IndexOutOfRangeException("Invalid index for InsertRange.");
            }
        }
    }

}


