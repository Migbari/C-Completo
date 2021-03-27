using ProductComparison.Entities;
using System;
using System.Collections.Generic;

namespace ProductComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Food> list = new List<Food>();

            list.Add(new Food("Banana", 5.50));
            list.Add(new Food("Apple", 7.50));
            list.Add(new Food("Lime", 2.50));

            list.Sort((f1, f2) => f1.Name.ToUpper().CompareTo(f2.Name.ToUpper()));

            foreach (Food f in list)
            {
                Console.WriteLine(f);
            }
            Console.ReadLine();
        }
    }
}
