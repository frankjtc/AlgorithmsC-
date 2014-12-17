using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestNumbersSum
{
    class Program
    {
        public static void Sum()
        {
            int[] arr = { 1, 8, 4, 5, 12, 2, 5, 6, 7, 1, 90, 100, 56, 88, 34 };

            int temp;
            int a = arr[0];
            int b = arr[0];
            int c = arr[0];

            foreach (int v in arr)
            {
                if (v>a)
                {
                    temp = a;
                    a = v;
                   b = temp;
                }

                if (v>b && v<a)
                {
                    temp = b;
                    b = v;
                    c = temp;
                }

                if (v > c && v < b)
                {
                    c = v;
                }
            }

            Console.WriteLine("a:" + a + "b:" + b + "c:" + c);
        }
        static void Main(string[] args)
        {
            Sum();
            Console.ReadKey();
        }
    }
}
