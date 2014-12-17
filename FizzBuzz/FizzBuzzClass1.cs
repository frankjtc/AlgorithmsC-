using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class FizzBuzz1 : IFizzBuzz
    {
        public void fizzBuzz()
        {
            Console.WriteLine("FizzBuzzClass1");

            for (int i = 0; i < 100; i++)
            {
                string output = String.Empty;

                if (i % 3 == 0) { output =  "Fizz"; }
                if (i % 5 == 0) { output += "Buzz"; }
               // if (i % 15 == 0) { output = "FIzzBuzz"; }

                Console.WriteLine( "value: " + i + " " + output);
              
            }
            Console.ReadLine();
        
        }

   

        static void Main(string[] args)
        {
            FizzBuzz1 myObj = new FizzBuzz1();
            myObj.fizzBuzz();
        }
    }
}
