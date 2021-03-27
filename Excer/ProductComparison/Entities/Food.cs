using System;
using System.Globalization;

namespace ProductComparison.Entities
{
    public class Food
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Food(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public override string ToString()
        {
            return Name + ", " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
