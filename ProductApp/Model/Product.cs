using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Model
{
    internal class Product : IComparable<Product>
    {
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Product()
        {

        }

        public Product(string? description, decimal price, int quantity)
        {
            Description = description;
            Price = price;
            Quantity = quantity;
        }

        public int CompareTo(Product? other)
        {
            return Description!.CompareTo(other!.Description);
        }

        public override string? ToString()
        {
            return $"{Description} {Price} {Quantity}";
        }
    }
}
