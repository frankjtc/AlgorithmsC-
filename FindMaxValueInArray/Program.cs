using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxValueInArray
{
    class FindMaxVal
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[] { 1,34,56,233,7,666,23};
            int maxVal = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (maxVal < myArray[i])
                {
                    maxVal = myArray[i];
                }
            }

            Console.WriteLine(maxVal.ToString());
            Console.ReadLine();
        }
    }
}
