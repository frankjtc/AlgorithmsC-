using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConvertToHex
{
    class ConvertToHex
    {
        private static string ConvertRGB(int r, int g, int b)
        {
            string hexR = r.ToString("X");
            string hexG = g.ToString("X");
            string hexB = b.ToString("X");

            return hexR + " " + hexG + " " + hexB;
        }

        static void Main(string[] args)
        {
            string convertedStr = ConvertRGB(666,665,664);
            Console.WriteLine(convertedStr);
            Console.ReadLine();
        }
    }
}
