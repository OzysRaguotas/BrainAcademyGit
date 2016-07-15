using System;
using Collections.Generic;

namespace BrainAcademyGIT
{
public class Customer
{
List<Products> products { get; set; }
        public Customer(List<Products> products)
        {
            this.Products = products;
        }
        public void PrintProducts()
        {
            foreach (Product p in this.products)
                Console.WriteLine("{0}, {1}" p.Price, p.Name);
        }
}
}