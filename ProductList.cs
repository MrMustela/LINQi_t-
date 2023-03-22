using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LINQi_töö
{
    public class ProductList
    {
        public static readonly List<Product> products = new List<Product>
        {
            new Product()
            {
                Id = 1,
                Name = "Juice",
            },
            new Product()
            {
                Id = 2,
                Name = "Cheese",
            },
            new Product()
            {
                Id = 3,
                Name = "Apple",
            },
            new Product()
            {
                Id = 4,
                Name = "Banana",
            },
            new Product()
            {
                Id = 5,
                Name = "Jar jam",
            },
            new Product()
            {
                Id = 6,
                Name = "Chips",
            },
            new Product()
            {
                Id = 7,
                Name = "Milk",
            }
        };
    }
}
