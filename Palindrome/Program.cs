using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Palindrome
    {
        public static void isPalindrome(string str)
        { 
            int length=str.Length/2;
            string firstHalf = str.Substring(0, length );
            string temp = ReverseStr(str);
            string secondHalf = temp.Substring(0,length);

            if (firstHalf.Equals(secondHalf))
            {
                Console.WriteLine("It is palindrome: " + temp);
            }
            else { Console.WriteLine("Nope"); }

        }

        public static string ReverseStr(string s)
        {
            string reversedStr = String.Empty;

            char[] arr = s.ToCharArray();
            int length=s.Length;
            int last=s.Length-1;

            for (int i = 0; i < length/2; i++)
            {
                char temp = arr[i];
                arr[i] = arr[last-i];
                arr[last-i] = temp;

            }

            reversedStr =new string( arr);
            return reversedStr;

        }

        static void Main(string[] args)
        {
            string str=Console.ReadLine();
            isPalindrome(str);
            Console.ReadLine();
        }
    }
}
