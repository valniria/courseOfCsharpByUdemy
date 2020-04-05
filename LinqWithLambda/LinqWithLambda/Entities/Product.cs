using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace LinqWithLambda.Entities
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }

        public Product()
        {
        }
        public Product(int id, string name, double price, Category Category)
        {
            Id = id;
            Name = name;
            Price = price;
            Category = Category;
        }

        public override string ToString()
        {
            return Id
                + ", "
                + Name
                + ", "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Category.Name
                + ", "
                + Category.Tier;
        }
    }
}
