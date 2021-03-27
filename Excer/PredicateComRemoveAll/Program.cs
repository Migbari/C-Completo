using PredicateComRemoveAll.Entities;
using System;
using System.Collections.Generic;

namespace PredicateComRemoveAll
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> listProducts = new List<Product>();

            listProducts.Add(new Product("Tv", 750.00));
            listProducts.Add(new Product("Dvd", 150.00));
            listProducts.Add(new Product("Som", 350.00));
            listProducts.Add(new Product("Conversor Digital", 120.00));

            listProducts.RemoveAll(p => p.Preco < 160.00); 

            foreach (Product p in listProducts)
            {
                Console.WriteLine(p);
            }
            Console.ReadLine();
        }
    }
}