using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    class MultiplicationTable
    {
        public static void multiplicationFunction(int limit)
        {
            Console.WriteLine("\n");
            for (int i = 1; i <= limit; i++)
            {
                for (int j = 1; j <= limit; j++)
                {
                    Console.Write(i*j + "\t");
                }
                Console.WriteLine("\n");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Introduce final number:");
            string limit = Console.ReadLine();
            multiplicationFunction(Int32.Parse(limit));
            Console.ReadLine();

        }
    }
}
