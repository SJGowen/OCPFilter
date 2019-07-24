using System;

namespace OCPFilter
{
    class Program
    {
        static void Main(string[] args)
        {
           var strawberry = new Product("Strawberry", Colour.Red, Size.Small);
           var grape = new Product("Grape", Colour.Green, Size.Small);
           var apple = new Product("Apple", Colour.Green, Size.Medium);

           Product[] products = {strawberry, grape, apple};

           var filter = new ProductFilter();

           Console.WriteLine("Green Products:");
           foreach (var product in filter.Filter(products, new ColourSpecification(Colour.Green)))
           {
               Console.WriteLine($" - {product.Name} is green");
           }

           Console.WriteLine("Small Products:");
           foreach (var product in filter.Filter(products, new SizeSpecification(Size.Small)))
           {
               Console.WriteLine($" - {product.Name} is small");
           }

           Console.WriteLine("Green and Small Products:");
           foreach (var product in filter.Filter(products, 
               new AndSpecification<Product>(
                   new ColourSpecification(Colour.Green), new SizeSpecification(Size.Small))))
           {
               Console.WriteLine($" - {product.Name} is green and small");
           }
        }
    }
}
