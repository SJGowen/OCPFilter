using System;

namespace OCPFilter
{
    public class Product
    {
        public string Name { get; set; }
        public Colour Colour { get; set; }
        public Size Size { get; set; }

        public Product(string name, Colour colour, Size size)
        {
            Name = name ?? throw new ArgumentNullException(paramName: nameof(name));
            Colour = colour;
            Size = size;
        }
    }
}