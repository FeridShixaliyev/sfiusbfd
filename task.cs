using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr={ 1,3,4,12,14,18,43,32,25};
            int i = 0;
            int total = 0;
            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 3 == 0)
                {
                    total += arr[i];
                }

            }
            Console.WriteLine(total);
        }
    }
}
