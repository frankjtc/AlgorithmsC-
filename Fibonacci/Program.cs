using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class FibonacciNumbers
    {

        public static void computeFibonacci()
        {
            Console.WriteLine("Introduce last number:");
            int lastNumber =Int32.Parse( Console.ReadLine().ToString());

            Console.WriteLine("Fibonacci numbers:");
            List<string> fibLst = new List<string>();
            int x = 0;
            int y = 1;

            fibLst.AddRange(new string[]{"0", "1",});

            for (int i = 2; i < lastNumber; i++)
            {
                int temp = x;
                x = y;
                y = temp + y;
                fibLst.Add(y.ToString());
            }

                foreach (var v in fibLst)
                {
                    Console.WriteLine(v.ToString());
                }
                Console.ReadLine();
        }

        public static void computeFibonacciAlt(int a, int b, int counter, int lastIndex)
        {


            if (counter < lastIndex)
            {
                Console.WriteLine(a.ToString());
                computeFibonacciAlt(b, a + b,++counter, lastIndex);
            }

          
        }

        static void Main(string[] args)
        {
            computeFibonacci();

            Console.WriteLine("Enter limit number:");
            string index = Console.ReadLine();
            int lastIndex = Int32.Parse(index);
            computeFibonacciAlt(0, 1, 0, lastIndex);
            Console.ReadLine();
        }
    }
}
