namespace OCPFilter
{
    public class ColourSpecification : ISpecification<Product>
    {
        private readonly Colour colour;

        public ColourSpecification(Colour colour)
        {
            this.colour = colour;
        }

        public bool IsSatisfied(Product product)
        {
            return product.Colour == colour;
        }
    }
}
