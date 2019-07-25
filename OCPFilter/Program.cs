using System;

namespace OCPFilter
{
    class Program
    {
        private static void Main(string[] args)
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

           Console.WriteLine("Not Green Products:");
           foreach (var product in filter.Filter(products, 
               new NotSpecification<Product>(
                   new ColourSpecification(Colour.Green))))
           {
               Console.WriteLine($" - {product.Name} is not green");
           }

           Console.WriteLine("Green or Small Products:");
           foreach (var product in filter.Filter(products,
               new OrSpecification<Product>(
                   new ColourSpecification(Colour.Green), new SizeSpecification(Size.Small))))
           {
               Console.WriteLine($" - {product.Name} is green or small");
           }

           Console.WriteLine("Strawberry Products:");
           foreach (var product in filter.Filter(products,
               new NameSpecification("Strawberry")))
           {
               Console.WriteLine($" - {product.Name} is a strawberry");
           }

           Console.WriteLine("Named Products:");
           foreach (var product in filter.Filter(products,
               new OrSpecification<Product>(new OrSpecification<Product>(
                   new NameSpecification("Strawberry"), new NameSpecification("Grape")), new NameSpecification("Apple"))))
           {
               Console.WriteLine($" - {product.Name} is a strawberry or a grape or an apple");
           }
        }
    }
}
