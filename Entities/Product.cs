using System;
using System.Collections.Generic;
using System.Text;

namespace GameMarketSimulation.Entities
{
    class Product
    {
        public Product()
        {

        }

        public Product(int id, string name, DateTime dateAdded, double price, string detail)
        {
            Id = id; Name = name; DateAdded = dateAdded; Price = price; Detail = detail; ;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
        public DateTime DateAdded { get; set; }
        public double Price { get; set; }
    }
}
