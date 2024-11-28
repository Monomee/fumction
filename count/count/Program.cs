using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace count
{
    internal class Program
    {   
        static int countChar(string s, char c)
        {
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c) { count++; }
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            Console.WriteLine("Enter a char to count:");
            char c = Char.Parse(Console.ReadLine());
            Console.WriteLine("Count: "+ countChar(str, c));
            Console.ReadLine();
        }
    }
}
