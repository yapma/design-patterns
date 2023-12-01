namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyCollection myCollection1 = new MyCollection(new QuickSort());
            myCollection1.Sort();

            MyCollection myCollection2 = new MyCollection(new InsertionSort());
            myCollection2.Sort();

            MyCollection myCollection3 = new MyCollection(new MergeSort());
            myCollection3.Sort();
        }
    }
}