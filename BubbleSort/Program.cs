using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class BubbleSort
    {
        public static void SortNumber()
        {
            int[] arr = new int[] {2,3,1,7,9,8,4,5};
            string sortedStr=String.Empty;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    int temp = 0;
                    if (arr[j] > arr[j + 1])
                    { 
                        temp=arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                    }
                }
            }

            foreach (var v in arr)
            {
                Console.Write(v.ToString() + ",");
            }

        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Input string");
            //string myStr=Console.ReadLine();
            SortNumber();
            Console.ReadLine();
        }
    }
}
