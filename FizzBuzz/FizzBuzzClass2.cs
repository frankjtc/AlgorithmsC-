using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class FizzBuzz2 : IFizzBuzz
    {
        public void fizzBuzz()
        {

            int[] values = new int[100];
            for (int i = 0; i < 100; i++) { values[i] = i; }

            Console.WriteLine("FizzBuzzClass2");


            foreach (var v in values)
            {
                string output = String.Empty;
                if (v % 3 == 0) { output = "Fizz"; }
                if (v % 5 == 0) { output += "Buzz"; }

                Console.WriteLine("value:" + v + " " + output);
            }

            Console.ReadLine();

        }

        public void Main(string[] args)
        {
            FizzBuzz2 o = new FizzBuzz2();
            o.fizzBuzz();
        }
    }
}
