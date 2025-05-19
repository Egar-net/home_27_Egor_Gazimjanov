namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mas = {1, 4 ,9 ,0};

            ArraySort<int> sort = new ArraySort<int>();
            Console.WriteLine(string.Join(", ", mas));
            sort.SortArray(mas);
            sort.ChangeOrder(mas);
        }
    }
}
