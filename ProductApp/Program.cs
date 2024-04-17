using ProductApp.Model;
using System.Linq;

namespace ProductApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var products = new List<Product>() { new Product("Oranges", 12m, 10), 
                                            new Product("Apples", 20m, 80),
                                            new Product("Honey", 34.5m, 61), 
                                            new Product("Honey", 8.2m, 4)};

            products.Sort();
            products.ForEach(p => Console.WriteLine(p));
            products.Sort((p1, p2) => p1.Price.CompareTo(p2.Price));
            products.Sort((p1, p2) => p1.Quantity - p2.Quantity);


            IEnumerable<Product> sorted = products.OrderBy(product => product.Price)
                .ThenByDescending(product => product.Quantity);

            var sum = (from product in products
                       select product.Quantity).Sum();

            var sum2 = products.Where(product => product.Description == "Honey")
                                .Select(product => product.Quantity).Sum();
        }
    }
}