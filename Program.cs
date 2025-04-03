// 1. WAP to find Second largest element in an array : arr[] = [12, 35, 1, 10, 34, 1, 35], without
// sorting, without using any built-in methods and without deleting duplicate elements. What will be
// the time complexity?
using System;
namespace logicals
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] array = { 12, 35, 1, 10, 34, 1, 35 };
            int large = 0;
            int secLarge = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > large)
                {
                    secLarge = large;
                    large = array[i];
                }
                if (array[i] < large && array[i] > secLarge)
                {
                    secLarge = array[i];
                }
            }
            Console.WriteLine(secLarge);
        }
    }
}