using System;
using System.Collections.Generic;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 10, 20, 30, 40, 50 };
            numbers.Insert(2, 55);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            //Console.WriteLine("Hello World!");
        }
    }
}
