using System;
using System.Collections.Generic;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<int, string> dict = new Dictionary<int, string>();
            Console.WriteLine("Hello World");
            Console.WriteLine("Programming is fun.");
        }

        public void printLines()
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("Programming is fun.");
        }
    }
}
