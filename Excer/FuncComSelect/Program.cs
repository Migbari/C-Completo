﻿using FuncComSelect.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FuncComSelect
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            List<double> result = list.Select(p => p.Price + p.Price * 0.1).ToList();

            foreach (double s in result)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
}