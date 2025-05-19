using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ArraySort<T>
    {

        public void SortArray<T>(T[] arr)
        {
            Console.WriteLine("Сортировка массива");
            Array.Sort(arr);
            Console.WriteLine(string.Join(", ", arr));
        }

        public void ChangeOrder<T>(T[] arr) 
        {
            Console.WriteLine("Изменения порядка на обратный");
            Array.Reverse(arr);
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
