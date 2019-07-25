namespace OCPFilter
{
    public class NameSpecification : ISpecification<Product>
    {
        private readonly string name;

        public NameSpecification(string name)
        {
            this.name = name;
        }

        public bool IsSatisfied(Product product)
        {
            return product.Name == name;
        }
    }
}
