using CollectionExplorer.GenericCollections;

namespace CollectionExplorer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "hello";
            string str2 = "hello";
            //bool areEqualReference = (str1 == str2);
            Console.WriteLine(str1.GetHashCode());
            Console.WriteLine(str2.GetHashCode());
            //Console.WriteLine(areEqualReference);

        }
    }
}
