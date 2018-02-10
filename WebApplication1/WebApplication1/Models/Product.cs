using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }

        public List<Product> ProductsList()
        {
            List<Product> Products = new List<Product>();
            Product p1 = new Product { Id = 1, name = "Shampoo", Category = "Body Care", Price = 50 };
            Product p2 = new Product { Id = 2, name = "Shoe", Category = "Foot Care", Price = 500 };
            Product p3 = new Product { Id = 3, name = "Polo T-Shirt", Category = "Cloths", Price = 300 };
            Product p4 = new Product { Id = 4, name = "Water Bottle", Category = "HouseHold", Price = 20 };
            Product p5 = new Product { Id = 5, name = "Book", Category = "Study", Price = 15 };
            Product p6 = new Product { Id = 6, name = "Bag", Category = "Study", Price = 250 };
            Products.Add(p1);Products.Add(p2);Products.Add(p3);Products.Add(p4);Products.Add(p5);Products.Add(p6);

            return Products;
        }
    }
}