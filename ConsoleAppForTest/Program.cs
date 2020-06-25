using System;
using System.Collections.Generic;
using System.Linq;


namespace ConsoleAppForTest
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            List<string> result = new List<string> { "Pedro" };
            result.Add("Carlos");
            result.Add("Ramon");

            string concat = string.Join(",", result);
            Console.WriteLine(concat);

            string concat2 = "Pedro, Carlos, Ramon";

            List<string> result2 = concat2.Split(',').ToList<string>();
            Console.WriteLine(result2);


        }
    }
}
